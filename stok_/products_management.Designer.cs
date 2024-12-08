
namespace stok_
{
    partial class usr_products_maganement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_grid_products = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbox_min_stock = new System.Windows.Forms.TextBox();
            this.cmbox_category_id = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_unit_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_product_name = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateogry_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_products)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_grid_products
            // 
            this.data_grid_products.AllowUserToAddRows = false;
            this.data_grid_products.AllowUserToDeleteRows = false;
            this.data_grid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.cateogry_id,
            this.unit_price});
            this.data_grid_products.Location = new System.Drawing.Point(153, 33);
            this.data_grid_products.Name = "data_grid_products";
            this.data_grid_products.ReadOnly = true;
            this.data_grid_products.Size = new System.Drawing.Size(525, 181);
            this.data_grid_products.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.data_grid_products);
            this.panel1.Location = new System.Drawing.Point(107, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 235);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Verileri";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtbox_min_stock);
            this.panel2.Controls.Add(this.cmbox_category_id);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtbox_unit_price);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtbox_product_name);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Location = new System.Drawing.Point(27, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 189);
            this.panel2.TabIndex = 5;
            // 
            // txtbox_min_stock
            // 
            this.txtbox_min_stock.Location = new System.Drawing.Point(574, 77);
            this.txtbox_min_stock.Name = "txtbox_min_stock";
            this.txtbox_min_stock.Size = new System.Drawing.Size(148, 20);
            this.txtbox_min_stock.TabIndex = 19;
            // 
            // cmbox_category_id
            // 
            this.cmbox_category_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbox_category_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbox_category_id.FormattingEnabled = true;
            this.cmbox_category_id.Location = new System.Drawing.Point(273, 69);
            this.cmbox_category_id.Name = "cmbox_category_id";
            this.cmbox_category_id.Size = new System.Drawing.Size(148, 21);
            this.cmbox_category_id.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(442, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Minimum Stok Leveli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(497, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Birim Fiyatı";
            // 
            // txtbox_unit_price
            // 
            this.txtbox_unit_price.Location = new System.Drawing.Point(574, 31);
            this.txtbox_unit_price.Name = "txtbox_unit_price";
            this.txtbox_unit_price.Size = new System.Drawing.Size(148, 20);
            this.txtbox_unit_price.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(204, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(204, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün Adı";
            // 
            // txtbox_product_name
            // 
            this.txtbox_product_name.Location = new System.Drawing.Point(273, 31);
            this.txtbox_product_name.Name = "txtbox_product_name";
            this.txtbox_product_name.Size = new System.Drawing.Size(148, 20);
            this.txtbox_product_name.TabIndex = 10;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(589, 150);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(128, 36);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Temizle";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(440, 150);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(128, 36);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Sil";
            this.btn_del.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(272, 150);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(128, 36);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(117, 150);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(131, 36);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Ekle";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // product_id
            // 
            this.product_id.HeaderText = "İD";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 120;
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Name";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 120;
            // 
            // cateogry_id
            // 
            this.cateogry_id.HeaderText = "Kategori";
            this.cateogry_id.Name = "cateogry_id";
            this.cateogry_id.ReadOnly = true;
            this.cateogry_id.Width = 120;
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Birim Fiyat";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            this.unit_price.Width = 120;
            // 
            // usr_products_maganement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "usr_products_maganement";
            this.Size = new System.Drawing.Size(1002, 496);
            this.Load += new System.EventHandler(this.products_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_products;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_unit_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_product_name;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtbox_min_stock;
        private System.Windows.Forms.ComboBox cmbox_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateogry_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
    }
}
