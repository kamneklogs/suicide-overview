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
   internal partial class GraphicBar3 : UserControl
    {
        private MasterClass mc;
        public GraphicBar3(MasterClass mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void viewGraphic_Click(object sender, EventArgs e)
        {
            string[] series = { "Silent Generation", "G.I. Generation", "Boomers", "Millenials", "Generación X" };
            int[] puntos;

        }
    }
}
