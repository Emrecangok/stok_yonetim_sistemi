﻿
namespace stok_
{
    partial class manager_form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tedarikçiCRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplier_mg_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.category_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.usr_remove_product = new System.Windows.Forms.ToolStripMenuItem();
            this.ad_product_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.inter_warehouse_transfer_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.stock_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.products_tsp_add_down = new System.Windows.Forms.ToolStripMenuItem();
            this.products_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.stock_mg_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.manin_menu_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_strip_main = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_screen = new System.Windows.Forms.Panel();
            this.menu_strip_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tedarikçiCRUDToolStripMenuItem
            // 
            this.tedarikçiCRUDToolStripMenuItem.Name = "tedarikçiCRUDToolStripMenuItem";
            this.tedarikçiCRUDToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.tedarikçiCRUDToolStripMenuItem.Text = "Tedarikçi CRUD";
            this.tedarikçiCRUDToolStripMenuItem.Click += new System.EventHandler(this.tedarikçiCRUDToolStripMenuItem_Click);
            // 
            // supplier_mg_tsm
            // 
            this.supplier_mg_tsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tedarikçilerToolStripMenuItem});
            this.supplier_mg_tsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.supplier_mg_tsm.ForeColor = System.Drawing.Color.White;
            this.supplier_mg_tsm.Image = global::stok_.Properties.Resources.parcel;
            this.supplier_mg_tsm.Name = "supplier_mg_tsm";
            this.supplier_mg_tsm.Size = new System.Drawing.Size(196, 29);
            this.supplier_mg_tsm.Text = "Tedarikci Yönetimi";
            // 
            // tedarikçilerToolStripMenuItem
            // 
            this.tedarikçilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tedarikçiCRUDToolStripMenuItem});
            this.tedarikçilerToolStripMenuItem.Name = "tedarikçilerToolStripMenuItem";
            this.tedarikçilerToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.tedarikçilerToolStripMenuItem.Text = "Tedarikçiler";
            this.tedarikçilerToolStripMenuItem.Click += new System.EventHandler(this.tedarikçilerToolStripMenuItem_Click);
            // 
            // category_tsm_down
            // 
            this.category_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.category_tsm_down.ForeColor = System.Drawing.Color.White;
            this.category_tsm_down.Name = "category_tsm_down";
            this.category_tsm_down.Size = new System.Drawing.Size(216, 30);
            this.category_tsm_down.Text = "Kategoriler";
            this.category_tsm_down.Click += new System.EventHandler(this.category_tsm_down_Click);
            // 
            // usr_remove_product
            // 
            this.usr_remove_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.usr_remove_product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usr_remove_product.Name = "usr_remove_product";
            this.usr_remove_product.Size = new System.Drawing.Size(260, 30);
            this.usr_remove_product.Text = "Depodan Stok Çıkar";
            this.usr_remove_product.Click += new System.EventHandler(this.usr_remove_product_Click);
            // 
            // ad_product_tsm_down
            // 
            this.ad_product_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ad_product_tsm_down.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ad_product_tsm_down.Name = "ad_product_tsm_down";
            this.ad_product_tsm_down.Size = new System.Drawing.Size(260, 30);
            this.ad_product_tsm_down.Text = "Depoya Stok Ekle";
            this.ad_product_tsm_down.Click += new System.EventHandler(this.ad_product_tsm_down_Click);
            // 
            // inter_warehouse_transfer_tsm
            // 
            this.inter_warehouse_transfer_tsm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.inter_warehouse_transfer_tsm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inter_warehouse_transfer_tsm.Name = "inter_warehouse_transfer_tsm";
            this.inter_warehouse_transfer_tsm.Size = new System.Drawing.Size(260, 30);
            this.inter_warehouse_transfer_tsm.Text = "Depolar Arası Taşıma";
            this.inter_warehouse_transfer_tsm.Click += new System.EventHandler(this.inter_warehouse_transfer_tsm_Click);
            // 
            // stock_tsm_down
            // 
            this.stock_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.stock_tsm_down.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inter_warehouse_transfer_tsm,
            this.ad_product_tsm_down,
            this.usr_remove_product});
            this.stock_tsm_down.ForeColor = System.Drawing.Color.White;
            this.stock_tsm_down.Name = "stock_tsm_down";
            this.stock_tsm_down.Size = new System.Drawing.Size(216, 30);
            this.stock_tsm_down.Text = "Stok Hareketleri";
            // 
            // products_tsp_add_down
            // 
            this.products_tsp_add_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.products_tsp_add_down.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.products_tsp_add_down.Name = "products_tsp_add_down";
            this.products_tsp_add_down.Size = new System.Drawing.Size(180, 30);
            this.products_tsp_add_down.Text = "Ürün CRUD";
            this.products_tsp_add_down.Click += new System.EventHandler(this.products_tsp_add_down_Click);
            // 
            // products_tsm_down
            // 
            this.products_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.products_tsm_down.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.products_tsp_add_down});
            this.products_tsm_down.ForeColor = System.Drawing.Color.White;
            this.products_tsm_down.Name = "products_tsm_down";
            this.products_tsm_down.Size = new System.Drawing.Size(216, 30);
            this.products_tsm_down.Text = "Ürünler";
            // 
            // stock_mg_tsm
            // 
            this.stock_mg_tsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.products_tsm_down,
            this.stock_tsm_down,
            this.category_tsm_down});
            this.stock_mg_tsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stock_mg_tsm.ForeColor = System.Drawing.Color.White;
            this.stock_mg_tsm.Image = global::stok_.Properties.Resources.stock_market;
            this.stock_mg_tsm.Name = "stock_mg_tsm";
            this.stock_mg_tsm.Size = new System.Drawing.Size(157, 29);
            this.stock_mg_tsm.Text = "Stok Yönetimi";
            // 
            // manin_menu_tsm
            // 
            this.manin_menu_tsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manin_menu_tsm.ForeColor = System.Drawing.Color.White;
            this.manin_menu_tsm.Image = global::stok_.Properties.Resources.home;
            this.manin_menu_tsm.Name = "manin_menu_tsm";
            this.manin_menu_tsm.Size = new System.Drawing.Size(131, 29);
            this.manin_menu_tsm.Text = "Ana Menü";
            this.manin_menu_tsm.Click += new System.EventHandler(this.manin_menu_tsm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1182, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // menu_strip_main
            // 
            this.menu_strip_main.BackColor = System.Drawing.Color.Transparent;
            this.menu_strip_main.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_strip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_strip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manin_menu_tsm,
            this.stock_mg_tsm,
            this.supplier_mg_tsm});
            this.menu_strip_main.Location = new System.Drawing.Point(85, 0);
            this.menu_strip_main.Name = "menu_strip_main";
            this.menu_strip_main.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu_strip_main.Size = new System.Drawing.Size(610, 33);
            this.menu_strip_main.TabIndex = 3;
            this.menu_strip_main.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menu_strip_main);
            this.panel1.Location = new System.Drawing.Point(-83, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 41);
            this.panel1.TabIndex = 3;
            // 
            // pnl_screen
            // 
            this.pnl_screen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_screen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_screen.Location = new System.Drawing.Point(0, 36);
            this.pnl_screen.Name = "pnl_screen";
            this.pnl_screen.Size = new System.Drawing.Size(1040, 541);
            this.pnl_screen.TabIndex = 4;
            // 
            // manager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manager_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "manager_form";
            this.Load += new System.EventHandler(this.manager_form_Load);
            this.menu_strip_main.ResumeLayout(false);
            this.menu_strip_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tedarikçiCRUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplier_mg_tsm;
        private System.Windows.Forms.ToolStripMenuItem tedarikçilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem category_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem usr_remove_product;
        private System.Windows.Forms.ToolStripMenuItem ad_product_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem inter_warehouse_transfer_tsm;
        private System.Windows.Forms.ToolStripMenuItem stock_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem products_tsp_add_down;
        private System.Windows.Forms.ToolStripMenuItem products_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem stock_mg_tsm;
        private System.Windows.Forms.ToolStripMenuItem manin_menu_tsm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu_strip_main;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Panel pnl_screen;
    }
}