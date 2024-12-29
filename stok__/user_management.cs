using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stok_.classes.sql_classes;
using stok_.classes;
using System.Windows.Forms;


namespace stok_
{
    public partial class usr_user_management : UserControl
    {
        

         User_repo user_repo = new User_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");
        Roles_repo role_repo = new Roles_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");

        public usr_user_management()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            user_repo.update_selected_user(dataGridView1, txtbox_user_name.Text, txt_box_surname.Text, Convert.ToInt32(cmbbox_role_id.SelectedValue), txtbox_password.Text);

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string error_message;
            User user = new User();


            user.name = txtbox_user_name.Text;
            user.surname = txt_box_surname.Text;
            user.password = txtbox_password.Text;
            user.role_id = Convert.ToInt32(cmbbox_role_id.SelectedValue);

            if (!user.is_valid(out error_message))
            {
                MessageBox.Show(error_message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                user_repo.add_user(user);
                user_repo.view_users(dataGridView1);
            }
        }

        private void usr_user_management_Load(object sender, EventArgs e)
        {
            user_repo.view_users(dataGridView1);
            role_repo._load_roles_into_combo_box(cmbbox_role_id);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            user_repo.delete_selected_user(dataGridView1);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbox_user_name.Text = string.Empty;
            txt_box_surname.Text = string.Empty;
            txtbox_password.Text = string.Empty;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                // Seçilen satırı al
                DataGridViewRow selected_row =dataGridView1.SelectedRows[0];

                // Seçilen satırdaki verileri TextBox'lara aktar
                txtbox_user_name.Text = selected_row.Cells["user_name"].Value.ToString();
                txt_box_surname.Text = selected_row.Cells["user_surname"].Value.ToString();
                cmbbox_role_id.Text = selected_row.Cells["role_id"].Value.ToString();
            }
        }
    }
}
