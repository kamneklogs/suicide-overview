
using suicide_overview.src.model;

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
            this.graphViewer = new System.Windows.Forms.Panel();
            this.graphic1 = new System.Windows.Forms.Button();
            this.graphic2 = new System.Windows.Forms.Button();
            this.graphic3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graficos Estadisticos";
            // 
            // graphViewer
            // 
            this.graphViewer.Location = new System.Drawing.Point(224, 73);
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.Size = new System.Drawing.Size(350, 323);
            this.graphViewer.TabIndex = 1;
            // 
            // graphic1
            // 
            this.graphic1.Location = new System.Drawing.Point(4, 125);
            this.graphic1.Name = "graphic1";
            this.graphic1.Size = new System.Drawing.Size(200, 37);
            this.graphic1.TabIndex = 2;
            this.graphic1.Text = "Suicidios masculinos y femeninos a nivel global";
            this.graphic1.UseVisualStyleBackColor = true;
            this.graphic1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // graphic2
            // 
            this.graphic2.Location = new System.Drawing.Point(4, 168);
            this.graphic2.Name = "graphic2";
            this.graphic2.Size = new System.Drawing.Size(200, 23);
            this.graphic2.TabIndex = 3;
            this.graphic2.Text = "Suicidios masculinos dado un país";
            this.graphic2.UseVisualStyleBackColor = true;
            this.graphic2.Click += new System.EventHandler(this.graphic2_Click);
            // 
            // graphic3
            // 
            this.graphic3.Location = new System.Drawing.Point(4, 197);
            this.graphic3.Name = "graphic3";
            this.graphic3.Size = new System.Drawing.Size(199, 23);
            this.graphic3.TabIndex = 4;
            this.graphic3.Text = "Suicidios femeninos dado un país";
            this.graphic3.UseVisualStyleBackColor = true;
            this.graphic3.Click += new System.EventHandler(this.graphic3_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graphic3);
            this.Controls.Add(this.graphic2);
            this.Controls.Add(this.graphic1);
            this.Controls.Add(this.graphViewer);
            this.Controls.Add(this.label1);
            this.Name = "Graphs";
            this.Size = new System.Drawing.Size(599, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel graphViewer;
        private System.Windows.Forms.Button graphic1;
        private System.Windows.Forms.Button graphic2;
        private System.Windows.Forms.Button graphic3;
    }
}
