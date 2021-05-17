
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
            this.graphic4 = new System.Windows.Forms.Button();
            this.graphic5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "STATISTICAL REPORTS ON SUICIDES GLOBALLY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // graphViewer
            // 
            this.graphViewer.Location = new System.Drawing.Point(162, 49);
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.Size = new System.Drawing.Size(421, 374);
            this.graphViewer.TabIndex = 1;
            // 
            // graphic1
            // 
            this.graphic1.Location = new System.Drawing.Point(4, 55);
            this.graphic1.Name = "graphic1";
            this.graphic1.Size = new System.Drawing.Size(144, 37);
            this.graphic1.TabIndex = 2;
            this.graphic1.Text = "Male and female suicides globally";
            this.graphic1.UseVisualStyleBackColor = true;
            this.graphic1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // graphic2
            // 
            this.graphic2.Location = new System.Drawing.Point(4, 98);
            this.graphic2.Name = "graphic2";
            this.graphic2.Size = new System.Drawing.Size(144, 37);
            this.graphic2.TabIndex = 3;
            this.graphic2.Text = "Male suicides given a country";
            this.graphic2.UseVisualStyleBackColor = true;
            this.graphic2.Click += new System.EventHandler(this.graphic2_Click);
            // 
            // graphic3
            // 
            this.graphic3.Location = new System.Drawing.Point(4, 141);
            this.graphic3.Name = "graphic3";
            this.graphic3.Size = new System.Drawing.Size(144, 36);
            this.graphic3.TabIndex = 4;
            this.graphic3.Text = "Female suicides given a country";
            this.graphic3.UseVisualStyleBackColor = true;
            this.graphic3.Click += new System.EventHandler(this.graphic3_Click);
            // 
            // graphic4
            // 
            this.graphic4.Location = new System.Drawing.Point(4, 183);
            this.graphic4.Name = "graphic4";
            this.graphic4.Size = new System.Drawing.Size(144, 35);
            this.graphic4.TabIndex = 5;
            this.graphic4.Text = "Suicides according to a country and a year";
            this.graphic4.UseVisualStyleBackColor = true;
            this.graphic4.Click += new System.EventHandler(this.graphic4_Click);
            // 
            // graphic5
            // 
            this.graphic5.Location = new System.Drawing.Point(3, 224);
            this.graphic5.Name = "graphic5";
            this.graphic5.Size = new System.Drawing.Size(145, 49);
            this.graphic5.TabIndex = 6;
            this.graphic5.Text = "Suicides of generations given a country";
            this.graphic5.UseVisualStyleBackColor = true;
            this.graphic5.Click += new System.EventHandler(this.graphic5_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.graphic5);
            this.Controls.Add(this.graphic4);
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
        private System.Windows.Forms.Button graphic4;
        private System.Windows.Forms.Button graphic5;
    }
}
