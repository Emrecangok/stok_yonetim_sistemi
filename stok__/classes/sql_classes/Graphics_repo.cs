using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using Npgsql;

namespace stok_.classes.sql_classes
{
    public class GraphicsRepo : Db_helper
    {
        public GraphicsRepo(string connection_string) : base(connection_string) { }

        // Product History (Çizgi Grafik) Verilerini Getir
        public DataTable get_product_history(int product_id)
        {
            string query = @"
                SELECT 
                    transaction_date AS transaction_date, 
                    CAST(quantity AS INTEGER) AS miktar
                FROM stock_transactions
                WHERE product_id = @product_id
                ORDER BY transaction_date ASC";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@product_id", product_id)
            };

            try
            {
                return execute_query(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün geçmişi alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Warehouse Distribution (Pasta Grafik) Verilerini Getir
        public DataTable get_warehouse_distribution(int warehouse_id)
        {
            string query = @"
                SELECT 
                    p.product_name AS urun, 
                    s.stock_quantity AS miktar
                FROM product_warehouse s
                JOIN products p ON s.product_id = p.product_id
                WHERE s.warehouse_id = @warehouse_id";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@warehouse_id", warehouse_id)
            };

            try
            {
                return execute_query(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Depo dağılımı alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Çizgi Grafik Oluştur
        public void draw_product_line_chart(Chart chart, DataTable data)
        {
            try
            {
                chart.Series.Clear();
                chart.ChartAreas.Clear();

                if (data == null || data.Rows.Count == 0)
                {
                    MessageBox.Show("Grafik oluşturmak için yeterli veri bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var chartArea = new ChartArea("MainArea");
                chart.ChartAreas.Add(chartArea);

                var series = new Series("Ürün Miktarı")
                {
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.DateTime
                };

                foreach (DataRow row in data.Rows)
                {
                    if (DateTime.TryParse(row["transaction_date"].ToString(), out DateTime date) &&
                        int.TryParse(row["miktar"].ToString(), out int quantity))
                    {
                        series.Points.AddXY(date, quantity);
                    }
                }

                chart.Series.Add(series);

                chartArea.AxisX.LabelStyle.Format = "dd.MM.yyyy";
                chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                chartArea.RecalculateAxesScale();

                chart.Titles.Clear();
                chart.Titles.Add("Ürün Miktar Değişimi");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Çizgi grafik oluşturulurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Pasta Grafik Oluştur
        // Pasta Grafik Oluştur
        public void draw_warehouse_pie_chart(Chart chart, DataTable data)
        {
            try
            {
                chart.Series.Clear();
                chart.ChartAreas.Clear();

                if (data == null || data.Rows.Count == 0)
                {
                    MessageBox.Show("Grafik oluşturmak için yeterli veri bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var chartArea = new ChartArea("MainArea");
                chart.ChartAreas.Add(chartArea);

                var series = new Series("Ürün Dağılımı")
                {
                    ChartType = SeriesChartType.Pie
                };

                foreach (DataRow row in data.Rows)
                {
                    string productName = row["urun"].ToString();
                    if (int.TryParse(row["miktar"].ToString(), out int quantity))
                    {
                        series.Points.AddXY(productName, quantity);
                    }
                }

                chart.Series.Add(series);

                // Legend kontrolü
                Legend legend = chart.Legends.FindByName("Legend1");
                if (legend == null) // Eğer Legend yoksa yeni bir tane ekle
                {
                    legend = new Legend("Legend1")
                    {
                        Docking = Docking.Right,
                        Alignment = StringAlignment.Center
                    };
                    chart.Legends.Add(legend);
                }

                chart.Titles.Clear();
                chart.Titles.Add("Depo Ürün Dağılımı");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pasta grafik oluşturulurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
