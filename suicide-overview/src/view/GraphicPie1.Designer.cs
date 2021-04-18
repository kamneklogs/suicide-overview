
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(69, 99);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(187, 210);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese 3 países a  conocer";
            // 
            // viewGraphic
            // 
            this.viewGraphic.Location = new System.Drawing.Point(96, 62);
            this.viewGraphic.Name = "viewGraphic";
            this.viewGraphic.Size = new System.Drawing.Size(117, 31);
            this.viewGraphic.TabIndex = 3;
            this.viewGraphic.Text = "Ver gráfico";
            this.viewGraphic.UseVisualStyleBackColor = true;
            this.viewGraphic.Click += new System.EventHandler(this.viewGraphic_Click);
            // 
            // country1
            // 
            this.country1.Location = new System.Drawing.Point(22, 36);
            this.country1.Name = "country1";
            this.country1.Size = new System.Drawing.Size(87, 20);
            this.country1.TabIndex = 4;
            // 
            // country2
            // 
            this.country2.Location = new System.Drawing.Point(115, 36);
            this.country2.Name = "country2";
            this.country2.Size = new System.Drawing.Size(98, 20);
            this.country2.TabIndex = 5;
            // 
            // country3
            // 
            this.country3.Location = new System.Drawing.Point(219, 36);
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
            this.Size = new System.Drawing.Size(350, 323);
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
