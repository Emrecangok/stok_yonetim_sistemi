using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_.classes
{
    class Stock_transaction
    {
        public int product_id { get; set; }
        public int quantity { get; set; }
        public string transaction_type { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
}
