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
    internal partial class Graphs : UserControl
    {
        MasterClass mc;
        public Graphs(MasterClass mc)
        {
            InitializeComponent();

            this.mc = mc;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            graphViewer.Controls.Clear();
          GraphicBar1 gb = new GraphicBar1(mc);

            graphViewer.Controls.Add(gb);
        }

        private void graphic2_Click(object sender, EventArgs e)
        {
            graphViewer.Controls.Clear();
            GraphicBar2 gb = new GraphicBar2(mc);
            graphViewer.Controls.Add(gb);
        }

        private void graphic3_Click(object sender, EventArgs e)
        {
            graphViewer.Controls.Clear();
            GraphicPie1 gp = new GraphicPie1(mc);
            graphViewer.Controls.Add(gp);
        }

        private void graphic4_Click(object sender, EventArgs e)
        {
            graphViewer.Controls.Clear();
            GraphicDonnut1 gd = new GraphicDonnut1(mc);
            graphViewer.Controls.Add(gd);
        }

        private void graphic5_Click(object sender, EventArgs e)
        {
            graphViewer.Controls.Clear();
            GraphicBar3 gb3 = new GraphicBar3(mc);
            graphViewer.Controls.Add(gb3);
     
        }
    }
}
