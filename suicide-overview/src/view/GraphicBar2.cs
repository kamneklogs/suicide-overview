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
    public partial class GraphicBar2 : UserControl
    {
        private MasterClass mc;
        public GraphicBar2()
        {
            InitializeComponent();
            mc = new MasterClass();
        }

        private void viewGraphic_Click(object sender, EventArgs e)
        {
            string[] series = { country1.Text, country2.Text, country3.Text };
            int[] puntos = { mc.DeathsCountByGender("male",country1.Text), mc.DeathsCountByGender("male", country2.Text), mc.DeathsCountByGender("male",country3.Text) };

            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("Muertes de hombres a través de los años en los países " + country1.Text + ", " + country2.Text+ " y " + country3.Text );

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
