using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_.classes
{
    class Product
    {
        public string name { get; set; } 
        public string description { get; set; } 
        public decimal price { get; set; }
        public int stock_quantity { get; set; }
        public int warehouse_id { get; set; } 
    }
}
