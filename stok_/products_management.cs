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
    public partial class usr_products_maganement : UserControl
    {


        Products_repo pro_repo = new Products_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");
        Categories_repo cat_repo = new Categories_repo("server=localHost;port=5432;" +
           "Database=stok_yonetim;user Id=postgres; Password=can12345");
        public usr_products_maganement()
        {
            InitializeComponent();
        }

        

    
        private void products_management_Load(object sender, EventArgs e)
        {
            pro_repo.view_products(data_grid_products);
            cat_repo._load_categories_into_combo_box(cmbox_category_id);
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string error_message;
            Product pro = new Product();


            pro.name =txtbox_product_name.Text;
            pro.price = double.Parse(txtbox_unit_price.Text);
            pro.product_min_stock_level = int.Parse(txtbox_min_stock.Text);
            //.stock_quantity =int.Parse(txt_box_current_stock.Text); Current stock producstan Silindi
            // pro.warehouse_id = int.Parse(cmbox_ware_house.Text); Depoya ürün ekleme başka bir menüye aktarıldı
            pro.category_id = Convert.ToInt32(cmbox_category_id.SelectedValue);

            if (!pro.is_valid(out error_message))
            {
                MessageBox.Show(error_message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                pro_repo.add_product(pro);
                pro_repo.view_products(data_grid_products);


            }
        }
    }
}
