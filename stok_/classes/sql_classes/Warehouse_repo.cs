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
    class Warehouse_repo:Db_helper
    {
         public Warehouse_repo(String connection_string) : base(connection_string) { }

        public void add_warehouse(Ware_house ware)
        {
            
            string query = "INSERT INTO ware_houses(ware_house_name,address)VALUES(@name,@location)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name",ware.name),
                new NpgsqlParameter("@location", ware.location)
            };

            execute_non_query(query, parameters);
            


           
        }
        public void view_warehouses(DataGridView gridView)
        {
            gridView.Rows.Clear();
            string query = "SELECT ware_house_id, ware_house_name, address FROM ware_houses";

            try
            {
                // Otomatik sütun oluşturmayı devre dışı bırak
                gridView.AutoGenerateColumns = false;

                // SQL sorgusunu çalıştır ve sonuçları bir DataTable içine al
                var dataTable = execute_query(query);
               

                // Manuel olarak sütunları ekle (eğer eklenmemişse)
                if (gridView.Columns.Count == 0)
                {
                    gridView.Columns.Add("ware_house_id", "id");
                    gridView.Columns.Add("ware_house_name", "Depo Adı");
                    gridView.Columns.Add("address", "Adres");
                    
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    gridView.Rows.Add(row["ware_house_id"], row["ware_house_name"], row["address"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Depoları listelerken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void update_warehouse(int warehouseId, string newName, string newAddress)
        {
            string query = "UPDATE ware_houses SET ware_house_name = @newName, address = @newAddress WHERE ware_house_id = @warehouseId";

            var parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@newName", newName),
        new NpgsqlParameter("@newAddress", newAddress),
        new NpgsqlParameter("@warehouseId", warehouseId)
            };

            execute_non_query(query, parameters);
        }

        public void update_selected_warehouse(DataGridView gridView, string newName, string newAddress)
        {
            // Seçilen satır var mı kontrol et
            if (gridView.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki depo ID'sini al
                int warehouseId = Convert.ToInt32(gridView.SelectedRows[0].Cells["ware_house_id"].Value); // ID'nin kolon adı burada "id"

                // Güncelleme metodunu çağır
                update_warehouse(warehouseId, newName, newAddress);

                // Kullanıcıya bilgilendirme
                MessageBox.Show("Depo başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tabloyu yenileyebilirsiniz
                view_warehouses(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete_warehouse(int warehouseId)
        {
            string query = "DELETE FROM ware_houses WHERE ware_house_id = @warehouseId";

            var parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@warehouseId", warehouseId)
            };

            execute_non_query(query, parameters);
           
           
        }

        public void delete_selected_warehouse(DataGridView gridView)
        {
            // Seçilen satır var mı kontrol et
            if (gridView.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki depo ID'sini al
                int warehouseId = Convert.ToInt32(gridView.SelectedRows[0].Cells["ware_house_id"].Value); // ID'nin kolon adı burada "id"

                // Silme metodunu çağır
                delete_warehouse(warehouseId);
                view_warehouses(gridView);
                // Kullanıcıya bilgilendirme
                MessageBox.Show("Depo başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Depoları veritabanından çek ve ComboBox'a ekle
        public void _load_warehouses_into_combo_box(ComboBox combo_box)
        {
            string query = "SELECT ware_house_id, ware_house_name FROM ware_houses";
            DataTable data_table = execute_query(query); // Veritabanı sorgusunu çalıştır

            combo_box.Items.Clear(); // ComboBox'u temizle

            combo_box.ValueMember = "ware_house_id";
            combo_box.DisplayMember = "ware_house_name";
            combo_box.DataSource = data_table;


        }







    }

}
