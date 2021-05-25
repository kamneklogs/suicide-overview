using suicide_overview.src.model;
using System;
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
            string result = "";
            if (comboBox1.SelectedItem.Equals("Own implementation"))
            {
                result = mc.simulateSuicideRisk_OwnImplementation((string)countries.SelectedItem, Convert.ToInt32(year.Text), (string)generation.SelectedItem, maleRB.Checked ? "male" : "female");
            } else if (comboBox1.SelectedItem.Equals("External implementation"))
            {
                result = mc.simulateSuicideRisk_AccordImplementation((string)countries.SelectedItem, Convert.ToInt32(year.Text), (string)generation.SelectedItem, maleRB.Checked ? "male" : "female");
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