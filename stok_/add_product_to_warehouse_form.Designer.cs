
namespace stok_
{
    partial class add_product_to_warehouse_form
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
            this.btn_add = new System.Windows.Forms.Button();
            this.cmb_box_product_name = new System.Windows.Forms.ComboBox();
            this.cmb_box_warehouse_name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_box_product_quantity = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.lbl_quit);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 38);
            this.panel1.TabIndex = 26;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lbl_quit
            // 
            this.lbl_quit.AutoSize = true;
            this.lbl_quit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_quit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_quit.Location = new System.Drawing.Point(272, 0);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(16, 17);
            this.lbl_quit.TabIndex = 20;
            this.lbl_quit.Text = "X";
            this.lbl_quit.Click += new System.EventHandler(this.lbl_quit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(72, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 22);
            this.label15.TabIndex = 19;
            this.label15.Text = "Depoya Stok Ekle";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(90, 210);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 30);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "Depoya Ekle";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // cmb_box_product_name
            // 
            this.cmb_box_product_name.FormattingEnabled = true;
            this.cmb_box_product_name.Location = new System.Drawing.Point(90, 131);
            this.cmb_box_product_name.Name = "cmb_box_product_name";
            this.cmb_box_product_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_product_name.TabIndex = 28;
            // 
            // cmb_box_warehouse_name
            // 
            this.cmb_box_warehouse_name.FormattingEnabled = true;
            this.cmb_box_warehouse_name.Location = new System.Drawing.Point(90, 92);
            this.cmb_box_warehouse_name.Name = "cmb_box_warehouse_name";
            this.cmb_box_warehouse_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_warehouse_name.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Depo Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ürün Miktarı";
            // 
            // txt_box_product_quantity
            // 
            this.txt_box_product_quantity.Location = new System.Drawing.Point(90, 172);
            this.txt_box_product_quantity.Name = "txt_box_product_quantity";
            this.txt_box_product_quantity.Size = new System.Drawing.Size(121, 20);
            this.txt_box_product_quantity.TabIndex = 42;
            // 
            // add_product_to_warehouse_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 261);
            this.Controls.Add(this.txt_box_product_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_box_product_name);
            this.Controls.Add(this.cmb_box_warehouse_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_product_to_warehouse_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_product_to_warehouse_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_quit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_box_product_name;
        private System.Windows.Forms.ComboBox cmb_box_warehouse_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_box_product_quantity;
    }
}