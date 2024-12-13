using System;

namespace stok_.classes
{
    class Product
    {
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int stock_quantity { get; set; }
        public int product_id { get; set; }
        public int category_id { get; set; }
        public int product_min_stock_level { get; set; }

        public bool is_valid(out string error_message)
        {
            if (string.IsNullOrWhiteSpace(name)) // Ürün adı boş ya da sadece boşluk içeriyorsa
            {
                error_message = "Ürün adı boş bırakılamaz.";
                return false;
            }

            if (price <= 0) // Ürün fiyatı sıfır ya da negatif olamaz
            {
                error_message = "Ürün fiyatı sıfırdan büyük olmalıdır.";
                return false;
            }

            if (stock_quantity < 0) // Stok miktarı negatif olamaz
            {
                error_message = "Stok miktarı negatif olamaz.";
                return false;
            }
            
          

            if (category_id <= 0) // Kategori ID sıfır ya da negatif olamaz
            {
                error_message = "Geçerli bir kategori ID'si giriniz.";
                return false;
            }

            if (product_min_stock_level < 0) // Minimum stok seviyesi negatif olamaz
            {
                error_message = "Minimum stok seviyesi negatif olamaz.";
                return false;
            }

            error_message = string.Empty; // Hata yok
            return true;
        }
    }
}
