
namespace stok_
{
    partial class usr_stock_logs
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
            this.data_grid_logs = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.date_tmp_start = new System.Windows.Forms.DateTimePicker();
            this.date_tmp_end = new System.Windows.Forms.DateTimePicker();
            this.txt_box_name = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_show_all_logs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_logs)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_logs
            // 
            this.data_grid_logs.AllowUserToAddRows = false;
            this.data_grid_logs.AllowUserToDeleteRows = false;
            this.data_grid_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_logs.Location = new System.Drawing.Point(17, 102);
            this.data_grid_logs.Name = "data_grid_logs";
            this.data_grid_logs.ReadOnly = true;
            this.data_grid_logs.Size = new System.Drawing.Size(662, 391);
            this.data_grid_logs.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(29, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 39);
            this.label4.TabIndex = 22;
            this.label4.Text = "Stok Hareketleri Takip";
            // 
            // date_tmp_start
            // 
            this.date_tmp_start.Location = new System.Drawing.Point(799, 139);
            this.date_tmp_start.Name = "date_tmp_start";
            this.date_tmp_start.Size = new System.Drawing.Size(200, 20);
            this.date_tmp_start.TabIndex = 23;
            // 
            // date_tmp_end
            // 
            this.date_tmp_end.Location = new System.Drawing.Point(799, 192);
            this.date_tmp_end.Name = "date_tmp_end";
            this.date_tmp_end.Size = new System.Drawing.Size(200, 20);
            this.date_tmp_end.TabIndex = 24;
            // 
            // txt_box_name
            // 
            this.txt_box_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_box_name.Location = new System.Drawing.Point(799, 249);
            this.txt_box_name.Name = "txt_box_name";
            this.txt_box_name.Size = new System.Drawing.Size(200, 20);
            this.txt_box_name.TabIndex = 25;
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.ForeColor = System.Drawing.Color.White;
            this.btn_find.Location = new System.Drawing.Point(899, 300);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(100, 30);
            this.btn_find.TabIndex = 30;
            this.btn_find.Text = "ARA";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(685, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Başlangıc Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(698, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(698, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // btn_show_all_logs
            // 
            this.btn_show_all_logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btn_show_all_logs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_all_logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_all_logs.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_all_logs.ForeColor = System.Drawing.Color.White;
            this.btn_show_all_logs.Location = new System.Drawing.Point(701, 463);
            this.btn_show_all_logs.Name = "btn_show_all_logs";
            this.btn_show_all_logs.Size = new System.Drawing.Size(141, 30);
            this.btn_show_all_logs.TabIndex = 42;
            this.btn_show_all_logs.Text = "Tüm Logları Gör";
            this.btn_show_all_logs.UseVisualStyleBackColor = false;
            this.btn_show_all_logs.Click += new System.EventHandler(this.btn_show_all_logs_Click);
            // 
            // usr_stock_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_show_all_logs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.txt_box_name);
            this.Controls.Add(this.date_tmp_end);
            this.Controls.Add(this.date_tmp_start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_grid_logs);
            this.Name = "usr_stock_logs";
            this.Size = new System.Drawing.Size(1002, 496);
            this.Load += new System.EventHandler(this.usr_stock_logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_logs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_logs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_tmp_start;
        private System.Windows.Forms.DateTimePicker date_tmp_end;
        private System.Windows.Forms.TextBox txt_box_name;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_show_all_logs;
    }
}
