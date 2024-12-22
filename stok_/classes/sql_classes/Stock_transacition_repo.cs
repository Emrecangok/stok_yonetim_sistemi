using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stok_.classes.sql_classes
{
    public class StockTransactionRepo
    {
        private readonly string _connectionString;

        public StockTransactionRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Stok ekleme işlemi
        /// </summary>
        public void AddStock(int productId, int warehouseId, int quantity, int userId, int supplierId, DateTime supplyDate)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("CALL add_stock(@product_id, @warehouse_id, @quantity, @user_id, @supplier_id, @supply_date)", connection))
                {
                    command.Parameters.AddWithValue("@product_id", productId);
                    command.Parameters.AddWithValue("@warehouse_id", warehouseId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@supplier_id", supplierId);
                    command.Parameters.AddWithValue("@supply_date", supplyDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Stok çıkarma işlemi
        /// </summary>
        public void RemoveStock(int productId, int warehouseId, int quantity, int userId, DateTime transactionDate)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("CALL remove_stock(@product_id, @warehouse_id, @quantity, @user_id, @transaction_date)", connection))
                {
                    command.Parameters.AddWithValue("@product_id", productId);
                    command.Parameters.AddWithValue("@warehouse_id", warehouseId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@transaction_date", transactionDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Depolar arası transfer işlemi
        /// </summary>
        public void WarehouseTransfer(int productId, int sourceWarehouseId, int targetWarehouseId, int quantity, int userId)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("CALL warehouse_transfer(@product_id, @source_warehouse_id, @target_warehouse_id, @quantity, @user_id)", connection))
                {
                    command.Parameters.AddWithValue("@product_id", productId);
                    command.Parameters.AddWithValue("@source_warehouse_id", sourceWarehouseId);
                    command.Parameters.AddWithValue("@target_warehouse_id", targetWarehouseId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Tüm stok işlemlerini DataGridView'e yükler
        /// </summary>
        public void LoadStockTransactions(DataGridView dataGridView)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
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
                        ORDER BY st.transaction_date DESC;
                    ";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable transactions = new DataTable();
                            adapter.Fill(transactions);
                            dataGridView.DataSource = transactions;
                            dataGridView.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşlemler yüklenirken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
