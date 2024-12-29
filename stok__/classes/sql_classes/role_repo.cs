using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stok_.classes.sql_classes
{
    class Roles_repo : Db_helper
    {
        public Roles_repo(string connection_string) : base(connection_string) { }

        // Rol ekleme
        public void add_role(Roles role)
        {
            if (!role.is_valid(out string error_message))
            {
                MessageBox.Show(error_message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO roles (role_name) VALUES (@name)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", role.role_name)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Rol başarıyla eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Rolleri görüntüleme
        public void view_roles(DataGridView gridView)
        {
            gridView.Rows.Clear();
            string query = "SELECT role_id, role_name FROM roles";

            try
            {
                gridView.AutoGenerateColumns = false;
                var dataTable = execute_query(query);

                if (gridView.Columns.Count == 0)
                {
                    gridView.Columns.Add("role_id", "ID");
                    gridView.Columns.Add("role_name", "Rol Adı");
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    gridView.Rows.Add(row["role_id"], row["role_name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Roller listelenirken bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Rol güncelleme
        public void update_role(int roleId, string newRoleName)
        {
            string query = "UPDATE roles SET role_name = @name WHERE role_id = @id";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", newRoleName),
                new NpgsqlParameter("@id", roleId)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Rol başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void update_selected_role(DataGridView gridView, string newRoleName)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int roleId = Convert.ToInt32(gridView.SelectedRows[0].Cells["role_id"].Value);
                update_role(roleId, newRoleName);
                view_roles(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Rol silme
        public void delete_role(int roleId)
        {
            string query = "DELETE FROM roles WHERE role_id = @id";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", roleId)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Rol başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void delete_selected_role(DataGridView gridView)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int roleId = Convert.ToInt32(gridView.SelectedRows[0].Cells["role_id"].Value);
                delete_role(roleId);
                view_roles(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Rolleri veritabanından çek ve ComboBox'a ekle
        public void _load_roles_into_combo_box(ComboBox combo_box)
        {
            string query = "SELECT role_id, role_name FROM roles";
            DataTable data_table = execute_query(query); // Veritabanı sorgusunu çalıştır

            combo_box.Items.Clear(); // ComboBox'u temizle

            combo_box.ValueMember = "role_id";
            combo_box.DisplayMember = "role_name";
            combo_box.DataSource = data_table;


        }











    }
}
