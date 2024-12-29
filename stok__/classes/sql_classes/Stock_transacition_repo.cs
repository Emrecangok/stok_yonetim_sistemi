using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using stok_.classes;
using stok_.classes.sql_classes;

namespace stok_.classes.sql_classes
{
    public class Stock_transaction_repo : Db_helper
    {
        public Stock_transaction_repo(string connection_string) : base(connection_string) { }

        // Stok ekleme
        public void AddStock(int product_id, int warehouse_id, int quantity, int user_id, int supplier_id, DateTime supply_date)
        {
            string query = @"
                -- Tedarikçi-Ürün kaydını oluştur veya güncelle
                INSERT INTO supplier_product (supplier_id, product_id, supply_date, quantity)
                VALUES (@supplier_id, @product_id, @supply_date, @quantity)
                ON CONFLICT (supplier_id, product_id)
                DO UPDATE SET quantity = supplier_product.quantity + @quantity;

                -- Stok işlem kaydı ekle
                INSERT INTO stock_transactions (user_id, product_id, transaction_type, quantity, transaction_date,warehouse_id)
                VALUES (@user_id, @product_id, 'add', @quantity, @transaction_date,@warehouse_id);

                -- Depo stoğunu güncelle veya oluştur
                INSERT INTO product_warehouse (warehouse_id, product_id, stock_quantity)
                VALUES (@warehouse_id, @product_id, @quantity)
                ON CONFLICT (warehouse_id, product_id)
                DO UPDATE SET stock_quantity = product_warehouse.stock_quantity + @quantity;
            ";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@product_id", product_id),
                new NpgsqlParameter("@warehouse_id", warehouse_id),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@user_id", user_id),
                new NpgsqlParameter("@supplier_id", supplier_id),
                new NpgsqlParameter("@supply_date", supply_date),
                new NpgsqlParameter("@transaction_date", DateTime.Now)
            };

            execute_query(query, parameters);
        }

        public void RemoveStock(int product_id, int warehouse_id, int quantity, int user_id, DateTime transaction_date)
        {
            string query = @"
    BEGIN;

    -- Stok işlem kaydı ekle
    INSERT INTO stock_transactions (user_id, warehouse_id, product_id, quantity, transaction_type, transaction_date)
    VALUES (@user_id, @warehouse_id, @product_id, @quantity, 'remove', @transaction_date);

    -- Stok miktarını güncelle
    UPDATE product_warehouse
    SET stock_quantity = stock_quantity - @quantity
    WHERE warehouse_id = @warehouse_id AND product_id = @product_id AND stock_quantity >= @quantity;

    COMMIT;
    ";

            var parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@user_id", user_id),
        new NpgsqlParameter("@warehouse_id", warehouse_id),
        new NpgsqlParameter("@product_id", product_id),
        new NpgsqlParameter("@quantity", quantity),
        new NpgsqlParameter("@transaction_date", transaction_date)
            };

            try
            {
                execute_non_query(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Stok çıkarma işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }


        public void WarehouseTransfer(int product_id, int source_warehouse_id, int target_warehouse_id, int quantity, int user_id)
        {
            // Aynı depolar arasında transfer yapılmasını engelle
            if (source_warehouse_id == target_warehouse_id)
            {
                throw new Exception("Kaynak depo ve hedef depo aynı olamaz. Lütfen farklı depolar seçiniz.");
            }

            string query = @"
        BEGIN;

        -- Kaynak depodan transfer kaydı oluştur
        INSERT INTO stock_transactions (user_id, warehouse_id, product_id, quantity, transaction_type, transaction_date)
        VALUES (@user_id, @source_warehouse_id, @product_id, @quantity, 'transfer_out', @transaction_date);

        -- Hedef depoya transfer kaydı oluştur
        INSERT INTO stock_transactions (user_id, warehouse_id, product_id, quantity, transaction_type, transaction_date)
        VALUES (@user_id, @target_warehouse_id, @product_id, @quantity, 'transfer_in', @transaction_date);

        -- Kaynak depo stoğunu güncelle
        UPDATE product_warehouse
        SET stock_quantity = stock_quantity - @quantity
        WHERE warehouse_id = @source_warehouse_id AND product_id = @product_id AND stock_quantity >= @quantity;

        -- Hedef depo stoğunu güncelle veya ekle
        INSERT INTO product_warehouse (warehouse_id, product_id, stock_quantity)
        VALUES (@target_warehouse_id, @product_id, @quantity)
        ON CONFLICT (warehouse_id, product_id)
        DO UPDATE SET stock_quantity = product_warehouse.stock_quantity + @quantity;

        COMMIT;
    ";

            var parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@user_id", user_id),
        new NpgsqlParameter("@source_warehouse_id", source_warehouse_id),
        new NpgsqlParameter("@target_warehouse_id", target_warehouse_id),
        new NpgsqlParameter("@product_id", product_id),
        new NpgsqlParameter("@quantity", quantity),
        new NpgsqlParameter("@transaction_date", DateTime.Now)
            };

            try
            {
                execute_non_query(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Depolar arası transfer işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }


        public void LoadStockTransactions(DataGridView dataGridView)
        {
            try
            {
                string query = @"
            SELECT 
                st.transaction_type AS ""İşlem Türü"",
                u.user_name AS ""İşlemi Yapan"",
                p.product_name AS ""Ürün Adı"",
                COALESCE(w.ware_house_name, 'N/A') AS ""Depo"",
                st.quantity AS ""Miktar"",
                st.transaction_date AS ""Tarih""
            FROM 
                stock_transactions st
            LEFT JOIN users u ON st.user_id = u.user_id
            LEFT JOIN products p ON st.product_id = p.product_id
            LEFT JOIN ware_houses w ON st.warehouse_id = w.ware_house_id
            ORDER BY st.transaction_date DESC;
        ";

                // Sorguyu çalıştır ve sonuçları bir DataTable içine al
                DataTable transactions = execute_query(query);

                // DataGridView'e bu tabloyu ata
                dataGridView.DataSource = transactions;
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşlemler yüklenirken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
       

      /*  public void AddStock(int product_id, int warehouse_id, int quantity, int user_id, int supplier_id, DateTime supply_date)
        {
            string connString = "Host=localhost;Username=postgres;Password=yourpassword;Database=yourdatabase";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "CALL add_stock(@product_id, @warehouse_id, @quantity, @user_id, @supplier_id, @supply_date);";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_id", product_id);
                    cmd.Parameters.AddWithValue("@warehouse_id", warehouse_id);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@supplier_id", supplier_id);
                    cmd.Parameters.AddWithValue("@supply_date", supply_date);

                    cmd.ExecuteNonQuery();
                }
            }
        }*/


        /*  public void AddStock(int productId, int warehouseId, int quantity, int userId, int supplierId, DateTime supplyDate)
          {
              string query = "CALL add_stock(@product_id, @warehouse_id, @quantity, @user_id, @supplier_id, @supply_date)";
              execute_non_query(query,
                  new NpgsqlParameter("@product_id", productId),
                  new NpgsqlParameter("@warehouse_id", warehouseId),
                  new NpgsqlParameter("@quantity", quantity),
                  new NpgsqlParameter("@user_id", userId),
                  new NpgsqlParameter("@supplier_id", supplierId),
                  new NpgsqlParameter("@supply_date", supplyDate));
          }*/

        /// <summary>
        /// Stok çıkarma işlemi
        /// </summary>
      /*  public void RemoveStock(int productId, int warehouseId, int quantity, int userId, DateTime transactionDate)
        {
            string query = "CALL remove_stock(@product_id, @warehouse_id, @quantity, @user_id, @transaction_date)";
            execute_non_query(query,
                new NpgsqlParameter("@product_id", productId),
                new NpgsqlParameter("@warehouse_id", warehouseId),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@user_id", userId),
                new NpgsqlParameter("@transaction_date", transactionDate));
        }

        /// <summary>
        /// Depolar arası transfer işlemi
        /// </summary>
        public void WarehouseTransfer(int productId, int sourceWarehouseId, int targetWarehouseId, int quantity, int userId)
        {
            string query = "CALL warehouse_transfer(@product_id, @source_warehouse_id, @target_warehouse_id, @quantity, @user_id)";
            execute_non_query(query,
                new NpgsqlParameter("@product_id", productId),
                new NpgsqlParameter("@source_warehouse_id", sourceWarehouseId),
                new NpgsqlParameter("@target_warehouse_id", targetWarehouseId),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@user_id", userId));
        }

        

        public void LoadStockTransactions(DataGridView dataGridView)
        {
            string query = @"
            SELECT 
                st.transaction_id AS ""İşlem ID"",
                st.transaction_type AS ""İşlem Türü"",
                u.user_name AS ""Kullanıcı"",
                p.product_name AS ""Ürün"",
                COALESCE(w.ware_house_name, 'N/A') AS ""Depo"",
                st.quantity AS ""Miktar"",
                st.transaction_date AS ""Tarih""
            FROM 
                stock_transactions st
            LEFT JOIN users u ON st.user_id = u.user_id
            LEFT JOIN products p ON st.product_id = p.product_id
            LEFT JOIN ware_houses w ON st.warehouse_id = w.ware_house_id
            ORDER BY st.transaction_date DESC;";

            LoadDataToGridView(dataGridView, query);
        }
      */
        /// <summary>
        /// Tarih aralığına göre stok işlemlerini DataGridView'e yükler
        /// </summary>
        public void LoadStockTransactionLogsByDateRange(DataGridView gridView, DateTime startDate, DateTime endDate)
        {
            string query = @"
            SELECT 
                st.transaction_id AS ""İşlem ID"",
                st.transaction_type AS ""İşlem Türü"",
                u.user_name AS ""Kullanıcı"",
                p.product_name AS ""Ürün"",
                COALESCE(w.ware_house_name, 'N/A') AS ""Depo"",
                st.quantity AS ""Miktar"",
                st.transaction_date AS ""Tarih""
            FROM 
                stock_transactions st
            LEFT JOIN users u ON st.user_id = u.user_id
            LEFT JOIN products p ON st.product_id = p.product_id
            LEFT JOIN ware_houses w ON st.warehouse_id = w.ware_house_id
            WHERE 
                st.transaction_date BETWEEN @startDate AND @endDate
            ORDER BY st.transaction_date DESC;";

            LoadDataToGridView(gridView, query,
                new NpgsqlParameter("@startDate", startDate),
                new NpgsqlParameter("@endDate", endDate));
        }

        /// <summary>
        /// Verileri DataGridView'e yükler
        /// </summary>
        private void LoadDataToGridView(DataGridView gridView, string query, params NpgsqlParameter[] parameters)
        {
            try
            {
                DataTable dataTable = execute_query(query, parameters);
                gridView.DataSource = dataTable;
                gridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadStockTransactionLogsByNameAndDateRange(
    DataGridView gridView,
    string userName,
    DateTime startDate,
    DateTime endDate)
        {
            try
            {
                string query = @"
            SELECT 
                st.transaction_id AS ""İşlem ID"",
                st.transaction_type AS ""İşlem Türü"",
                u.user_name AS ""Kullanıcı"",
                p.product_name AS ""Ürün"",
                COALESCE(w.ware_house_name, 'N/A') AS ""Depo"",
                st.quantity AS ""Miktar"",
                st.transaction_date AS ""Tarih""
            FROM 
                stock_transactions st
            LEFT JOIN users u ON st.user_id = u.user_id
            LEFT JOIN products p ON st.product_id = p.product_id
            LEFT JOIN ware_houses w ON st.warehouse_id = w.ware_house_id
            WHERE 
                u.user_name ILIKE @userName AND
                st.transaction_date BETWEEN @startDate AND @endDate
            ORDER BY st.transaction_date DESC;";

                var parameters = new NpgsqlParameter[]
                {
            new NpgsqlParameter("@userName", $"%{userName}%"),
            new NpgsqlParameter("@startDate", startDate),
            new NpgsqlParameter("@endDate", endDate)
                };

                LoadDataToGridView(gridView, query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loglar yüklenirken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    }

}
