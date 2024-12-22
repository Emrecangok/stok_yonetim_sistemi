
namespace stok_
{
    partial class remove_product_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_quit = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_box_product_name = new System.Windows.Forms.ComboBox();
            this.cmb_box_warehouse_name = new System.Windows.Forms.ComboBox();
            this.lbl_stock_value = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_box_product_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_quit);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 38);
            this.panel1.TabIndex = 27;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lbl_quit
            // 
            this.lbl_quit.AutoSize = true;
            this.lbl_quit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_quit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_quit.Location = new System.Drawing.Point(536, 0);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(16, 17);
            this.lbl_quit.TabIndex = 20;
            this.lbl_quit.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(3, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 22);
            this.label15.TabIndex = 19;
            this.label15.Text = "Depodan Stok Çıkar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Depo Adı";
            // 
            // cmb_box_product_name
            // 
            this.cmb_box_product_name.FormattingEnabled = true;
            this.cmb_box_product_name.Location = new System.Drawing.Point(105, 182);
            this.cmb_box_product_name.Name = "cmb_box_product_name";
            this.cmb_box_product_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_product_name.TabIndex = 41;
            this.cmb_box_product_name.SelectedIndexChanged += new System.EventHandler(this.cmb_box_product_name_SelectedIndexChanged);
            // 
            // cmb_box_warehouse_name
            // 
            this.cmb_box_warehouse_name.FormattingEnabled = true;
            this.cmb_box_warehouse_name.Location = new System.Drawing.Point(105, 118);
            this.cmb_box_warehouse_name.Name = "cmb_box_warehouse_name";
            this.cmb_box_warehouse_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_warehouse_name.TabIndex = 40;
            this.cmb_box_warehouse_name.SelectedIndexChanged += new System.EventHandler(this.cmb_box_warehouse_name_SelectedIndexChanged);
            // 
            // lbl_stock_value
            // 
            this.lbl_stock_value.AutoSize = true;
            this.lbl_stock_value.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stock_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_stock_value.Location = new System.Drawing.Point(98, 383);
            this.lbl_stock_value.Name = "lbl_stock_value";
            this.lbl_stock_value.Size = new System.Drawing.Size(71, 39);
            this.lbl_stock_value.TabIndex = 54;
            this.lbl_stock_value.Text = "155";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(33, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Ürünün Depodaki Mevcut Sayısı:";
            // 
            // txt_box_product_quantity
            // 
            this.txt_box_product_quantity.Location = new System.Drawing.Point(108, 253);
            this.txt_box_product_quantity.Name = "txt_box_product_quantity";
            this.txt_box_product_quantity.Size = new System.Drawing.Size(121, 20);
            this.txt_box_product_quantity.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ürün Miktarı";
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(99, 292);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(130, 30);
            this.btn_remove.TabIndex = 50;
            this.btn_remove.Text = "Depodan Çıkar";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(255, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // remove_product_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 471);
            this.Controls.Add(this.lbl_stock_value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_box_product_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_box_product_name);
            this.Controls.Add(this.cmb_box_warehouse_name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "remove_product_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "remove_product_form";
            this.Load += new System.EventHandler(this.remove_product_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_quit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_box_product_name;
        private System.Windows.Forms.ComboBox cmb_box_warehouse_name;
        private System.Windows.Forms.Label lbl_stock_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_box_product_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label4;
    }
}