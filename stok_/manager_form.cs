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
    public partial class manager_form : Form
    {
        public usr_contorl_class usrmg = new usr_contorl_class(); //user controlleri içeren sınıf
        public manager_form()
        {
            InitializeComponent();
        }

        private void stock_report_tsm_down_Click(object sender, EventArgs e)
        {

        }

        private void manager_form_Load(object sender, EventArgs e)
        {
            usr_main_menu usr_main = new usr_main_menu();
            usrmg.add_user_control(usr_main, pnl_screen);
        }

        private void manin_menu_tsm_Click(object sender, EventArgs e)
        {
            usr_main_menu usr_main = new usr_main_menu();
            usrmg.add_user_control(usr_main, pnl_screen);
        }

        private void products_tsp_add_down_Click(object sender, EventArgs e)
        {
            usr_products_maganement usr = new usr_products_maganement();
            usrmg.add_user_control(usr, pnl_screen);
        }

        private void inter_warehouse_transfer_tsm_Click(object sender, EventArgs e)
        {
            stock_transacition_form frm = new stock_transacition_form();
            frm.Show();

        }

        private void ad_product_tsm_down_Click(object sender, EventArgs e)
        {
            add_product_to_warehouse_form frm = new add_product_to_warehouse_form();
            frm.Show();

        }

        private void usr_remove_product_Click(object sender, EventArgs e)
        {
            remove_product_form frm = new remove_product_form();
            frm.Show();

        }

        private void tedarikçilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tedarikçiCRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usr_supplier usr_supplier = new usr_supplier();
            usrmg.add_user_control(usr_supplier, pnl_screen);

        }

        private void category_tsm_down_Click(object sender, EventArgs e)
        {
            usr_category usr = new usr_category();
            usrmg.add_user_control(usr, pnl_screen);
        }
    }
}
