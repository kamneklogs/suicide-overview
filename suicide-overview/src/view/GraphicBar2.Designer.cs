
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.country1 = new System.Windows.Forms.TextBox();
            this.country2 = new System.Windows.Forms.TextBox();
            this.country3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewGraphic = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.label1.Location = new System.Drawing.Point(99, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese 3 países a conocer";
            // 
            // viewGraphic
            // 
            this.viewGraphic.Location = new System.Drawing.Point(126, 58);
            this.viewGraphic.Name = "viewGraphic";
            this.viewGraphic.Size = new System.Drawing.Size(75, 23);
            this.viewGraphic.TabIndex = 4;
            this.viewGraphic.Text = "ver gráfico";
            this.viewGraphic.UseVisualStyleBackColor = true;
            this.viewGraphic.Click += new System.EventHandler(this.viewGraphic_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(69, 87);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(209, 208);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // GraphicBar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.viewGraphic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.country3);
            this.Controls.Add(this.country2);
            this.Controls.Add(this.country1);
            this.Name = "GraphicBar2";
            this.Size = new System.Drawing.Size(350, 323);
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
    }
}
