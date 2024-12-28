using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stok_.classes.sql_classes;

namespace stok_
{
    public partial class usr_stock_logs : UserControl
    {

        StockTransactionRepo stock_transacition_repo = new StockTransactionRepo("server=localHost;port=5432;" +
          "Database=data_son;user Id=postgres; Password=12345");
        public usr_stock_logs()
        {
            InitializeComponent();
        }

        private void usr_stock_logs_Load(object sender, EventArgs e)
        {
            try
            {
                // Logları DataGridView'e yükle
                stock_transacition_repo.LoadStockTransactions(data_grid_logs);

                // Veriyi bağladıktan sonra başlıkları özelleştirin
                if (data_grid_logs.Columns["transaction_type"] != null)
                    data_grid_logs.Columns["transaction_type"].HeaderText = "İşlem Türü";
                else
                    Console.WriteLine("Sütun bulunamadı: transaction_type");

                if (data_grid_logs.Columns["user_name"] != null)
                    data_grid_logs.Columns["user_name"].HeaderText = "Kullanıcı";
                else
                    Console.WriteLine("Sütun bulunamadı: user_name");

                // Diğer sütun başlıklarını ayarla (örnek)
                if (data_grid_logs.Columns["quantity"] != null)
                    data_grid_logs.Columns["quantity"].HeaderText = "Miktar";
                else
                    Console.WriteLine("Sütun bulunamadı: quantity");

                if (data_grid_logs.Columns["transaction_date"] != null)
                    data_grid_logs.Columns["transaction_date"].HeaderText = "Tarih";
                else
                    Console.WriteLine("Sütun bulunamadı: transaction_date");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}\n{ex.StackTrace}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
