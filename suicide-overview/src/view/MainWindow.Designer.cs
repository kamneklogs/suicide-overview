
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tittleBar = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizedButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPane = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.riskSimulator = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.viewGraphs = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewColumnsReports = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tittleBar.SuspendLayout();
            this.mainPane.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tittleBar
            // 
            this.tittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tittleBar.Controls.Add(this.closeButton);
            this.tittleBar.Controls.Add(this.minimizedButton);
            this.tittleBar.Controls.Add(this.label4);
            resources.ApplyResources(this.tittleBar, "tittleBar");
            this.tittleBar.Name = "tittleBar";
            this.tittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TittleBar_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // minimizedButton
            // 
            this.minimizedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.minimizedButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minimizedButton.FlatAppearance.BorderSize = 0;
            this.minimizedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.minimizedButton, "minimizedButton");
            this.minimizedButton.Name = "minimizedButton";
            this.minimizedButton.UseVisualStyleBackColor = false;
            this.minimizedButton.Click += new System.EventHandler(this.MinimizedButton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Name = "label3";
            // 
            // mainPane
            // 
            this.mainPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.mainPane.Controls.Add(this.pictureBox1);
            this.mainPane.Controls.Add(this.label3);
            this.mainPane.Controls.Add(this.label1);
            resources.ApplyResources(this.mainPane, "mainPane");
            this.mainPane.Name = "mainPane";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.riskSimulator);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.viewGraphs);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.viewColumnsReports);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // riskSimulator
            // 
            this.riskSimulator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.riskSimulator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.riskSimulator.FlatAppearance.BorderSize = 0;
            this.riskSimulator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.riskSimulator, "riskSimulator");
            this.riskSimulator.ForeColor = System.Drawing.Color.White;
            this.riskSimulator.Name = "riskSimulator";
            this.riskSimulator.UseVisualStyleBackColor = false;
            this.riskSimulator.Click += new System.EventHandler(this.RiskSimulator_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // viewGraphs
            // 
            this.viewGraphs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.viewGraphs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewGraphs.FlatAppearance.BorderSize = 0;
            this.viewGraphs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.viewGraphs, "viewGraphs");
            this.viewGraphs.ForeColor = System.Drawing.Color.White;
            this.viewGraphs.Name = "viewGraphs";
            this.viewGraphs.UseVisualStyleBackColor = false;
            this.viewGraphs.Click += new System.EventHandler(this.ViewGraphs_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // viewColumnsReports
            // 
            this.viewColumnsReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.viewColumnsReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewColumnsReports.FlatAppearance.BorderSize = 0;
            this.viewColumnsReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.viewColumnsReports, "viewColumnsReports");
            this.viewColumnsReports.ForeColor = System.Drawing.Color.White;
            this.viewColumnsReports.Name = "viewColumnsReports";
            this.viewColumnsReports.UseVisualStyleBackColor = false;
            this.viewColumnsReports.Click += new System.EventHandler(this.ViewColumnsReports_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.mainPane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tittleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.TopMost = true;
            this.tittleBar.ResumeLayout(false);
            this.tittleBar.PerformLayout();
            this.mainPane.ResumeLayout(false);
            this.mainPane.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel tittleBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button minimizedButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel mainPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button riskSimulator;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button viewGraphs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button viewColumnsReports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

