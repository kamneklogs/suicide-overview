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

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            mc.GenerateCSV(saveFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
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
