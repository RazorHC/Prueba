namespace Electro_master
{
    partial class Menu_Princ
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Princ));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStock.Location = new System.Drawing.Point(21, 167);
            this.btnStock.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(704, 129);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "VER STOCK";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentas.Location = new System.Drawing.Point(21, 315);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(704, 133);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.BackColor = System.Drawing.Color.Black;
            this.btnResumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResumen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResumen.Location = new System.Drawing.Point(21, 14);
            this.btnResumen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(704, 130);
            this.btnResumen.TabIndex = 2;
            this.btnResumen.Text = "VER RESUMEN";
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Location = new System.Drawing.Point(21, 474);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(704, 128);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // Menu_Princ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1374, 639);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnStock);
            this.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Menu_Princ";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Menu_Princ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Button btnDashboard;
    }
}

