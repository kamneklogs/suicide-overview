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
            try
            {
                if (!String.IsNullOrEmpty(country.Text) && !String.IsNullOrEmpty(year1.Text) && !String.IsNullOrEmpty(year2.Text) && !String.IsNullOrEmpty(year3.Text))
                {
                    if (!(Int32.Parse(year1.Text) < 1985) && !(Int32.Parse(year1.Text) > 2016) && !(Int32.Parse(year2.Text) < 1985) && !(Int32.Parse(year2.Text) > 2016)
                      &&  !(Int32.Parse(year3.Text) < 1985) && !(Int32.Parse(year3.Text) > 2016))
                    {
                        viewGraphic.Enabled = false;
                        year1.Enabled = false;
                        year2.Enabled = false;
                        year3.Enabled = false;
                        country.Enabled = false;
                        clearBtn.Enabled = true;
                        chart1.Titles.Add("Suicides of the country " + country.Text + " in the years " + year1.Text + ", " + year2.Text + " and " + year3.Text);
                        chart1.Series["s1"].Points.AddXY(country.Text + "in " + year1.Text, mc.DeathsCountByCountry(country.Text, Int32.Parse(year1.Text)));
                        chart1.Series["s1"].Points.AddXY(country.Text + "in " + year2.Text, mc.DeathsCountByCountry(country.Text, Int32.Parse(year2.Text)));
                        chart1.Series["s1"].Points.AddXY(country.Text + "in " + year3.Text, mc.DeathsCountByCountry(country.Text, Int32.Parse(year3.Text)));
                    }
                    else
                    {
                        MessageBox.Show("One of the years you entered is out of range. Please make sure they are between 1985 and 2016!");
                    }
                }
                else
                {
                    MessageBox.Show("One of the fields is empty. Please fill all the fields");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Make sure the country you entered is well written");
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            viewGraphic.Enabled = true;
            year1.Enabled = true;
            year2.Enabled = true;
            year3.Enabled = true;
            year1.Text = "";
            year2.Text = "";
            year3.Text = "";
            country.Text = "";
            country.Enabled = true;
            clearBtn.Enabled = false;
            chart1.Series.Clear();
            chart1.Titles.Clear();
        }
    }
}
