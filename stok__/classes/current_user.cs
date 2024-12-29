using System;

namespace stok_.classes
{
    public static class current_user
    {
        public static int Id { get; private set; }
        public static string Name { get; private set; }
        public static string Password { get; private set; }
        public static string Role { get; private set; }

        // Kullanıcı bilgilerini ayarlayan metot
        public static void SetUser(int id, string name, string password, string role)
        {
            Id = id;
            Name = name;
            Password = password;
            Role = role;
        }

        // Kullanıcı bilgilerini temizleyen metot
        public static void ClearUser()
        {
            Id = 0;
            Name = null;
            Password = null;
            Role = null;
        }
    }
}
