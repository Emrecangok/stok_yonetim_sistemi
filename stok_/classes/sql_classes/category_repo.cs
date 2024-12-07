using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stok_.classes.sql_classes
{
    class Categories_repo : Db_helper
    {
        public Categories_repo(string connection_string) : base(connection_string) { }

        // Kategori ekleme
        public void add_category(Categories category)
        {
            if (!category.is_valid(out string error_message))
            {
                MessageBox.Show(error_message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO categories (category_name) VALUES (@name)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", category.category_name)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Kategori başarıyla eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Kategorileri görüntüleme
        public void view_categories(DataGridView gridView)
        {
            gridView.Rows.Clear();
            string query = "SELECT category_id, category_name FROM categories";

            try
            {
                gridView.AutoGenerateColumns = false;
                var dataTable = execute_query(query);

                if (gridView.Columns.Count == 0)
                {
                    gridView.Columns.Add("category_id", "ID");
                    gridView.Columns.Add("category_name", "Kategori Adı");
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    gridView.Rows.Add(row["category_id"], row["category_name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategoriler listelenirken bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kategori güncelleme
        public void update_category(int categoryId, string newCategoryName)
        {
            string query = "UPDATE categories SET category_name = @name WHERE category_id = @id";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", newCategoryName),
                new NpgsqlParameter("@id", categoryId)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Kategori başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void update_selected_category(DataGridView gridView, string newCategoryName)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int categoryId = Convert.ToInt32(gridView.SelectedRows[0].Cells["category_id"].Value);
                update_category(categoryId, newCategoryName);
                view_categories(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kategori silme
        public void delete_category(int categoryId)
        {
            string query = "DELETE FROM categories WHERE category_id = @id";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", categoryId)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Kategori başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void delete_selected_category(DataGridView gridView)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int categoryId = Convert.ToInt32(gridView.SelectedRows[0].Cells["category_id"].Value);
                delete_category(categoryId);
                view_categories(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
