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
            user_management usr = new user_management();

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
            products_management usr = new products_management();
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
    }
}
