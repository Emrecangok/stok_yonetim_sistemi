using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok_
{
    public class usr_contorl_class
    {

        public Panel filled_panel;
        public void add_user_control(UserControl usr, Panel pnl)
        {   //filled_panel = pnl;
            usr.Dock = DockStyle.Fill;
            pnl.Controls.Clear();
            pnl.Controls.Add(usr);
            usr.BringToFront();
            
        }
      
        public void equalize(Panel panel)
        {
            filled_panel = panel;

        }
        
    }
}
