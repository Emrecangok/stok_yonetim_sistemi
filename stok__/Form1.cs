using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using stok_.classes;

namespace stok_
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantı dizesi
        NpgsqlConnection con = new NpgsqlConnection("server=localHost;port=5432;" +
            "Database=stok_yonetim;user Id=postgres; Password=can12345");

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

                    // Kullanıcı bilgilerini current_user'a aktar
                    current_user.SetUser(
                        id: Convert.ToInt32(row["user_id"]),
                        name: row["user_name"].ToString(),
                        password: row["password"].ToString(),
                        role: row["role_id"].ToString()
                    );

                    MessageBox.Show($"Hoş geldiniz, {current_user.Name}!");

                    // role_id kontrolü
                    if (current_user.Role == "13")
                    {
                        // Admin form aç
                        admin_main_form adminForm = new admin_main_form();
                        adminForm.Show();
                    }
                    else
                    {
                        manager_form mrg = new manager_form();
                        mrg.Show();
                    }

                    // Geçerli formu gizle
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
            // Gerekli bir işlem yok
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            txtbox_sifre.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_parola_yenile_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_kullanici_adi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_oturum_Click(object sender, EventArgs e)
        {

        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
