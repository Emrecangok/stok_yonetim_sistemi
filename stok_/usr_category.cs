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
    public partial class usr_category : UserControl
    {
        Categories_repo cat_repo = new Categories_repo("server=localHost;port=5432;" +
           "Database=data_son;user Id=postgres; Password=can12345");
        public usr_category()
        {
            InitializeComponent();
        }


        usr_contorl_class usrmg = new usr_contorl_class();

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usr_products_maganement usr = new usr_products_maganement();
            //usrmg.add_user_control(usr);
            //usrmg.add_user_control(usr,);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string error_message;
            Categories cat = new Categories();


            cat.category_name = txtbox_category_name.Text;


            if (!cat.is_valid(out error_message))
            {
                MessageBox.Show(error_message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                cat_repo.add_category(cat);
                cat_repo.view_categories(data_grid_category);


            }

        }

        private void usr_category_Load(object sender, EventArgs e)
        {
            cat_repo.view_categories(data_grid_category);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cat_repo.update_selected_category(data_grid_category, txtbox_category_name.Text);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            cat_repo.delete_selected_category(data_grid_category);
        }

        private void data_grid_category_SelectionChanged(object sender, EventArgs e)
        {
            if (data_grid_category.SelectedRows.Count > 0)
            {
                // Seçilen satırı al
                DataGridViewRow selected_row = data_grid_category.SelectedRows[0];

                // Seçilen satırdaki verileri TextBox'lara aktar
                txtbox_category_name.Text = selected_row.Cells["category_name"].Value.ToString();

            }
        }
    }
}

