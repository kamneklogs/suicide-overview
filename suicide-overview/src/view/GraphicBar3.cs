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
            try
            {
                if (!String.IsNullOrEmpty(country.Text))
                {
                    viewGraphic.Enabled = false;
                    country.Enabled = false;
                    clearBtn.Enabled = true;
                    string[] series = { "Silent Generation", "G.I. Generation", "Boomers", "Millenials", "Generation  X" };
                    int[] puntos = {mc.DeathsCountByGeneration("Silent", country.Text), mc.DeathsCountByGeneration("G.I. Generation", country.Text),
                mc.DeathsCountByGeneration("Boomers", country.Text), mc.DeathsCountByGeneration("Millenials", country.Text),
                mc.DeathsCountByGeneration("Generation X", country.Text)};

                    chart1.Titles.Add("Suicides of generations in the country " + country.Text);

                    for (int i = 0; i < series.Length; i++)
                    {
                        Series sr = chart1.Series.Add(series[i]);

                        sr.Label = puntos[i].ToString();

                        sr.Points.Add(puntos[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the field!");
                }
            }catch(Exception exc)
            {
                clearBtn.Enabled = false;
                viewGraphic.Enabled = true;
                country.Enabled = true;
                
                MessageBox.Show("The country you have wrote is not in the data base, make  sure you it is well written.");
                
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearBtn.Enabled = false;
            viewGraphic.Enabled = true;
            country.Enabled = true;
            country.Text = "";
            chart1.Series.Clear();
            chart1.Titles.Clear();
        }
    }
}
