﻿using System;
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

        Stock_transaction_repo stock_transacition_repo = new Stock_transaction_repo("server=localHost;port=5432;" +
          "Database=stok_yonetim;user Id=postgres; Password=can12345");
        User_repo usr_repo = new User_repo("server=localHost;port=5432;" +
          "Database=stok_yonetim;user Id=postgres; Password=can12345");
        public usr_stock_logs()
        {
            InitializeComponent();
        }

        private void usr_stock_logs_Load(object sender, EventArgs e)
        {

            usr_repo.LoadStockTransactionLogsForAutoComplete(txt_box_name);


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

        private void btn_find_Click(object sender, EventArgs e)
        {
            DateTime startDate = date_tmp_start.Value.Date;
            DateTime endDate = date_tmp_end.Value.Date.AddDays(1).AddTicks(-1);

            stock_transacition_repo.LoadStockTransactionLogsByNameAndDateRange(data_grid_logs, txt_box_name.Text, startDate, endDate);
        }

        private void btn_show_all_logs_Click(object sender, EventArgs e)
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
