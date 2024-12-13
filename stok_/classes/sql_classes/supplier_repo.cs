using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace stok_.classes.sql_classes
{
    class Supplier_repo : Db_helper
    {
        public Supplier_repo(string connection_string) : base(connection_string) { }

        // Tedarikçi ekleme
        public void add_supplier(Suppliers supplier)
        {
            if (!supplier.is_valid(out string error_message))
            {
                MessageBox.Show(error_message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO suppliers (supplier_name, phone) VALUES (@name, @phone)";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", supplier.supplier_name),
                new NpgsqlParameter("@phone", supplier.phone)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Tedarikçi başarıyla eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Tedarikçi görüntüleme
        public void view_suppliers(DataGridView gridView)
        {
            gridView.Rows.Clear();
            string query = "SELECT supplier_id, supplier_name, phone FROM suppliers";

            try
            {
                gridView.AutoGenerateColumns = false;
                var dataTable = execute_query(query);

                if (gridView.Columns.Count == 0)
                {
                    gridView.Columns.Add("supplier_id", "ID");
                    gridView.Columns.Add("supplier_name", "Tedarikçi Adı");
                    gridView.Columns.Add("phone", "Tedarikçi Telefon Numarası");
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    gridView.Rows.Add(row["supplier_id"], row["supplier_name"], row["phone"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tedarikçiler listelenirken bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tedarikçi güncelleme
        public void update_supplier(int supplierId, string newSupplierName, string newPhoneNumber)
        {
            string query = "UPDATE suppliers SET supplier_name = @name, phone = @phone WHERE supplier_id = @id";


            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", newSupplierName),
                new NpgsqlParameter("@id", supplierId),
                new NpgsqlParameter("@phone", newPhoneNumber)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Tedarikçi başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void update_selected_supplier(DataGridView gridView, string newSupplierName, string newPhoneNumber)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                int supplierId = Convert.ToInt32(gridView.SelectedRows[0].Cells["supplier_id"].Value);
                update_supplier(supplierId, newSupplierName, newPhoneNumber);
                view_suppliers(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tedarikçi silme
        public void delete_supplier(string supplierName, string supplierPhone)
        {
            string query = "DELETE FROM suppliers WHERE supplier_name = @name AND phone = @phone";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", supplierName),
                new NpgsqlParameter("@phone", supplierPhone)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Tedarikçi başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void delete_selected_supplier(DataGridView gridView)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                string supplierName = (string)gridView.SelectedRows[0].Cells["supplier_name"].Value;
                string supplierPhone = (string)gridView.SelectedRows[0].Cells["phone"].Value;
                delete_supplier(supplierName, supplierPhone);
                view_suppliers(gridView);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Kategorileri veritabanından çek ve ComboBox'a ekle
        public void _load_categories_into_combo_box(ComboBox combo_box)
        {
            string query = "SELECT category_id, category_name FROM categories";
            DataTable data_table = execute_query(query); // Veritabanı sorgusunu çalıştır

            combo_box.Items.Clear(); // ComboBox'u temizle

            combo_box.ValueMember = "category_id";
            combo_box.DisplayMember = "category_name";
            combo_box.DataSource = data_table;

           
        }











    }
}
