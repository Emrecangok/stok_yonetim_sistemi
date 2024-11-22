using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace stok_
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        NpgsqlConnection con = new NpgsqlConnection("server=localHost;port=5432;" +
            "Database=stok_yonetim;user Id=postgres; Password=can12345");
        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //MessageBox.Show("Bağlantı başarılı bir şekilde açıldı!");

                string sql = "SELECT * FROM users WHERE user_name = @username AND password = @pass";
                NpgsqlCommand cm = new NpgsqlCommand(sql, con);

                cm.Parameters.AddWithValue("@username",txtbox_kullanici_adi.Text.Trim());
                cm.Parameters.AddWithValue("@pass", txtbox_sifre.Text.Trim());

                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cm);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Doğru şifre girdiniz!");
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
    }
}
