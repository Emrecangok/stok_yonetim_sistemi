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
    public partial class low_stock_form : Form
    {
        public low_stock_form()
        {
            InitializeComponent();
        }
        main_repo repo = new main_repo("server=localHost;port=5432;" +
            "Database=data_son;user Id=postgres; Password=12345");
        private void low_stock_form_Load(object sender, EventArgs e)
        {
            repo.view_low_stock_products(dataGridView1);

        }

        private void lbl_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
