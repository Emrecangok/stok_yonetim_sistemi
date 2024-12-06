
namespace stok_
{
    partial class usr_ware_house
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.data_grid_ware_house = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_box_warehose_adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_warehouse_name = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.ware_house_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ware_house_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_ware_house)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.data_grid_ware_house);
            this.panel1.Location = new System.Drawing.Point(107, 12);
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
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Depo Verileri";
            // 
            // data_grid_ware_house
            // 
            this.data_grid_ware_house.AllowUserToDeleteRows = false;
            this.data_grid_ware_house.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_ware_house.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ware_house_id,
            this.ware_house_name,
            this.address});
            this.data_grid_ware_house.Location = new System.Drawing.Point(34, 41);
            this.data_grid_ware_house.Name = "data_grid_ware_house";
            this.data_grid_ware_house.ReadOnly = true;
            this.data_grid_ware_house.Size = new System.Drawing.Size(730, 181);
            this.data_grid_ware_house.TabIndex = 0;
            this.data_grid_ware_house.SelectionChanged += new System.EventHandler(this.data_grid_ware_house_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_box_warehose_adress);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtbox_warehouse_name);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Location = new System.Drawing.Point(107, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 189);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Depo Adresi";
            // 
            // txt_box_warehose_adress
            // 
            this.txt_box_warehose_adress.Location = new System.Drawing.Point(138, 76);
            this.txt_box_warehose_adress.Multiline = true;
            this.txt_box_warehose_adress.Name = "txt_box_warehose_adress";
            this.txt_box_warehose_adress.Size = new System.Drawing.Size(419, 51);
            this.txt_box_warehose_adress.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Depo Adı";
            // 
            // txtbox_warehouse_name
            // 
            this.txtbox_warehouse_name.Location = new System.Drawing.Point(115, 26);
            this.txtbox_warehouse_name.Name = "txtbox_warehouse_name";
            this.txtbox_warehouse_name.Size = new System.Drawing.Size(148, 20);
            this.txtbox_warehouse_name.TabIndex = 10;
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
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
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
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
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
            // ware_house_id
            // 
            this.ware_house_id.HeaderText = "id";
            this.ware_house_id.Name = "ware_house_id";
            this.ware_house_id.ReadOnly = true;
            // 
            // ware_house_name
            // 
            this.ware_house_name.HeaderText = "Depo Adı";
            this.ware_house_name.Name = "ware_house_name";
            this.ware_house_name.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Depo Adresi";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 600;
            // 
            // usr_ware_house
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "usr_ware_house";
            this.Size = new System.Drawing.Size(1002, 496);
            this.Load += new System.EventHandler(this.usr_ware_house_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_ware_house)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_grid_ware_house;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_box_warehose_adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_warehouse_name;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn ware_house_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ware_house_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}
