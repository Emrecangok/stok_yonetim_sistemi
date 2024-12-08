
namespace stok_
{
    partial class stock_transacition_form
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
            this.label15 = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.lbl_quit = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.txtbox_quantity = new System.Windows.Forms.TextBox();
            this.cmb_box_product_name = new System.Windows.Forms.ComboBox();
            this.cmb_box_warehouse_name = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(151, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Depolar Arasında Stok Transferi";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pnl_top.Controls.Add(this.lbl_exit);
            this.pnl_top.Controls.Add(this.lbl_quit);
            this.pnl_top.Controls.Add(this.label15);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(523, 32);
            this.pnl_top.TabIndex = 30;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseMove);
            this.pnl_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseUp);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_exit.Location = new System.Drawing.Point(507, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(16, 17);
            this.lbl_exit.TabIndex = 20;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // lbl_quit
            // 
            this.lbl_quit.AutoSize = true;
            this.lbl_quit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_quit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_quit.Location = new System.Drawing.Point(523, 0);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(16, 17);
            this.lbl_quit.TabIndex = 19;
            this.lbl_quit.Text = "X";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_b.Location = new System.Drawing.Point(333, 35);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(139, 28);
            this.lbl_b.TabIndex = 40;
            this.lbl_b.Text = "B Deposuna";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_a.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_a.Location = new System.Drawing.Point(54, 35);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(169, 28);
            this.lbl_a.TabIndex = 31;
            this.lbl_a.Text = "A Deposundan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Miktarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Depo Adı";
            // 
            // btn_transfer
            // 
            this.btn_transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transfer.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transfer.ForeColor = System.Drawing.Color.White;
            this.btn_transfer.Location = new System.Drawing.Point(164, 216);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(95, 30);
            this.btn_transfer.TabIndex = 36;
            this.btn_transfer.Text = "Transfer Et";
            this.btn_transfer.UseVisualStyleBackColor = false;
            // 
            // txtbox_quantity
            // 
            this.txtbox_quantity.Location = new System.Drawing.Point(86, 193);
            this.txtbox_quantity.Name = "txtbox_quantity";
            this.txtbox_quantity.Size = new System.Drawing.Size(121, 20);
            this.txtbox_quantity.TabIndex = 35;
            // 
            // cmb_box_product_name
            // 
            this.cmb_box_product_name.FormattingEnabled = true;
            this.cmb_box_product_name.Location = new System.Drawing.Point(86, 144);
            this.cmb_box_product_name.Name = "cmb_box_product_name";
            this.cmb_box_product_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_product_name.TabIndex = 34;
            // 
            // cmb_box_warehouse_name
            // 
            this.cmb_box_warehouse_name.FormattingEnabled = true;
            this.cmb_box_warehouse_name.Location = new System.Drawing.Point(86, 103);
            this.cmb_box_warehouse_name.Name = "cmb_box_warehouse_name";
            this.cmb_box_warehouse_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_warehouse_name.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(265, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 266);
            this.panel2.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(276, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Depo Adı";
            // 
            // stock_transacition_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.txtbox_quantity);
            this.Controls.Add(this.cmb_box_product_name);
            this.Controls.Add(this.cmb_box_warehouse_name);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stock_transacition_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stock_transacition_form";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_quit;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.TextBox txtbox_quantity;
        private System.Windows.Forms.ComboBox cmb_box_product_name;
        private System.Windows.Forms.ComboBox cmb_box_warehouse_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_exit;
    }
}