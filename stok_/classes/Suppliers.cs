using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_.classes
{
    class Suppliers
    {
        public int supplier_id { get; set; }
        public string supplier_name { get; set; }
        public string phone { get; set; }
        public bool is_valid(out string error_message)
        {
            if (string.IsNullOrEmpty(supplier_name))
            {
                error_message = "Tedarikçi adı boş bırakılamaz.";
                return false;

            }


            error_message = string.Empty; // Hata yok
            return true;

        }

    }
}
