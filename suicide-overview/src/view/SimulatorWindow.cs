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
    internal partial class SimulatorWindow : UserControl
    {

        MasterClass mc;

        public SimulatorWindow(MasterClass mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void executeSimulation(object sender, EventArgs e)
        {
            MessageBox.Show("Hace algo");
        }
    }
}
