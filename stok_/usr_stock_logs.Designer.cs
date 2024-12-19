
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
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_logs)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_logs
            // 
            this.data_grid_logs.AllowUserToAddRows = false;
            this.data_grid_logs.AllowUserToDeleteRows = false;
            this.data_grid_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_logs.Location = new System.Drawing.Point(101, 93);
            this.data_grid_logs.Name = "data_grid_logs";
            this.data_grid_logs.ReadOnly = true;
            this.data_grid_logs.Size = new System.Drawing.Size(662, 413);
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
            // usr_stock_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_grid_logs);
            this.Name = "usr_stock_logs";
            this.Size = new System.Drawing.Size(1203, 541);
            this.Load += new System.EventHandler(this.usr_stock_logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_logs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_logs;
        private System.Windows.Forms.Label label4;
    }
}
