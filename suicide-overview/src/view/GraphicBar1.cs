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
using System.Windows.Forms.DataVisualization.Charting;

namespace suicide_overview.src.view
{
    public partial class GraphicBar1 : UserControl
    {
        private MasterClass mc;
        public GraphicBar1()
        {
            InitializeComponent();
            mc = new MasterClass();
        }

        private void graphicBar_Load(object sender, EventArgs e)
        {
            string[] series = { "Mujer", "Hombre" };
            int[] puntos = { mc.DeathsCountByGender("female"), mc.DeathsCountByGender("male") };

            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("Muertes de hombres y mujeres a través de los años a nivel mundial");

            for(int i=0; i < series.Length; i++)
            {
                //titulos
                Series sr = chart1.Series.Add(series[i]);

                //cantidades
                sr.Label = puntos[i].ToString();

                sr.Points.Add( puntos[i]);
            }
        }
    }
}
