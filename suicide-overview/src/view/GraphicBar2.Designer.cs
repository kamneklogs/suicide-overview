
namespace suicide_overview.src.view
{
    partial class GraphicBar2
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.country1 = new System.Windows.Forms.TextBox();
            this.country2 = new System.Windows.Forms.TextBox();
            this.country3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewGraphic = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cleartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // country1
            // 
            this.country1.Location = new System.Drawing.Point(19, 32);
            this.country1.Name = "country1";
            this.country1.Size = new System.Drawing.Size(100, 20);
            this.country1.TabIndex = 0;
            // 
            // country2
            // 
            this.country2.Location = new System.Drawing.Point(126, 32);
            this.country2.Name = "country2";
            this.country2.Size = new System.Drawing.Size(100, 20);
            this.country2.TabIndex = 1;
            // 
            // country3
            // 
            this.country3.Location = new System.Drawing.Point(232, 32);
            this.country3.Name = "country3";
            this.country3.Size = new System.Drawing.Size(100, 20);
            this.country3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter 3 countries to consult";
            // 
            // viewGraphic
            // 
            this.viewGraphic.Location = new System.Drawing.Point(73, 58);
            this.viewGraphic.Name = "viewGraphic";
            this.viewGraphic.Size = new System.Drawing.Size(97, 23);
            this.viewGraphic.TabIndex = 4;
            this.viewGraphic.Text = "Show graphic";
            this.viewGraphic.UseVisualStyleBackColor = true;
            this.viewGraphic.Click += new System.EventHandler(this.viewGraphic_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 87);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart1.Size = new System.Drawing.Size(504, 360);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // cleartBtn
            // 
            this.cleartBtn.Enabled = false;
            this.cleartBtn.Location = new System.Drawing.Point(177, 58);
            this.cleartBtn.Name = "cleartBtn";
            this.cleartBtn.Size = new System.Drawing.Size(99, 23);
            this.cleartBtn.TabIndex = 6;
            this.cleartBtn.Text = "Clear";
            this.cleartBtn.UseVisualStyleBackColor = true;
            this.cleartBtn.Click += new System.EventHandler(this.cleartBtn_Click);
            // 
            // GraphicBar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.cleartBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.viewGraphic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.country3);
            this.Controls.Add(this.country2);
            this.Controls.Add(this.country1);
            this.Name = "GraphicBar2";
            this.Size = new System.Drawing.Size(510, 450);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox country1;
        private System.Windows.Forms.TextBox country2;
        private System.Windows.Forms.TextBox country3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewGraphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button cleartBtn;
    }
}
