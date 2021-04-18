
namespace suicide_overview.src.view
{
    partial class Graphs
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
            this.label1 = new System.Windows.Forms.Label();
            this.viewGraphic = new System.Windows.Forms.Panel();
            this.viewBarGraphic = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // viewGraphic
            // 
            this.viewGraphic.Location = new System.Drawing.Point(204, 54);
            this.viewGraphic.Name = "viewGraphic";
            this.viewGraphic.Size = new System.Drawing.Size(350, 323);
            this.viewGraphic.TabIndex = 2;
            this.viewGraphic.TabStop = true;
            // 
            // viewBarGraphic
            // 
            this.viewBarGraphic.AutoSize = true;
            this.viewBarGraphic.Location = new System.Drawing.Point(34, 78);
            this.viewBarGraphic.Name = "viewBarGraphic";
            this.viewBarGraphic.Size = new System.Drawing.Size(342, 13);
            this.viewBarGraphic.TabIndex = 3;
            this.viewBarGraphic.TabStop = true;
            this.viewBarGraphic.Text = "Ver gráfico de barras  de los hombres y mujeres muertos a nivel mundial";
            this.viewBarGraphic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewBarGraphic_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(37, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(214, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hombres y mujeres según un  año y un país";
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewGraphic);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.viewBarGraphic);
            this.Name = "Graphs";
            this.Size = new System.Drawing.Size(599, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel viewGraphic;
        private System.Windows.Forms.LinkLabel viewBarGraphic;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
