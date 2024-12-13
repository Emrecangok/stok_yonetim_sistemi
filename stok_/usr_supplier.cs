using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stok_.classes.sql_classes;
using stok_.classes;

namespace stok_
{
    public partial class usr_supplier : UserControl
    {
        Supplier_repo sup_repo = new Supplier_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim_data;user Id=postgres; Password=12345");
        public usr_supplier()
        {
            InitializeComponent();
        }


        usr_contorl_class usrmg = new usr_contorl_class();

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usr_products_maganement usr = new usr_products_maganement();
            //usrmg.add_user_control(usr);
            //usrmg.add_user_control(usr);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string error_message;
            Suppliers sup = new Suppliers();


            sup.supplier_name = txtbox_supplier_name.Text;
            sup.phone = txtbox_phone.Text;


            if (!sup.is_valid(out error_message))
            {
                MessageBox.Show(error_message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                sup_repo.add_supplier(sup);
                sup_repo.view_suppliers(data_grid_supplier);
            }

        }

        private void usr_supplier_Load(object sender, EventArgs e)
        {
            sup_repo.view_suppliers(data_grid_supplier);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            sup_repo.update_selected_supplier(data_grid_supplier, txtbox_supplier_name.Text, txtbox_phone.Text);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            sup_repo.delete_supplier(txtbox_supplier_name.Text, txtbox_phone.Text);
            sup_repo.delete_selected_supplier(data_grid_supplier);
        }

        private void data_grid_supplier_SelectionChanged(object sender, EventArgs e)
        {
            if (data_grid_supplier.SelectedRows.Count > 0)
            {
                // Seçilen satırı al
                DataGridViewRow selected_row = data_grid_supplier.SelectedRows[0];

                // Seçilen satırdaki verileri TextBox'lara aktar
                txtbox_supplier_name.Text = selected_row.Cells["supplier_name"].Value.ToString();

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbox_supplier_name.Text = string.Empty;
            txtbox_phone.Text = string.Empty;
        }
    }
}

