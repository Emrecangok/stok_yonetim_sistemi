using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace stok_.classes.sql_classes
{
    class Products_repo : Db_helper
    {
        public Products_repo(String connection_string) : base(connection_string) { }

        public void add_product(Product product)
        {
            string query = "INSERT INTO products(product_name, category_id, unit_price, current_stock, min_stock_level) " +
                           "VALUES(@name, @category_id, @price, @stock, @min_stock)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", product.name),
                new NpgsqlParameter("@category_id", product.category_id),
                new NpgsqlParameter("@price", product.price),
                new NpgsqlParameter("@stock", product.stock_quantity),
                new NpgsqlParameter("@min_stock", product.product_min_stock_level)
            };

            execute_non_query(query, parameters);
        }

        public void view_products(DataGridView gridView)
        {
            gridView.Rows.Clear();
            string query = "SELECT product_id, product_name, category_id, unit_price, current_stock, min_stock_level FROM products";

            try
            {
                gridView.AutoGenerateColumns = false;

                var dataTable = execute_query(query);

                if (gridView.Columns.Count == 0)
                {
                    gridView.Columns.Add("product_id", "Ürün ID");
                    gridView.Columns.Add("product_name", "Ürün Adı");
                    gridView.Columns.Add("category_id", "Kategori ID");
                    gridView.Columns.Add("unit_price", "Birim Fiyat");
                    gridView.Columns.Add("current_stock", "Mevcut Stok");
                    gridView.Columns.Add("min_stock_level", "Minimum Stok Seviyesi");
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    gridView.Rows.Add(row["product_id"], row["product_name"], row["category_id"],
                                      row["unit_price"], row["current_stock"], row["min_stock_level"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünleri listelerken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update_product(int productId, string newName, int newCategoryId, decimal newPrice, int newStock, int newMinStock)
        {
            string query = "UPDATE products SET product_name = @newName, category_id = @newCategoryId, " +
                           "unit_price = @newPrice, current_stock = @newStock, min_stock_level = @newMinStock " +
                           "WHERE product_id = @productId";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@newName", newName),
                new NpgsqlParameter("@newCategoryId", newCategoryId),
                new NpgsqlParameter("@newPrice", newPrice),
                new NpgsqlParameter("@newStock", newStock),
                new NpgsqlParameter("@newMinStock", newMinStock),
                new NpgsqlParameter("@productId", productId)
            };

            execute_non_query(query, parameters);
        }

        public void update_selected_product(DataGridView gridView, string newName, int newCategoryId, decimal newPrice, int newStock, int newMinStock)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(gridView.SelectedRows[0].Cells["product_id"].Value);

                update_product(productId, newName, newCategoryId, newPrice, newStock, newMinStock);

                MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                view_products(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete_product(int productId)
        {
            string query = "DELETE FROM products WHERE product_id = @productId";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@productId", productId)
            };

            execute_non_query(query, parameters);
        }

        public void delete_selected_product(DataGridView gridView)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(gridView.SelectedRows[0].Cells["product_id"].Value);

                delete_product(productId);

                view_products(gridView);

                MessageBox.Show("Ürün başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
