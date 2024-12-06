using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok_.classes
{
    class Ware_house
    {
        public string name { get; set; }
        public string location { get; set; } 

       
        public bool is_valid(out string error_message)
        {
            if (string.IsNullOrWhiteSpace(name)) // Boş ya da sadece boşluk içeriyorsa
            {
                error_message = "Depo adı boş bırakılamaz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(location)) // Boş ya da sadece boşluk içeriyorsa
            {
                error_message = "Depo adresi boş bırakılamaz.";
                return false;
            }

            error_message = string.Empty;
            return true;
        }
    }
}


