
namespace stok_
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_login_page = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_oturum = new System.Windows.Forms.Label();
            this.txtbox_kullanici_adi = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl_parola_yenile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbox_sifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_login_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_login_page
            // 
            this.pnl_login_page.BackColor = System.Drawing.Color.White;
            this.pnl_login_page.Controls.Add(this.panel2);
            this.pnl_login_page.Controls.Add(this.txtbox_sifre);
            this.pnl_login_page.Controls.Add(this.panel1);
            this.pnl_login_page.Controls.Add(this.lbl_parola_yenile);
            this.pnl_login_page.Controls.Add(this.btn_giris);
            this.pnl_login_page.Controls.Add(this.txtbox_kullanici_adi);
            this.pnl_login_page.Controls.Add(this.lbl_oturum);
            this.pnl_login_page.Controls.Add(this.lbl_welcome);
            this.pnl_login_page.Controls.Add(this.lbl_exit);
            this.pnl_login_page.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_login_page.Location = new System.Drawing.Point(545, 0);
            this.pnl_login_page.Name = "pnl_login_page";
            this.pnl_login_page.Size = new System.Drawing.Size(421, 477);
            this.pnl_login_page.TabIndex = 1;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_exit.Location = new System.Drawing.Point(391, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(27, 28);
            this.lbl_exit.TabIndex = 0;
            this.lbl_exit.Text = "X";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_welcome.Location = new System.Drawing.Point(46, 91);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(205, 42);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Hoşgeldiniz";
            // 
            // lbl_oturum
            // 
            this.lbl_oturum.AutoSize = true;
            this.lbl_oturum.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oturum.Location = new System.Drawing.Point(50, 133);
            this.lbl_oturum.Name = "lbl_oturum";
            this.lbl_oturum.Size = new System.Drawing.Size(175, 13);
            this.lbl_oturum.TabIndex = 2;
            this.lbl_oturum.Text = "Devam etmek için oturum açın";
            // 
            // txtbox_kullanici_adi
            // 
            this.txtbox_kullanici_adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_kullanici_adi.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_kullanici_adi.Location = new System.Drawing.Point(85, 213);
            this.txtbox_kullanici_adi.Multiline = true;
            this.txtbox_kullanici_adi.Name = "txtbox_kullanici_adi";
            this.txtbox_kullanici_adi.Size = new System.Drawing.Size(276, 36);
            this.txtbox_kullanici_adi.TabIndex = 3;
            this.txtbox_kullanici_adi.Text = "Kullanıcı Adı";
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(77)))), ((int)(((byte)(56)))));
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(85, 375);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(276, 43);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "Giris";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lbl_parola_yenile
            // 
            this.lbl_parola_yenile.AutoSize = true;
            this.lbl_parola_yenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_parola_yenile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_parola_yenile.Location = new System.Drawing.Point(210, 327);
            this.lbl_parola_yenile.Name = "lbl_parola_yenile";
            this.lbl_parola_yenile.Size = new System.Drawing.Size(151, 13);
            this.lbl_parola_yenile.TabIndex = 7;
            this.lbl_parola_yenile.Text = "Parolanızı mı unuttunuz?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(77)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(85, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 5);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(77)))), ((int)(((byte)(56)))));
            this.panel2.Location = new System.Drawing.Point(85, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 5);
            this.panel2.TabIndex = 12;
            // 
            // txtbox_sifre
            // 
            this.txtbox_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_sifre.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_sifre.Location = new System.Drawing.Point(85, 271);
            this.txtbox_sifre.Multiline = true;
            this.txtbox_sifre.Name = "txtbox_sifre";
            this.txtbox_sifre.Size = new System.Drawing.Size(276, 36);
            this.txtbox_sifre.TabIndex = 11;
            this.txtbox_sifre.Text = "Sifre";
            this.txtbox_sifre.UseSystemPasswordChar = true;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 477);
            this.Controls.Add(this.pnl_login_page);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_login_page.ResumeLayout(false);
            this.pnl_login_page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_login_page;
        private System.Windows.Forms.Label lbl_parola_yenile;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox txtbox_kullanici_adi;
        private System.Windows.Forms.Label lbl_oturum;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbox_sifre;
    }
}

