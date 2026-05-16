namespace Electro_master
{
    partial class FrmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.frmVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVentas
            // 
            this.chartVentas.BackColor = System.Drawing.Color.Transparent;
            this.chartVentas.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVentas.Legends.Add(legend1);
            this.chartVentas.Location = new System.Drawing.Point(2, 111);
            this.chartVentas.Name = "chartVentas";
            this.chartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            series1.XValueMember = "1";
            this.chartVentas.Series.Add(series1);
            this.chartVentas.Size = new System.Drawing.Size(390, 266);
            this.chartVentas.TabIndex = 0;
            this.chartVentas.Text = "chart1";
            // 
            // chartStock
            // 
            this.chartStock.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.chartStock.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStock.Legends.Add(legend2);
            this.chartStock.Location = new System.Drawing.Point(423, 121);
            this.chartStock.Name = "chartStock";
            this.chartStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "UNO";
            series2.Name = "Series1";
            this.chartStock.Series.Add(series2);
            this.chartStock.Size = new System.Drawing.Size(365, 243);
            this.chartStock.TabIndex = 1;
            this.chartStock.Text = "chart1";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(12, 36);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(366, 38);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "VENTAS POR SUCURSAL";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "STOCK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmVentasBindingSource
            // 
            this.frmVentasBindingSource.DataSource = typeof(Electro_master.FrmVentas);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.chartStock);
            this.Controls.Add(this.chartVentas);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmVentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource frmVentasBindingSource;
    }
}