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
    internal partial class GraphicDonnut1 : UserControl
    {
        public MasterClass mc;
        public GraphicDonnut1(MasterClass mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void viewGraphic_Click(object sender, EventArgs e)
        {
            chart1.Titles.Add("Suicidios del país " + country.Text + " en los  años " + year1.Text + ", " + year2.Text + " y " + year3.Text);
            chart1.Series["s1"].Points.AddXY(country.Text + "en "+ year1.Text,mc.DeathsCountByCountry(country.Text, Int32.Parse(year1.Text)));
            chart1.Series["s1"].Points.AddXY(country.Text + "en " + year2.Text, mc.DeathsCountByCountry(country.Text, Int32.Parse(year2.Text)));
            chart1.Series["s1"].Points.AddXY(country.Text + "en " + year3.Text, mc.DeathsCountByCountry(country.Text, Int32.Parse(year3.Text)));


        }
    }
}
