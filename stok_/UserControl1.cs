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
namespace stok_
{
    public partial class usr_main_menu : UserControl
    {
        main_repo repo = new main_repo("server=localHost;port=5432;" +
           "Database=data_son;user Id=postgres; Password=can12345");
        public usr_main_menu()
        {
            InitializeComponent();
        }

        private void usr_main_menu_Load(object sender, EventArgs e)
        {

            lbl_low_stock.Text = repo.GetLowStockProducts().ToString();
            lbl_users.Text = repo.GetTotalUsers().ToString();
            lbl_tedarik.Text = repo.GetTotalSuppliers().ToString();
            lbl_stock.Text = repo.GetTodayTotalAdditions().ToString();
            lbl_removed.Text = repo.GetTodayTotalRemovals().ToString();
            lbl_new_users.Text = repo.GetTodayTotalTransfers().ToString();
           
           

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            low_stock_form frm = new low_stock_form();
            frm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
