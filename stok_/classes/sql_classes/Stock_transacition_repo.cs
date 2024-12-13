using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using stok_.classes;
using stok_.classes.sql_classes;

namespace stok_.classes.sql_classes
{
    class stock_transaction_repo : Db_helper
    {
        public stock_transaction_repo(string connection_string) : base(connection_string) { }

        // Depoya ürün ekleme
        public void add_stock(int product_id, int warehouse_id, int quantity, int user_id)
        {
            string query = @"
                INSERT INTO stock_transactions (user_id, warehouse_id, product_id, quantity, transaction_type, transaction_date)
                VALUES (@user_id, @warehouse_id, @product_id, @quantity, 'add', @transaction_date);

                INSERT INTO warehouse_stock (warehouse_id, product_id, stock_quantity)
                VALUES (@warehouse_id, @product_id, @quantity)
                ON CONFLICT (warehouse_id, product_id)
                DO UPDATE SET stock_quantity = warehouse_stock.stock_quantity + @quantity;";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@user_id", user_id),
                new NpgsqlParameter("@warehouse_id", warehouse_id),
                new NpgsqlParameter("@product_id", product_id),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@transaction_date", DateTime.Now)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Ürün başarıyla eklendi.");
        }

        // Depodan ürün çıkarma
        public void remove_stock(int product_id, int warehouse_id, int quantity, int user_id)
        {
            string query = @"
                INSERT INTO stock_transactions (user_id, warehouse_id, product_id, quantity, transaction_type, transaction_date)
                VALUES (@user_id, @warehouse_id, @product_id, @quantity, 'remove', @transaction_date);

                UPDATE warehouse_stock
                SET stock_quantity = stock_quantity - @quantity
                WHERE warehouse_id = @warehouse_id AND product_id = @product_id AND stock_quantity >= @quantity;";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@user_id", user_id),
                new NpgsqlParameter("@warehouse_id", warehouse_id),
                new NpgsqlParameter("@product_id", product_id),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@transaction_date", DateTime.Now)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Ürün başarıyla çıkarıldı.");
        }

        // İki depo arasında ürün transferi
        public void warehouse_transfer(int product_id, int source_warehouse_id, int target_warehouse_id, int quantity, int user_id)
        {
            string query = @"
                INSERT INTO stock_transactions (user_id, warehouse_id, product_id, quantity, transaction_type, transaction_date)
                VALUES (@user_id, @source_warehouse_id, @product_id, @quantity, 'transfer_out', @transaction_date),
                       (@user_id, @target_warehouse_id, @product_id, @quantity, 'transfer_in', @transaction_date);

                UPDATE warehouse_stock
                SET stock_quantity = stock_quantity - @quantity
                WHERE warehouse_id = @source_warehouse_id AND product_id = @product_id AND stock_quantity >= @quantity;

                INSERT INTO warehouse_stock (warehouse_id, product_id, stock_quantity)
                VALUES (@target_warehouse_id, @product_id, @quantity)
                ON CONFLICT (warehouse_id, product_id)
                DO UPDATE SET stock_quantity = warehouse_stock.stock_quantity + @quantity;";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@user_id", user_id),
                new NpgsqlParameter("@source_warehouse_id", source_warehouse_id),
                new NpgsqlParameter("@target_warehouse_id", target_warehouse_id),
                new NpgsqlParameter("@product_id", product_id),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@transaction_date", DateTime.Now)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Ürün başarıyla transfer edildi.");
        }

        // Ürün satma
        public void sell_product(int product_id, int warehouse_id, int quantity, int user_id)
        {
            string query = @"
                INSERT INTO stock_transactions (user_id, warehouse_id, product_id, quantity, transaction_type, transaction_date)
                VALUES (@user_id, @warehouse_id, @product_id, @quantity, 'sell', @transaction_date);

                UPDATE warehouse_stock
                SET stock_quantity = stock_quantity - @quantity
                WHERE warehouse_id = @warehouse_id AND product_id = @product_id AND stock_quantity >= @quantity;";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@user_id", user_id),
                new NpgsqlParameter("@warehouse_id", warehouse_id),
                new NpgsqlParameter("@product_id", product_id),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@transaction_date", DateTime.Now)
            };

            execute_non_query(query, parameters);
            MessageBox.Show("Ürün başarıyla satıldı.");
        }
    }
}
