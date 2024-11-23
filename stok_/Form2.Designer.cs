
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_user_management = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_products_management = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_screen = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 83);
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
            // btn_user_management
            // 
            this.btn_user_management.FlatAppearance.BorderSize = 0;
            this.btn_user_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_management.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_user_management.ForeColor = System.Drawing.Color.White;
            this.btn_user_management.Image = ((System.Drawing.Image)(resources.GetObject("btn_user_management.Image")));
            this.btn_user_management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_management.Location = new System.Drawing.Point(0, 174);
            this.btn_user_management.Name = "btn_user_management";
            this.btn_user_management.Size = new System.Drawing.Size(200, 37);
            this.btn_user_management.TabIndex = 1;
            this.btn_user_management.Text = "Kullanıcı Yönetimi";
            this.btn_user_management.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_user_management.UseVisualStyleBackColor = true;
            this.btn_user_management.Click += new System.EventHandler(this.btn_user_management_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_products_management);
            this.panel2.Controls.Add(this.btn_user_management);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 577);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ana Menü         ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 83);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin Kontrol Paneli";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Tedarikçi Yönetimi";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stok Yönetimi    ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_products_management
            // 
            this.btn_products_management.FlatAppearance.BorderSize = 0;
            this.btn_products_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products_management.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_products_management.ForeColor = System.Drawing.Color.White;
            this.btn_products_management.Image = ((System.Drawing.Image)(resources.GetObject("btn_products_management.Image")));
            this.btn_products_management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products_management.Location = new System.Drawing.Point(0, 254);
            this.btn_products_management.Name = "btn_products_management";
            this.btn_products_management.Size = new System.Drawing.Size(200, 37);
            this.btn_products_management.TabIndex = 2;
            this.btn_products_management.Text = "Ürün Yönetimi   ";
            this.btn_products_management.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_products_management.UseVisualStyleBackColor = true;
            this.btn_products_management.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_screen
            // 
            this.pnl_screen.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_screen.Location = new System.Drawing.Point(201, 81);
            this.pnl_screen.Name = "pnl_screen";
            this.pnl_screen.Size = new System.Drawing.Size(1002, 496);
            this.pnl_screen.TabIndex = 2;
            this.pnl_screen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_screen_Paint);
            // 
            // admin_main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1201, 577);
            this.Controls.Add(this.pnl_screen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.admin_main_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_user_management;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_products_management;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnl_screen;
    }
}