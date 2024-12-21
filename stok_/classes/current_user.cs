using System;

namespace stok_.classes
{
    public static class current_user
    {
        public static int id { get; private set; }
        public static string name { get; private set; }
        public static string surname { get; private set; }
        //public static string email { get; private set; }
        public static string password { get; private set; }
        public static int role_id { get; private set; }

        // Kullanıcı bilgilerini ayarlamak için bir metod
        public static void set_user(User user)
        {
            if (user != null)
            {
                id = user.id;
                name = user.name;
                surname = user.surname;
                //email = user.email;
                password = user.password;
                //role = user.role;
                role_id = user.role_id;
            }
        }

        // Kullanıcı oturumunu sıfırlamak için bir metod
        public static void clear_user()
        {
            id = 0;
            name = null;
            surname = null;
            //email = null;
            password = null;
            role_id = 0;
        }
    }
}
