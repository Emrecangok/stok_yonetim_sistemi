﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.line_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.pie_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_box_supplier = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_stock_value = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie_graph)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(557, 38);
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
            this.lbl_quit.Location = new System.Drawing.Point(536, 0);
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
            this.label15.Location = new System.Drawing.Point(3, 16);
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
            this.btn_add.Location = new System.Drawing.Point(90, 322);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 30);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "Depoya Ekle";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmb_box_product_name
            // 
            this.cmb_box_product_name.FormattingEnabled = true;
            this.cmb_box_product_name.Location = new System.Drawing.Point(90, 194);
            this.cmb_box_product_name.Name = "cmb_box_product_name";
            this.cmb_box_product_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_product_name.TabIndex = 28;
            this.cmb_box_product_name.SelectedIndexChanged += new System.EventHandler(this.cmb_box_product_name_SelectedIndexChanged);
            // 
            // cmb_box_warehouse_name
            // 
            this.cmb_box_warehouse_name.FormattingEnabled = true;
            this.cmb_box_warehouse_name.Location = new System.Drawing.Point(90, 130);
            this.cmb_box_warehouse_name.Name = "cmb_box_warehouse_name";
            this.cmb_box_warehouse_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_warehouse_name.TabIndex = 27;
            this.cmb_box_warehouse_name.SelectedIndexChanged += new System.EventHandler(this.cmb_box_warehouse_name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Depo Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ürün Miktarı";
            // 
            // txt_box_product_quantity
            // 
            this.txt_box_product_quantity.Location = new System.Drawing.Point(93, 285);
            this.txt_box_product_quantity.Name = "txt_box_product_quantity";
            this.txt_box_product_quantity.Size = new System.Drawing.Size(121, 20);
            this.txt_box_product_quantity.TabIndex = 42;
            // 
            // line_graph
            // 
            chartArea3.Name = "ChartArea1";
            this.line_graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.line_graph.Legends.Add(legend3);
            this.line_graph.Location = new System.Drawing.Point(239, 92);
            this.line_graph.Name = "line_graph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.line_graph.Series.Add(series3);
            this.line_graph.Size = new System.Drawing.Size(313, 164);
            this.line_graph.TabIndex = 43;
            this.line_graph.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(255, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Seçilen Ürünün Çizgi Grafiği";
            // 
            // pie_graph
            // 
            chartArea4.Name = "ChartArea1";
            this.pie_graph.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.pie_graph.Legends.Add(legend4);
            this.pie_graph.Location = new System.Drawing.Point(244, 322);
            this.pie_graph.Name = "pie_graph";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.pie_graph.Series.Add(series4);
            this.pie_graph.Size = new System.Drawing.Size(313, 164);
            this.pie_graph.TabIndex = 44;
            this.pie_graph.Text = "chart2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(255, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Deponun Genel Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Tedarikci";
            // 
            // cmb_box_supplier
            // 
            this.cmb_box_supplier.FormattingEnabled = true;
            this.cmb_box_supplier.Location = new System.Drawing.Point(90, 240);
            this.cmb_box_supplier.Name = "cmb_box_supplier";
            this.cmb_box_supplier.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_supplier.TabIndex = 47;
            this.cmb_box_supplier.SelectedIndexChanged += new System.EventHandler(this.cmb_box_supplier_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(18, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ürünün Depodaki Mevcut Sayısı:";
            // 
            // lbl_stock_value
            // 
            this.lbl_stock_value.AutoSize = true;
            this.lbl_stock_value.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stock_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_stock_value.Location = new System.Drawing.Point(83, 415);
            this.lbl_stock_value.Name = "lbl_stock_value";
            this.lbl_stock_value.Size = new System.Drawing.Size(71, 39);
            this.lbl_stock_value.TabIndex = 49;
            this.lbl_stock_value.Text = "155";
            // 
            // add_product_to_warehouse_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 522);
            this.Controls.Add(this.lbl_stock_value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_box_supplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pie_graph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.line_graph);
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
            this.Load += new System.EventHandler(this.add_product_to_warehouse_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie_graph)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart line_graph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie_graph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_box_supplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_stock_value;
    }
}