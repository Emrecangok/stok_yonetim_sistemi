using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stok_.classes.sql_classes
{
    class Products_repo : Db_helper
    {
        public Products_repo(string connection_string) : base(connection_string) { }

        // Ürün ekleme
        public void add_product(Product product)
        {
            string query = "INSERT INTO products(product_name, category_id, unit_price, min_stock_level) " +
                           "VALUES(@name, @category_id, @price, @min_stock)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", product.name),
                new NpgsqlParameter("@category_id", product.category_id),
                new NpgsqlParameter("@price", product.price),
                new NpgsqlParameter("@min_stock", product.product_min_stock_level)
            };

            execute_non_query(query, parameters);
        }

        // Ürün listeleme
        public void view_products(DataGridView gridView)
        {
            gridView.Rows.Clear();


            string query = @"
        SELECT 
            p.product_id, 
            p.product_name, 
            c.category_name, 
            p.unit_price, 
            p.min_stock_level
        FROM products AS p
        JOIN categories AS c ON p.category_id = c.category_id";


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
                    gridView.Columns.Add("min_stock_level", "Minimum Stok Seviyesi");
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    gridView.Rows.Add(row["product_id"], row["product_name"], row["category_name"],
                                      row["unit_price"], row["min_stock_level"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünleri listelerken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ürün güncelleme
        public void update_product(int productId, string newName, int newCategoryId, decimal newPrice, int newMinStock)
        {
            string query = "UPDATE products SET product_name = @newName, category_id = @newCategoryId, " +
                           "unit_price = @newPrice, min_stock_level = @newMinStock " +
                           "WHERE product_id = @productId";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@newName", newName),
                new NpgsqlParameter("@newCategoryId", newCategoryId),
                new NpgsqlParameter("@newPrice", newPrice),
                new NpgsqlParameter("@newMinStock", newMinStock),
                new NpgsqlParameter("@productId", productId)
            };

            execute_non_query(query, parameters);
        }

        public void update_selected_product(DataGridView gridView, string newName, int newCategoryId, decimal newPrice, int newMinStock)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(gridView.SelectedRows[0].Cells["product_id"].Value);

                update_product(productId, newName, newCategoryId, newPrice, newMinStock);

                MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                view_products(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ürün silme
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
        // Ürünleri veritabanından çek ve ComboBox'a ekle
        public void _load_products_into_combo_box(ComboBox combo_box)
        {
            string query = "SELECT product_id, product_name FROM products";
            DataTable data_table = execute_query(query); // Veritabanı sorgusunu çalıştır

            combo_box.Items.Clear(); // ComboBox'u temizle

            combo_box.ValueMember = "product_id";
            combo_box.DisplayMember = "product_name";
            combo_box.DataSource = data_table;


        }
        public void view_low_stock_products(DataGridView gridView)
        {
            gridView.Rows.Clear();

            string query = @"
                SELECT 
                    p.product_id, 
                    p.product_name, 
                    c.category_name, 
                    p.unit_price, 
                    p.min_stock_level, 
                    COALESCE(SUM(pw.quantity), 0) AS current_stock
                FROM products AS p
                LEFT JOIN categories AS c ON p.category_id = c.category_id
                LEFT JOIN product_warehouse AS pw ON p.product_id = pw.product_id
                GROUP BY p.product_id, c.category_name, p.unit_price, p.min_stock_level
                HAVING COALESCE(SUM(pw.quantity), 0) < p.min_stock_level";

            try
            {
                gridView.AutoGenerateColumns = false;

                var dataTable = execute_query(query);

                if (gridView.Columns.Count == 0)
                {
                    gridView.Columns.Add("product_id", "Ürün ID");
                    gridView.Columns.Add("product_name", "Ürün Adı");
                    gridView.Columns.Add("category_name", "Kategori Adı");
                    gridView.Columns.Add("unit_price", "Birim Fiyat");
                    gridView.Columns.Add("min_stock_level", "Minimum Stok Seviyesi");
                    gridView.Columns.Add("current_stock", "Mevcut Stok");
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    gridView.Rows.Add(row["product_id"], row["product_name"], row["category_name"],
                                      row["unit_price"], row["min_stock_level"], row["current_stock"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Düşük stoklu ürünleri listelerken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
