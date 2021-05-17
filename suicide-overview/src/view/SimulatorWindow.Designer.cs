
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select country";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(167, 105);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 4;
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.ForeColor = System.Drawing.Color.White;
            this.femaleRB.Location = new System.Drawing.Point(479, 86);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(59, 17);
            this.femaleRB.TabIndex = 5;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "Female";
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.ForeColor = System.Drawing.Color.White;
            this.maleRB.Location = new System.Drawing.Point(479, 110);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(48, 17);
            this.maleRB.TabIndex = 6;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "Male";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(176, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(311, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Generation";
            // 
            // runSimulation
            // 
            this.runSimulation.Location = new System.Drawing.Point(206, 241);
            this.runSimulation.Name = "runSimulation";
            this.runSimulation.Size = new System.Drawing.Size(140, 23);
            this.runSimulation.TabIndex = 9;
            this.runSimulation.Text = "Run simulation";
            this.runSimulation.UseVisualStyleBackColor = true;
            this.runSimulation.Click += new System.EventHandler(this.executeSimulation);
            // 
            // countries
            // 
            this.countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countries.FormattingEnabled = true;
            this.countries.Location = new System.Drawing.Point(20, 105);
            this.countries.Name = "countries";
            this.countries.Size = new System.Drawing.Size(121, 21);
            this.countries.TabIndex = 10;
            // 
            // generation
            // 
            this.generation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generation.FormattingEnabled = true;
            this.generation.Location = new System.Drawing.Point(299, 104);
            this.generation.Name = "generation";
            this.generation.Size = new System.Drawing.Size(121, 21);
            this.generation.TabIndex = 11;
            // 
            // SimulatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.Name = "SimulatorWindow";
            this.Size = new System.Drawing.Size(599, 456);
            this.Load += new System.EventHandler(this.SimulatorWindow_Load);
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
    }
}
