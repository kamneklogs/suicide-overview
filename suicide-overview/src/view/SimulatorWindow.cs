using suicide_overview.src.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace suicide_overview.src.view
{
    internal partial class SimulatorWindow : UserControl
    {
        private MasterClass mc;

        public SimulatorWindow(MasterClass mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void executeSimulation(object sender, EventArgs e)
        {
            Dictionary<string, double> probabilities = mc.simulateSuicideRisk((string)countries.SelectedItem, Convert.ToInt32(year.Text), (string)generation.SelectedItem, maleRB.Checked ? "male" : "female");

            string result = "";

            foreach (string lr in probabilities.Keys)
            {
                result += lr + " probability: " + (probabilities[lr] * 100.0) + "%\n";
            }

            MessageBox.Show(result);
        }

        private void SimulatorWindow_Load(object sender, EventArgs e)
        {
            countries.Items.AddRange(mc.getAllCountries().ToArray());

            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(year, "Valid range 1985-2016");

            generation.Items.AddRange(mc.GENERATIONS);
            //generation.
        }
    }
}