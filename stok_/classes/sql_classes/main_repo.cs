using System;
using Npgsql;
using System.Data;
using System.Windows.Forms;
namespace stok_.classes.sql_classes
{
    class main_repo : Db_helper
    {
        public main_repo(string connection_string) : base(connection_string) { }

        // Tedarikçilerin toplam sayısını döndürür
        public int GetTotalSuppliers()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM suppliers");
        }

        // Kullanıcıların toplam sayısını döndürür
        public int GetTotalUsers()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM users");
        }

        // Stok seviyesi düşük olan ürünlerin toplam sayısını döndürür
        public int GetLowStockProducts()
        {
            // Sorgu: product_warehouse'daki stok miktarını, products tablosundaki min_stock_level ile karşılaştırır.
            string query = @"
                SELECT COUNT(DISTINCT pw.product_id)
                FROM product_warehouse pw
                INNER JOIN products p ON pw.product_id = p.product_id
                WHERE pw.stock_quantity < p.min_stock_level";
            return ExecuteCountQuery(query);
        }

        // Bugün yapılan toplam transfer sayısını döndürür
        public int GetTodayTotalTransfers()
        {
            string query = "SELECT COUNT(*) FROM stock_transactions WHERE transaction_date::DATE = CURRENT_DATE";
            return ExecuteCountQuery(query);
        }

        // Bugün yapılan toplam eklemeleri döndürür
        public int GetTodayTotalAdditions()
        {
            string query = "SELECT COUNT(*) FROM stock_transactions WHERE transaction_date::DATE = CURRENT_DATE AND transaction_type = 'ADD'";
            return ExecuteCountQuery(query);
        }

        // Bugün yapılan toplam çıkarmaları döndürür
        public int GetTodayTotalRemovals()
        {
            string query = "SELECT COUNT(*) FROM stock_transactions WHERE transaction_date::DATE = CURRENT_DATE AND transaction_type = 'REMOVE'";
            return ExecuteCountQuery(query);
        }

        // Genel bir COUNT(*) sorgusu yürütme metodu
        private int ExecuteCountQuery(string query)
        {
            object result = execute_scalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }
        public void view_low_stock_products(DataGridView gridView)
        {
            gridView.Rows.Clear();

            string query = @"
        SELECT 
            p.product_id, 
            p.product_name, 
            c.category_name, 
            p.unit_price, 
            p.min_stock_level, 
            w.ware_house_name, 
            COALESCE(SUM(pw.stock_quantity), 0) AS current_stock
        FROM products AS p
        LEFT JOIN categories AS c ON p.category_id = c.category_id
        LEFT JOIN product_warehouse AS pw ON p.product_id = pw.product_id
        LEFT JOIN ware_houses AS w ON pw.warehouse_id = w.ware_house_id
        GROUP BY p.product_id, c.category_name, p.unit_price, p.min_stock_level, w.ware_house_name
        HAVING COALESCE(SUM(pw.stock_quantity), 0) < p.min_stock_level";

            try
            {
                gridView.AutoGenerateColumns = false;

                var dataTable = execute_query(query);

                if (gridView.Columns.Count == 0)
                {
                    gridView.Columns.Add("product_id", "Ürün ID");
                    gridView.Columns.Add("product_name", "Ürün Adı");
                    gridView.Columns.Add("category_name", "Kategori Adı");
                    gridView.Columns.Add("unit_price", "Birim Fiyat");
                    gridView.Columns.Add("min_stock_level", "Minimum Stok Seviyesi");
                    gridView.Columns.Add("warehouse_name", "Depo Adı");
                    gridView.Columns.Add("current_stock", "Mevcut Stok");
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    gridView.Rows.Add(
                        row["product_id"],
                        row["product_name"],
                        row["category_name"],
                        row["unit_price"],
                        row["min_stock_level"],
                        row["ware_house_name"],
                        row["current_stock"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Düşük stoklu ürünleri listelerken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
