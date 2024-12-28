using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stok_.classes.sql_classes
{
    class User_repo : Db_helper
    {
        public User_repo(string connection_string) : base(connection_string) { }

        // Kullanıcı ekleme
        public void add_user(User user)
        {
            string query = "INSERT INTO users(user_name, user_surname, rol_id, password) " +
                           "VALUES(@name, @surname, @role_id, @password)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", user.name),
                new NpgsqlParameter("@surname", user.surname),
                new NpgsqlParameter("@role_id", user.role_id),
                new NpgsqlParameter("@password", user.password)
            };

            execute_non_query(query, parameters);
        }

        // Kullanıcı listeleme
        public void view_users(DataGridView gridView)
        {
            gridView.Rows.Clear();


            string query = @"
        SELECT 
            u.user_id, 
            u.user_name, 
            u.user_surname,
            r.role_name
        FROM users AS u
        JOIN roles AS r ON u.role_id = r.role_id";


            try
            {
                gridView.AutoGenerateColumns = false;

                var dataTable = execute_query(query);

                if (gridView.Columns.Count == 0)
                {
                    gridView.Columns.Add("user_id", "Kullanıcı ID");
                    gridView.Columns.Add("user_name", "Kullanıcı Adı");
                    gridView.Columns.Add("user_surname", "Kullanıcı Soyadı");
                    gridView.Columns.Add("role_id", "Rol ID");
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    gridView.Rows.Add(row["user_id"], row["user_name"], row["user_surname"], row["role_name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kullanıcıları listelerken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kullanıcı güncelleme
        public void update_user(int userId, string newName, string newSurname, int newRoleId, string newPassword)
        {
            string query = "UPDATE users SET user_name = @newName, user_surname = @newSurname, rol_id = @newRoleId, " +
                           "password = @newPassword " +
                           "WHERE user_id = @userId";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@newName", newName),
                new NpgsqlParameter("@newSurname", newSurname),
                new NpgsqlParameter("@newRoleId", newRoleId),
                new NpgsqlParameter("@newPassword", newPassword),
                new NpgsqlParameter("@userId", userId)
            };

            execute_non_query(query, parameters);
        }

        public void update_selected_user(DataGridView gridView, string newName, string newSurname, int newRoleId, string newPassword)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(gridView.SelectedRows[0].Cells["user_id"].Value);

                update_user(userId, newName, newSurname, newRoleId, newPassword);

                MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                view_users(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kullanıcı silme
        public void delete_user(int userId)
        {
            string query = "DELETE FROM users WHERE user_id = @userId";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@userId", userId)
            };

            execute_non_query(query, parameters);
        }

        public void delete_selected_user(DataGridView gridView)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(gridView.SelectedRows[0].Cells["user_id"].Value);

                delete_user(userId);

                view_users(gridView);

                MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Ürünleri veritabanından çek ve ComboBox'a ekle
        public void _load_users_into_combo_box(ComboBox combo_box)
        {
            string query = "SELECT user_id, user_name FROM users";
            DataTable data_table = execute_query(query); // Veritabanı sorgusunu çalıştır

            combo_box.Items.Clear(); // ComboBox'u temizle

            combo_box.ValueMember = "user_id";
            combo_box.DisplayMember = "user_name";
            combo_box.DataSource = data_table;


        }
    }
}
