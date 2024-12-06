using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace stok_.classes.sql_classes
{
    public class Db_helper
    {
        private readonly string _connection_string;

        public Db_helper(string connection_string)
        {
            _connection_string = connection_string;
        }

        public void close_connection(NpgsqlConnection connection)
        {

            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();

                }

            }
            catch (Exception ex)    
            {
                MessageBox.Show($"Bağlantı kapatma sırasında bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }
        public NpgsqlConnection get_connection()
        {
            try
            {
                var connection = new NpgsqlConnection(_connection_string);
                connection.Open();
                //MessageBox.Show("Bağlantı Başarılı");
                return connection;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bağlantı sırasında bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;

            }


        }
        public DataTable execute_query(string query, params NpgsqlParameter[] parameters)
        {
             var connection = get_connection();
            try
            {
                var command = new NpgsqlCommand(query, connection);

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                var adapter = new NpgsqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            finally
            {
                close_connection(connection);
            }
        }
        public void execute_non_query(string query, params NpgsqlParameter[] parameters)
        {
            // Eğer is_empty true ise işlemi atlıyoruz
          
            // Bağlantıyı manuel olarak açıyoruz
            var connection = get_connection();
            try
            {
                // Komut nesnesini oluşturuyoruz
                var command = new NpgsqlCommand(query, connection);

                // Parametreler varsa komuta ekliyoruz
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                // Komutu çalıştırıyoruz
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata durumunda gerekli işlemleri burada yapabilirsiniz (örn. loglama)
                MessageBox.Show($"Komut kodu çalıştırılırken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
               // MessageBox.Show("İşleminiz Başarıyla Gerçekleşti","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                // Bağlantıyı her durumda kapatıyoruz
                close_connection(connection);
            }
        }


    }
}
