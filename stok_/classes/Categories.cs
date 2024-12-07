using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_.classes
{
    class Categories
    {
        public int category_id { get; set; }
        public string category_name { get; set; }
        public bool is_valid(out string error_message)
        {
            if (string.IsNullOrEmpty(category_name))
            {
                error_message = "Kategori adı boş bırakılamaz.";
                return false;

            }


            error_message = string.Empty; // Hata yok
            return true;

        }

    }
}
