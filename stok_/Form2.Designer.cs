
namespace stok_
{
    partial class admin_main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_main_form));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_screen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_strip_main = new System.Windows.Forms.MenuStrip();
            this.manin_menu_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.stock_mg_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.products_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.category_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.stock_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.user_mg_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.user_actions_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.roles_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.repot_mg_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.stock_report_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.sales_report_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouse_mg_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.ware_house_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.p_ware_house_tsm_down = new System.Windows.Forms.ToolStripMenuItem();
            this.supplier_mg_tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menu_strip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_screen
            // 
            this.pnl_screen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_screen.Location = new System.Drawing.Point(0, 36);
            this.pnl_screen.Name = "pnl_screen";
            this.pnl_screen.Size = new System.Drawing.Size(1203, 541);
            this.pnl_screen.TabIndex = 2;
            this.pnl_screen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_screen_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menu_strip_main);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 41);
            this.panel1.TabIndex = 0;
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
            this.menu_strip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manin_menu_tsm,
            this.stock_mg_tsm,
            this.user_mg_tsm,
            this.repot_mg_tsm,
            this.warehouse_mg_tsm,
            this.supplier_mg_tsm});
            this.menu_strip_main.Location = new System.Drawing.Point(0, 0);
            this.menu_strip_main.Name = "menu_strip_main";
            this.menu_strip_main.Size = new System.Drawing.Size(1065, 33);
            this.menu_strip_main.TabIndex = 3;
            this.menu_strip_main.Text = "menuStrip1";
            this.menu_strip_main.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // manin_menu_tsm
            // 
            this.manin_menu_tsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manin_menu_tsm.ForeColor = System.Drawing.Color.White;
            this.manin_menu_tsm.Image = global::stok_.Properties.Resources.home;
            this.manin_menu_tsm.Name = "manin_menu_tsm";
            this.manin_menu_tsm.Size = new System.Drawing.Size(127, 29);
            this.manin_menu_tsm.Text = "Ana Menü";
            this.manin_menu_tsm.Click += new System.EventHandler(this.manin_menu_tsm_Click);
            // 
            // stock_mg_tsm
            // 
            this.stock_mg_tsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.products_tsm_down,
            this.category_tsm_down,
            this.stock_tsm_down});
            this.stock_mg_tsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stock_mg_tsm.ForeColor = System.Drawing.Color.White;
            this.stock_mg_tsm.Image = global::stok_.Properties.Resources.stock_market;
            this.stock_mg_tsm.Name = "stock_mg_tsm";
            this.stock_mg_tsm.Size = new System.Drawing.Size(153, 29);
            this.stock_mg_tsm.Text = "Stok Yönetimi";
            // 
            // products_tsm_down
            // 
            this.products_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.products_tsm_down.ForeColor = System.Drawing.Color.White;
            this.products_tsm_down.Name = "products_tsm_down";
            this.products_tsm_down.Size = new System.Drawing.Size(216, 30);
            this.products_tsm_down.Text = "Ürünler";
            this.products_tsm_down.Click += new System.EventHandler(this.products_tsm_down_Click);
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
            // stock_tsm_down
            // 
            this.stock_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.stock_tsm_down.ForeColor = System.Drawing.Color.White;
            this.stock_tsm_down.Name = "stock_tsm_down";
            this.stock_tsm_down.Size = new System.Drawing.Size(216, 30);
            this.stock_tsm_down.Text = "Stok Hareketleri";
            // 
            // user_mg_tsm
            // 
            this.user_mg_tsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_actions_tsm_down,
            this.roles_tsm_down});
            this.user_mg_tsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user_mg_tsm.ForeColor = System.Drawing.Color.White;
            this.user_mg_tsm.Image = global::stok_.Properties.Resources.team__2_;
            this.user_mg_tsm.Name = "user_mg_tsm";
            this.user_mg_tsm.Size = new System.Drawing.Size(190, 29);
            this.user_mg_tsm.Text = "Kullanıcı Yönetimi";
            // 
            // user_actions_tsm_down
            // 
            this.user_actions_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.user_actions_tsm_down.ForeColor = System.Drawing.Color.White;
            this.user_actions_tsm_down.Name = "user_actions_tsm_down";
            this.user_actions_tsm_down.Size = new System.Drawing.Size(232, 30);
            this.user_actions_tsm_down.Text = "Kullanıcı İşlemleri";
            this.user_actions_tsm_down.Click += new System.EventHandler(this.user_actions_tsm_down_Click);
            // 
            // roles_tsm_down
            // 
            this.roles_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.roles_tsm_down.ForeColor = System.Drawing.Color.White;
            this.roles_tsm_down.Name = "roles_tsm_down";
            this.roles_tsm_down.Size = new System.Drawing.Size(232, 30);
            this.roles_tsm_down.Text = "Roller";
            // 
            // repot_mg_tsm
            // 
            this.repot_mg_tsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stock_report_tsm_down,
            this.sales_report_tsm_down});
            this.repot_mg_tsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.repot_mg_tsm.ForeColor = System.Drawing.Color.White;
            this.repot_mg_tsm.Image = ((System.Drawing.Image)(resources.GetObject("repot_mg_tsm.Image")));
            this.repot_mg_tsm.Name = "repot_mg_tsm";
            this.repot_mg_tsm.Size = new System.Drawing.Size(112, 29);
            this.repot_mg_tsm.Text = "Raporlar";
            // 
            // stock_report_tsm_down
            // 
            this.stock_report_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.stock_report_tsm_down.ForeColor = System.Drawing.Color.White;
            this.stock_report_tsm_down.Name = "stock_report_tsm_down";
            this.stock_report_tsm_down.Size = new System.Drawing.Size(205, 30);
            this.stock_report_tsm_down.Text = "Stok Raporları";
            // 
            // sales_report_tsm_down
            // 
            this.sales_report_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.sales_report_tsm_down.ForeColor = System.Drawing.Color.White;
            this.sales_report_tsm_down.Name = "sales_report_tsm_down";
            this.sales_report_tsm_down.Size = new System.Drawing.Size(205, 30);
            this.sales_report_tsm_down.Text = "Satış Raporları";
            // 
            // warehouse_mg_tsm
            // 
            this.warehouse_mg_tsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ware_house_tsm_down,
            this.p_ware_house_tsm_down});
            this.warehouse_mg_tsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warehouse_mg_tsm.ForeColor = System.Drawing.Color.White;
            this.warehouse_mg_tsm.Image = global::stok_.Properties.Resources.parcel;
            this.warehouse_mg_tsm.Name = "warehouse_mg_tsm";
            this.warehouse_mg_tsm.Size = new System.Drawing.Size(163, 29);
            this.warehouse_mg_tsm.Text = "Depo Yönetimi";
            // 
            // ware_house_tsm_down
            // 
            this.ware_house_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ware_house_tsm_down.ForeColor = System.Drawing.Color.White;
            this.ware_house_tsm_down.Name = "ware_house_tsm_down";
            this.ware_house_tsm_down.Size = new System.Drawing.Size(234, 30);
            this.ware_house_tsm_down.Text = "Depolar";
            // 
            // p_ware_house_tsm_down
            // 
            this.p_ware_house_tsm_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.p_ware_house_tsm_down.ForeColor = System.Drawing.Color.White;
            this.p_ware_house_tsm_down.Name = "p_ware_house_tsm_down";
            this.p_ware_house_tsm_down.Size = new System.Drawing.Size(234, 30);
            this.p_ware_house_tsm_down.Text = "Ürün-Depo İlişkisi";
            // 
            // supplier_mg_tsm
            // 
            this.supplier_mg_tsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.supplier_mg_tsm.ForeColor = System.Drawing.Color.White;
            this.supplier_mg_tsm.Image = global::stok_.Properties.Resources.parcel;
            this.supplier_mg_tsm.Name = "supplier_mg_tsm";
            this.supplier_mg_tsm.Size = new System.Drawing.Size(192, 29);
            this.supplier_mg_tsm.Text = "Tedarikci Yönetimi";
            // 
            // admin_main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1201, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.admin_main_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu_strip_main.ResumeLayout(false);
            this.menu_strip_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Panel pnl_screen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menu_strip_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem manin_menu_tsm;
        private System.Windows.Forms.ToolStripMenuItem stock_mg_tsm;
        private System.Windows.Forms.ToolStripMenuItem user_mg_tsm;
        private System.Windows.Forms.ToolStripMenuItem repot_mg_tsm;
        private System.Windows.Forms.ToolStripMenuItem supplier_mg_tsm;
        private System.Windows.Forms.ToolStripMenuItem products_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem category_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem stock_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem user_actions_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem roles_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem stock_report_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem sales_report_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem warehouse_mg_tsm;
        private System.Windows.Forms.ToolStripMenuItem ware_house_tsm_down;
        private System.Windows.Forms.ToolStripMenuItem p_ware_house_tsm_down;
    }
}