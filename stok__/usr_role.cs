using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stok_.classes;
using stok_.classes.sql_classes;

namespace stok_
{
    public partial class usr_role : UserControl
    {
        Roles_repo role_repo = new Roles_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");
        public usr_role()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string error_message;
            Roles role = new Roles();


            role.role_name = txtbox_role_name.Text;


            if (!role.is_valid(out error_message))
            {
                MessageBox.Show(error_message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                role_repo.add_role(role);
                role_repo.view_roles(data_grid_role);


            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            role_repo.update_selected_role(data_grid_role, txtbox_role_name.Text);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            role_repo.delete_selected_role(data_grid_role);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void usr_role_Load(object sender, EventArgs e)
        {
            role_repo.view_roles(data_grid_role);
        }

        private void data_grid_role_SelectionChanged(object sender, EventArgs e)
        {
            if (data_grid_role.SelectedRows.Count > 0)
            {
                // Seçilen satırı al
                DataGridViewRow selected_row = data_grid_role.SelectedRows[0];

                // Seçilen satırdaki verileri TextBox'lara aktar
                txtbox_role_name.Text = selected_row.Cells["role_name"].Value.ToString();

            }
        }
    }
}
