using System;
using System.Data;
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
                if (connection != null && connection.State == ConnectionState.Open)
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
            var dataTable = new DataTable();
            try
            {
                var command = new NpgsqlCommand(query, connection);

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                var adapter = new NpgsqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sorgu çalıştırılırken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                close_connection(connection);
            }

            return dataTable;
        }

        public void execute_non_query(string query, params NpgsqlParameter[] parameters)
        {
            var connection = get_connection();
            try
            {
                var command = new NpgsqlCommand(query, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Komut kodu çalıştırılırken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                close_connection(connection);
            }
        }

        public object execute_scalar(string query, params NpgsqlParameter[] parameters)
        {
            var connection = get_connection();
            try
            {
                var command = new NpgsqlCommand(query, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sorgu çalıştırılırken bir hata oluştu: \n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            finally
            {
                close_connection(connection);
            }
        }
    }
}
