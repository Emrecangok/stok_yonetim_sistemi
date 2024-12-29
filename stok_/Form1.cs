using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using stok_.classes; // current_user ve User sınıfına erişim için ekle

namespace stok_
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        NpgsqlConnection con = new NpgsqlConnection("server=localHost;port=5432;" +
            "Database=data_son;user Id=postgres; Password=can12345");

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM users WHERE user_name = @username AND password = @pass";
                NpgsqlCommand cm = new NpgsqlCommand(sql, con);

                cm.Parameters.AddWithValue("@username", txtbox_kullanici_adi.Text.Trim());
                cm.Parameters.AddWithValue("@pass", txtbox_sifre.Text.Trim());

                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cm);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Kullanıcı bilgilerini DataTable'dan al
                    DataRow row = dt.Rows[0];

                    User user = new User
                    {
                        id = Convert.ToInt32(row["user_id"]),
                        name = row["user_name"].ToString(),
                        //email = row["email"].ToString(),
                        password = row["password"].ToString(),
                        role_id = Convert.ToInt32(row["role_id"])
                    };

                    // current_user sınıfına atama yap
                    current_user.set_user(user);

                    MessageBox.Show($"Hoş geldiniz, {current_user.name}!");

                    // Sonraki forma geçiş
                    
                    admin_main_form frm = new admin_main_form();
                    frm.Show();
                    this.Hide();

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

        private void pnl_login_page_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
