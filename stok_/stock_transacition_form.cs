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
    public partial class stock_transacition_form : Form
    {
        public stock_transacition_form()
        {
            InitializeComponent();
        }

        Warehouse_repo ware_repo = new Warehouse_repo("server=localHost;port=5432;" +
           "Database=data_son;user Id=postgres; Password=can12345");
        Products_repo pro_repo = new Products_repo("server=localHost;port=5432;" +
           "Database=data_son;user Id=postgres; Password=can12345");
        GraphicsRepo grap = new GraphicsRepo("server=localHost;port=5432;" +
           "Database=data_son;user Id=postgres; Password=can12345");
        Supplier_repo sup_repo = new Supplier_repo("server=localHost;port=5432;" +
           "Database=data_son;user Id=postgres; Password=can12345");
        StockTransactionRepo stock_transacition_repo = new StockTransactionRepo("server=localHost;port=5432;" +
           "Database=data_son;user Id=postgres; Password=can12345");
        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool mouseDown;
        private Point lastLocation;
        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void pnl_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void stock_transacition_form_Load(object sender, EventArgs e)
        {
            ware_repo._load_warehouses_into_combo_box(cmb_box_warehouse_name);
            ware_repo._load_warehouses_into_combo_box(cmb_box_ware_housenameB);
            pro_repo._load_products_into_combo_box(cmb_box_product_name);

        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            try
            {
                int ware_house_id = Convert.ToInt32(cmb_box_warehouse_name.SelectedValue);
                int product_id = Convert.ToInt32(cmb_box_product_name.SelectedValue);
                int ware_house_id_B = Convert.ToInt32(cmb_box_ware_housenameB.SelectedValue);
                int quantity = 0;
                if (!int.TryParse(txtbox_quantity.Text, out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                stock_transacition_repo.WarehouseTransfer(product_id,ware_house_id,ware_house_id_B,quantity,13);
                

                lbl_stock_value_a.Text = ware_repo.GetProductQuantity(ware_house_id, product_id).ToString();
                lbl_stock_value_b.Text = ware_repo.GetProductQuantity(ware_house_id_B, product_id).ToString();
                MessageBox.Show("Stok başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmb_box_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int ware_house_id = Convert.ToInt32(cmb_box_warehouse_name.SelectedValue);
            int product_id = Convert.ToInt32(cmb_box_product_name.SelectedValue);
            int ware_house_id_B = Convert.ToInt32(cmb_box_ware_housenameB.SelectedValue);

            lbl_stock_value_a.Text = ware_repo.GetProductQuantity(ware_house_id, product_id).ToString();
            lbl_stock_value_b.Text = ware_repo.GetProductQuantity(ware_house_id_B, product_id).ToString();

        }

        private void cmb_box_ware_housenameB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32(cmb_box_product_name.SelectedValue);
            int ware_house_id_B = Convert.ToInt32(cmb_box_ware_housenameB.SelectedValue);

            lbl_stock_value_b.Text = ware_repo.GetProductQuantity(ware_house_id_B, product_id).ToString();

        }
    }
}
