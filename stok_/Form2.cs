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
        public admin_main_form()
        {
            InitializeComponent();
        }



        private void add_user_control(UserControl usr,Panel pnl)
        {
            usr.Dock = DockStyle.Fill;
            pnl.Controls.Clear();
            pnl.Controls.Add(usr);
            usr.BringToFront();


        }
        private void btn_user_management_Click(object sender, EventArgs e)
        {
            user_management usr = new user_management();

            add_user_control(usr, pnl_screen);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void admin_main_form_Load(object sender, EventArgs e)
        {
           usr_main_menu usr_main = new usr_main_menu();
            add_user_control(usr_main,pnl_screen);


        }

        private void pnl_screen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            usr_main_menu usr_main = new usr_main_menu();
            add_user_control(usr_main, pnl_screen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            products_management usr = new products_management();
            add_user_control(usr, pnl_screen);
        }
    }
}
