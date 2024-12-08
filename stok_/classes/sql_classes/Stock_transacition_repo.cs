using System;
using System.Data;
using Npgsql;
using stok_.classes.sql_classes; // Db_helper erişimi için
using stok_.classes; // current_user sınıfına erişim için
using System.Windows.Forms;

namespace stok_.classes.sql_classes
{
    public class Stock_transacition_repo : Db_helper
    {
        public Stock_transacition_repo(string connection_string) : base(connection_string) { }

        public void add_stock_transaction(int warehouseId, int productId, int quantity)
        {
            // Transaction tablosuna ekleme sorgusu
            string transactionQuery = @"
                INSERT INTO stock_transactions 
                (user_id, warehouse_id, product_id, quantity, transaction_date) 
                VALUES (@userId, @warehouseId, @productId, @quantity, @date)";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@userId", current_user.id),
                new NpgsqlParameter("@warehouseId", warehouseId),
                new NpgsqlParameter("@productId", productId),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@date", DateTime.Now)
            };

            // Stok güncelleme sorgusu
            string updateStockQuery = @"
                INSERT INTO warehouse_stock (warehouse_id, product_id, stock_quantity) 
                VALUES (@warehouseId, @productId, @quantity)
                ON CONFLICT (warehouse_id, product_id) 
                DO UPDATE SET stock_quantity = warehouse_stock.stock_quantity + @quantity";

            var updateParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@warehouseId", warehouseId),
                new NpgsqlParameter("@productId", productId),
                new NpgsqlParameter("@quantity", quantity)
            };

            try
            {
                // Transaction kaydı ekle
                execute_non_query(transactionQuery, parameters);

                // Stok miktarını güncelle
                execute_non_query(updateStockQuery, updateParameters);

                MessageBox.Show("Ürün başarılı bir şekilde eklendi ve işlem kaydedildi.", "Bilgi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok ekleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
