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
    public partial class Graphs : UserControl
    {
        public Graphs()
        {

        }

        private void viewBarGraphic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewGraphic.Controls.Clear();
            GraphicBar1 gb = new GraphicBar1();
            viewGraphic.Controls.Add(gb);
          
        }
    }
}
