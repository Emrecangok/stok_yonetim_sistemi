using stok_.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok_
{
    public partial class admin_main_form : Form
    {
        public usr_contorl_class usrmg = new usr_contorl_class(); //user controlleri içeren sınıf
        public admin_main_form()
        {
            InitializeComponent();
        }

        private void btn_user_management_Click(object sender, EventArgs e)
        {
            usr_user_management usr = new usr_user_management();

            usrmg.add_user_control(usr, pnl_screen);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void admin_main_form_Load(object sender, EventArgs e)
        {
           usr_main_menu usr_main = new usr_main_menu();
            usrmg.add_user_control(usr_main,pnl_screen);


        }

        private void pnl_screen_Paint(object sender, PaintEventArgs e)
        {

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            usrmg.filled_panel = pnl_screen;
            usr_products_maganement usr = new usr_products_maganement();
            usrmg.add_user_control(usr, pnl_screen);

        }

        private void btn_main_menu_Click(object sender, EventArgs e)
        {
            usr_main_menu usr_main = new usr_main_menu();
            usrmg.add_user_control(usr_main, pnl_screen);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void product_mg_tsm_Click(object sender, EventArgs e)
        {

        }

        private void manin_menu_tsm_Click(object sender, EventArgs e)
        {
            usr_main_menu usr_main = new usr_main_menu();
            usrmg.add_user_control(usr_main, pnl_screen);

        }

        private void products_tsm_down_Click(object sender, EventArgs e)
        {
            //usr_products_maganement usr = new usr_products_maganement();
           // usrmg.add_user_control(usr, pnl_screen); Burası alt bir menüye eklenecek(urun ekle)

        }

        private void category_tsm_down_Click(object sender, EventArgs e)
        {
            usr_category usr = new usr_category();
            usrmg.add_user_control(usr, pnl_screen);

        }

        private void user_actions_tsm_down_Click(object sender, EventArgs e)
        {
            usr_user_management usr = new usr_user_management();
            usrmg.add_user_control(usr,pnl_screen);
            
        }

        private void stock_report_tsm_down_Click(object sender, EventArgs e)
        {
            //usr_reports usr = new usr_reports();
            usr_stock_logs usr = new usr_stock_logs();
            usrmg.add_user_control(usr, pnl_screen);
        }

        private void warehouse_mg_tsm_Click(object sender, EventArgs e)
        {

        }

        private void ware_house_tsm_down_Click(object sender, EventArgs e)
        {
            usr_ware_house usr = new usr_ware_house();
            usrmg.add_user_control(usr, pnl_screen);

        }

        private void repot_mg_tsm_Click(object sender, EventArgs e)
        {

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

        private void user_mg_tsm_Click(object sender, EventArgs e)
        {

        }

        private void tedarikçilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tedarikçiCRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usr_supplier usr_supplier = new usr_supplier();
            usrmg.add_user_control(usr_supplier, pnl_screen);

        }

        private void supplier_mg_tsm_Click(object sender, EventArgs e)
        {

        }

        private void usr_remove_product_Click(object sender, EventArgs e)
        {
            remove_product_form frm = new remove_product_form();
            frm.Show();
            
        }

        private void roles_tsm_down_Click(object sender, EventArgs e)
        {
            usr_role usr = new usr_role();
            usrmg.add_user_control(usr, pnl_screen);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stock_mg_tsm_Click(object sender, EventArgs e)
        {

        }

        private void stock_tsm_down_Click(object sender, EventArgs e)
        {

        }
    }
}
