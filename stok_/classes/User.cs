using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_.classes
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public int role_id { get; set; }

        public bool is_valid(out string error_message)
        {
            if (string.IsNullOrWhiteSpace(name)) // Kullanıcı adı boş ya da sadece boşluk içeriyorsa
            {
                error_message = "Kullanıcı adı boş bırakılamaz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(surname)) // Kullanıcı soyadı boş ya da sadece boşluk içeriyorsa
            {
                error_message = "Kullanıcı soyadı boş bırakılamaz.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password)) // Kullanıcı soyadı boş ya da sadece boşluk içeriyorsa
            {
                error_message = "Parola boş bırakılamaz.";
                return false;
            }

            if (role_id <= 0) // Rol ID sıfır ya da negatif olamaz
            {
                error_message = "Geçerli bir rol ID'si giriniz.";
                return false;
            }


            error_message = string.Empty; // Hata yok
            return true;
        }
    }
}
