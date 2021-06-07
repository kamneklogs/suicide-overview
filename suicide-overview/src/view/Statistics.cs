using suicide_overview.src.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suicide_overview.src.view
{
    internal partial class Statistics : UserControl
    {
        private MasterClass mc;

        public Statistics(MasterClass mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void exportToCSVFile(object sender, EventArgs e)
        {
            SaveFileDialog saveCSVDialog = new SaveFileDialog();
            saveCSVDialog.Filter = "CSV file|*.csv";
            saveCSVDialog.Title = "Save an CSV";
            saveCSVDialog.ShowDialog();

            if (saveCSVDialog.FileName != "")
            {
                MessageBox.Show("File generated and saved succesfully in " +saveCSVDialog.FileName);
                mc.GenerateCSV(saveCSVDialog.FileName);

            }
            else
            {
                MessageBox.Show("You didn't select a valid directory");
            }
           
        }

        private void generateTableWithProbabilities(object sender, EventArgs e)
        {
             List<string> probabilities =  mc.GetProbabilitiesAllTrees();

            int index = 0;

            for (int i = 0; i < probabilities.Count; i++)
            {
                string prob = probabilities[i];
                string[] temp = prob.Split(';');
                index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = temp[0];
                dataGridView1.Rows[index].Cells[1].Value = temp[1];
                dataGridView1.Rows[index].Cells[2].Value = temp[2];
            }


        }
    }
}
