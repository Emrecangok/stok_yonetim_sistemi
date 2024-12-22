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
    public partial class remove_product_form : Form
    {
        public remove_product_form()
        {
            InitializeComponent();
        }

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

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int ware_house_id = Convert.ToInt32(cmb_box_warehouse_name.SelectedValue);
                int product_id = Convert.ToInt32(cmb_box_product_name.SelectedValue);
                int quantity = 0;
                if (!int.TryParse(txt_box_product_quantity.Text, out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                stock_transacition_repo.RemoveStock(product_id, ware_house_id, quantity, 13, DateTime.Now);
                lbl_stock_value.Text = ware_repo.GetProductQuantity(ware_house_id, product_id).ToString();
                MessageBox.Show("Stok başarıyla Çıkarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                throw;
            }




        }

        private void label4_Click(object sender, EventArgs e)
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

        private void cmb_box_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ware_house_id = Convert.ToInt32(cmb_box_warehouse_name.SelectedValue);
            int product_id = Convert.ToInt32(cmb_box_product_name.SelectedValue);

            lbl_stock_value.Text = ware_repo.GetProductQuantity(ware_house_id, product_id).ToString();
        }

        private void remove_product_form_Load(object sender, EventArgs e)
        {
            ware_repo._load_warehouses_into_combo_box(cmb_box_warehouse_name);
            pro_repo._load_products_into_combo_box(cmb_box_product_name);
        }

        private void cmb_box_warehouse_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_stock_value.Text = "X";
        }
    }
}
