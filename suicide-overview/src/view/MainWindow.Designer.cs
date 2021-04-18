
namespace suicide_overview
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewColumnsReports = new System.Windows.Forms.LinkLabel();
            this.linkToGraphs = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.mainPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.viewColumnsReports);
            this.panel1.Controls.Add(this.linkToGraphs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 426);
            this.panel1.TabIndex = 0;
            // 
            // viewColumnsReports
            // 
            this.viewColumnsReports.AutoSize = true;
            this.viewColumnsReports.Location = new System.Drawing.Point(17, 81);
            this.viewColumnsReports.Name = "viewColumnsReports";
            this.viewColumnsReports.Size = new System.Drawing.Size(127, 13);
            this.viewColumnsReports.TabIndex = 3;
            this.viewColumnsReports.TabStop = true;
            this.viewColumnsReports.Text = "Ver reportes de columnas";
            this.viewColumnsReports.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewColumnsReports_LinkClicked);
            // 
            // linkToGraphs
            // 
            this.linkToGraphs.AutoSize = true;
            this.linkToGraphs.Location = new System.Drawing.Point(14, 55);
            this.linkToGraphs.Name = "linkToGraphs";
            this.linkToGraphs.Size = new System.Drawing.Size(95, 13);
            this.linkToGraphs.TabIndex = 2;
            this.linkToGraphs.TabStop = true;
            this.linkToGraphs.Text = "Cargar información";
            this.linkToGraphs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu de opciones";
            // 
            // mainPane
            // 
            this.mainPane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPane.Controls.Add(this.label1);
            this.mainPane.Location = new System.Drawing.Point(189, 12);
            this.mainPane.Name = "mainPane";
            this.mainPane.Size = new System.Drawing.Size(599, 426);
            this.mainPane.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 108);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver gráficos estadísticos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPane);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Suicide Overview Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPane.ResumeLayout(false);
            this.mainPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkToGraphs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel viewColumnsReports;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

