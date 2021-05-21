
namespace suicide_overview.src.view
{
    partial class GraphicBar3
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
            this.label1 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.viewGraphic = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the country to consult";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(146, 15);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 20);
            this.country.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 41);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart1.Size = new System.Drawing.Size(474, 393);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // viewGraphic
            // 
            this.viewGraphic.Location = new System.Drawing.Point(252, 3);
            this.viewGraphic.Name = "viewGraphic";
            this.viewGraphic.Size = new System.Drawing.Size(76, 36);
            this.viewGraphic.TabIndex = 3;
            this.viewGraphic.Text = "Show graphic";
            this.viewGraphic.UseVisualStyleBackColor = true;
            this.viewGraphic.Click += new System.EventHandler(this.viewGraphic_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.Location = new System.Drawing.Point(334, 12);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // GraphicBar3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.viewGraphic);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label1);
            this.Name = "GraphicBar3";
            this.Size = new System.Drawing.Size(510, 450);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button viewGraphic;
        private System.Windows.Forms.Button clearBtn;
    }
}
