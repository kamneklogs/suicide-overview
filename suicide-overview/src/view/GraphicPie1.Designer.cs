
namespace suicide_overview.src.view
{
    partial class GraphicPie1
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.viewGraphic = new System.Windows.Forms.Button();
            this.country1 = new System.Windows.Forms.TextBox();
            this.country2 = new System.Windows.Forms.TextBox();
            this.country3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 88);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(388, 265);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter 3 countries to consult";
            // 
            // viewGraphic
            // 
            this.viewGraphic.Location = new System.Drawing.Point(96, 51);
            this.viewGraphic.Name = "viewGraphic";
            this.viewGraphic.Size = new System.Drawing.Size(117, 31);
            this.viewGraphic.TabIndex = 3;
            this.viewGraphic.Text = "Show graphic";
            this.viewGraphic.UseVisualStyleBackColor = true;
            this.viewGraphic.Click += new System.EventHandler(this.viewGraphic_Click);
            // 
            // country1
            // 
            this.country1.Location = new System.Drawing.Point(3, 25);
            this.country1.Name = "country1";
            this.country1.Size = new System.Drawing.Size(87, 20);
            this.country1.TabIndex = 4;
            // 
            // country2
            // 
            this.country2.Location = new System.Drawing.Point(115, 25);
            this.country2.Name = "country2";
            this.country2.Size = new System.Drawing.Size(98, 20);
            this.country2.TabIndex = 5;
            // 
            // country3
            // 
            this.country3.Location = new System.Drawing.Point(241, 25);
            this.country3.Name = "country3";
            this.country3.Size = new System.Drawing.Size(100, 20);
            this.country3.TabIndex = 6;
            // 
            // GraphicPie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.country3);
            this.Controls.Add(this.country2);
            this.Controls.Add(this.country1);
            this.Controls.Add(this.viewGraphic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Name = "GraphicPie1";
            this.Size = new System.Drawing.Size(421, 374);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewGraphic;
        private System.Windows.Forms.TextBox country1;
        private System.Windows.Forms.TextBox country2;
        private System.Windows.Forms.TextBox country3;
    }
}
