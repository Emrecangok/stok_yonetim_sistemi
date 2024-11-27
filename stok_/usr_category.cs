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
    public partial class usr_category : UserControl
    {
        public usr_category()
        {
            InitializeComponent();
        }


        usr_contorl_class usrmg = new usr_contorl_class();

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usr_products_maganement usr = new usr_products_maganement();
            usrmg.add_user_control(usr);
            //usrmg.add_user_control(usr,);
           

        }
    }
}
