using suicide_overview.src.model;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace suicide_overview.src.view
{
    internal partial class GraphicBar1 : UserControl
    {
        private MasterClass mc;

        public GraphicBar1(MasterClass mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void graphicBar_Load(object sender, EventArgs e)
        {
            string[] series = { "Mujer", "Hombre" };
            int[] puntos = { mc.DeathsCountByGender("female"), mc.DeathsCountByGender("male") };

            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("Muertes de hombres y mujeres a través de los años a nivel mundial");

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series sr = chart1.Series.Add(series[i]);
                
                //cantidades
                sr.Label = puntos[i].ToString();

                sr.Points.Add(puntos[i]);
            }
        }
    }
}