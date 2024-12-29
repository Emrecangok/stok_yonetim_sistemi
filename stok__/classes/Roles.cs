using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_.classes
{
    class Roles
    {
        public int role_id { get; set; }
        public string role_name { get; set; }
        public bool is_valid(out string error_message)
        {
            if (string.IsNullOrEmpty(role_name))
            {
                error_message = "Rol adı boş bırakılamaz.";
                return false;

            }


            error_message = string.Empty; // Hata yok
            return true;

        }

    }
}
