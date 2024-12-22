using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stok_.classes;
using stok_.classes.sql_classes;

namespace stok_
{
    public partial class add_product_to_warehouse_form : Form
    {

        Warehouse_repo ware_repo = new Warehouse_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");
        Products_repo pro_repo = new Products_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");
        GraphicsRepo grap = new GraphicsRepo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");
        Supplier_repo sup_repo = new Supplier_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");
        StockTransactionRepo stock_transacition_repo = new StockTransactionRepo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");
        public add_product_to_warehouse_form()
        {
            InitializeComponent();
        }

        private void lbl_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool mouseDown;
        private Point lastLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void add_product_to_warehouse_form_Load(object sender, EventArgs e)
        {
            ware_repo._load_warehouses_into_combo_box(cmb_box_warehouse_name);
            pro_repo._load_products_into_combo_box(cmb_box_product_name);
            sup_repo._load_suppliers_into_combo_box(cmb_box_supplier);


        }

        private void cmb_box_warehouse_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable ware_house_distribution = grap.get_warehouse_distribution(Convert.ToInt32(cmb_box_warehouse_name.SelectedValue));
            grap.draw_warehouse_pie_chart(pie_graph,ware_house_distribution);


        }

        private void cmb_box_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable product_history = grap.get_product_history(Convert.ToInt32(cmb_box_product_name.SelectedValue));
            grap.draw_product_line_chart(line_graph, product_history);
            int ware_house_id = Convert.ToInt32(cmb_box_warehouse_name.SelectedValue);
            int product_id = Convert.ToInt32(cmb_box_product_name.SelectedValue);

           lbl_stock_value.Text= ware_repo.GetProductQuantity(ware_house_id,product_id).ToString();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int ware_house_id = Convert.ToInt32(cmb_box_warehouse_name.SelectedValue);
                int product_id = Convert.ToInt32(cmb_box_product_name.SelectedValue);
                int supplier_id = Convert.ToInt32(cmb_box_supplier.SelectedValue);
                int quantity = 0;
                if (!int.TryParse(txt_box_product_quantity.Text,out quantity) || quantity <=0)
                {
                    MessageBox.Show("Lütfen geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                stock_transacition_repo.AddStock(product_id,ware_house_id,quantity,13,supplier_id,DateTime.Now);
                lbl_stock_value.Text = ware_repo.GetProductQuantity(ware_house_id, product_id).ToString();
                MessageBox.Show("Stok başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                throw;
            }

            


        }

        private void cmb_box_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
