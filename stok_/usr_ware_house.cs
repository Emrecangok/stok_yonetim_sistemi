using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using stok_.classes;
using stok_.classes.sql_classes;

namespace stok_
{
    public partial class usr_ware_house : UserControl
    {
        Warehouse_repo ware_repo = new Warehouse_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim_data;user Id=postgres; Password=12345");
        public usr_ware_house()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void btn_add_Click(object sender, EventArgs e)
        {
            string error_message;
            Ware_house ware = new Ware_house();
            
            
            ware.name = txtbox_warehouse_name.Text;
            ware.location = txt_box_warehose_adress.Text;

            if (!ware.is_valid(out error_message))
            {
                MessageBox.Show(error_message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                ware_repo.add_warehouse(ware);
                ware_repo.view_warehouses(data_grid_ware_house);


            }
           
            
         
           
        }

        private void usr_ware_house_Load(object sender, EventArgs e)
        {
            
            ware_repo.view_warehouses(data_grid_ware_house);



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ware_repo.update_selected_warehouse(data_grid_ware_house, txtbox_warehouse_name.Text, txt_box_warehose_adress.Text);

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            ware_repo.delete_selected_warehouse(data_grid_ware_house);

        }

        private void data_grid_ware_house_SelectionChanged(object sender, EventArgs e)
        {
            if (data_grid_ware_house.SelectedRows.Count > 0)
            {
                // Seçilen satırı al
                DataGridViewRow selected_row = data_grid_ware_house.SelectedRows[0];

                // Seçilen satırdaki verileri TextBox'lara aktar
                txtbox_warehouse_name.Text = selected_row.Cells["ware_house_name"].Value.ToString();
                txt_box_warehose_adress.Text = selected_row.Cells["address"].Value.ToString();
            }
        }
    }
}
