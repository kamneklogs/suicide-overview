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

    internal partial class GraphicPie1 : UserControl
    {
        private MasterClass mc;
        public GraphicPie1(MasterClass mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void viewGraphic_Click(object sender, EventArgs e)
        {
            try {
                if (!String.IsNullOrEmpty(country1.Text) && !String.IsNullOrEmpty(country2.Text) && !String.IsNullOrEmpty(country3.Text))
                {
                    viewGraphic.Enabled = false;
                    country1.Enabled = false;
                    country2.Enabled = false;
                    country3.Enabled = false;
                    clearBtn.Enabled = true;
                    chart1.Titles.Add("Female suicides of the countries " + country1.Text + ", " + country2.Text + " and " + country3.Text);
                    chart1.Series["s1"].IsValueShownAsLabel = true;
                    chart1.Series["s1"].Points.AddXY(country1.Text, mc.DeathsCountByGender("female", country1.Text));
                    chart1.Series["s1"].Points.AddXY(country2.Text, mc.DeathsCountByGender("female", country2.Text));
                    chart1.Series["s1"].Points.AddXY(country3.Text, mc.DeathsCountByGender("female", country3.Text));
                }
                else
                {
                    MessageBox.Show("One of the fields is empty. Please  enter all the countries");
                }
            } catch (Exception exc)
            {
                MessageBox.Show("Make sure the countries you entered are well written ");
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            viewGraphic.Enabled = true;
            country1.Enabled = true;
            country2.Enabled = true;
            country3.Enabled = true;
            country1.Text = "";
            country2.Text = "";
            country3.Text = "";
            chart1.Series.Clear();
            chart1.Titles.Clear();
        }
    }
}
