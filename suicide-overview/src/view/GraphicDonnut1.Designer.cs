
namespace suicide_overview.src.view
{
    partial class GraphicDonnut1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.year3 = new System.Windows.Forms.TextBox();
            this.year2 = new System.Windows.Forms.TextBox();
            this.year1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.viewGraphic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese  el  país y los  años a consultar";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(64, 61);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(103, 20);
            this.country.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "País:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Año 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Año 3:";
            // 
            // year3
            // 
            this.year3.Location = new System.Drawing.Point(279, 31);
            this.year3.Name = "year3";
            this.year3.Size = new System.Drawing.Size(50, 20);
            this.year3.TabIndex = 6;
            // 
            // year2
            // 
            this.year2.Location = new System.Drawing.Point(167, 31);
            this.year2.Name = "year2";
            this.year2.Size = new System.Drawing.Size(50, 20);
            this.year2.TabIndex = 7;
            // 
            // year1
            // 
            this.year1.Location = new System.Drawing.Point(70, 31);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(50, 20);
            this.year1.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(44, 112);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(250, 192);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // viewGraphic
            // 
            this.viewGraphic.Location = new System.Drawing.Point(198, 61);
            this.viewGraphic.Name = "viewGraphic";
            this.viewGraphic.Size = new System.Drawing.Size(75, 23);
            this.viewGraphic.TabIndex = 10;
            this.viewGraphic.Text = "Ver gráfico";
            this.viewGraphic.UseVisualStyleBackColor = true;
            this.viewGraphic.Click += new System.EventHandler(this.viewGraphic_Click);
            // 
            // GraphicDonnut1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewGraphic);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.year2);
            this.Controls.Add(this.year3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label1);
            this.Name = "GraphicDonnut1";
            this.Size = new System.Drawing.Size(350, 323);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox year3;
        private System.Windows.Forms.TextBox year2;
        private System.Windows.Forms.TextBox year1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button viewGraphic;
    }
}
