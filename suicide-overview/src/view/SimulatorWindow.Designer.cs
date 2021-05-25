
namespace suicide_overview.src.view
{
    partial class SimulatorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatorWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.runSimulation = new System.Windows.Forms.Button();
            this.countries = new System.Windows.Forms.ComboBox();
            this.generation = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 589);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select country";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(374, 639);
            this.year.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(196, 31);
            this.year.TabIndex = 4;
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.ForeColor = System.Drawing.Color.White;
            this.femaleRB.Location = new System.Drawing.Point(572, 744);
            this.femaleRB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(114, 29);
            this.femaleRB.TabIndex = 5;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "Female";
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.ForeColor = System.Drawing.Color.White;
            this.maleRB.Location = new System.Drawing.Point(762, 744);
            this.maleRB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(90, 29);
            this.maleRB.TabIndex = 6;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "Male";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(437, 589);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(734, 589);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Generation";
            // 
            // runSimulation
            // 
            this.runSimulation.Location = new System.Drawing.Point(572, 843);
            this.runSimulation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.runSimulation.Name = "runSimulation";
            this.runSimulation.Size = new System.Drawing.Size(280, 44);
            this.runSimulation.TabIndex = 9;
            this.runSimulation.Text = "Run simulation";
            this.runSimulation.UseVisualStyleBackColor = true;
            this.runSimulation.Click += new System.EventHandler(this.executeSimulation);
            // 
            // countries
            // 
            this.countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countries.FormattingEnabled = true;
            this.countries.Location = new System.Drawing.Point(53, 639);
            this.countries.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.countries.Name = "countries";
            this.countries.Size = new System.Drawing.Size(238, 33);
            this.countries.TabIndex = 10;
            // 
            // generation
            // 
            this.generation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generation.FormattingEnabled = true;
            this.generation.Location = new System.Drawing.Point(675, 639);
            this.generation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.generation.Name = "generation";
            this.generation.Size = new System.Drawing.Size(238, 33);
            this.generation.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(516, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1014, 639);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1050, 589);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Implementation";
            // 
            // SimulatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generation);
            this.Controls.Add(this.countries);
            this.Controls.Add(this.runSimulation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SimulatorWindow";
            this.Size = new System.Drawing.Size(1380, 1000);
            this.Load += new System.EventHandler(this.SimulatorWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button runSimulation;
        private System.Windows.Forms.ComboBox countries;
        private System.Windows.Forms.ComboBox generation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}
