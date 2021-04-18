﻿using suicide_overview.src.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace suicide_overview.src.view
{
    internal partial class RecordsViewer : UserControl
    {
        private const String GeX = "Generation X";
        private const String Sil = "Silent";
        private const String Boo = "Boomers";
        private const String GIG = "G.I. Generation";
        private const String Mil = "Millenials";

        private Loader loader;
        private MasterClass masterClass;

        public RecordsViewer(MasterClass masterClass)
        {
            //this.masterClass = masterClass;
            this.masterClass = masterClass;
            InitializeComponent();
        }

        public void loadDataTable(string country)
        {
            int index = 0;
            Dictionary<string, List<Record>> dictionary = masterClass.countries;

            List<Record> records = masterClass.RecordsByCountry(country);

            for (int i = 0; i < records.Count; i++)
            {
                Record record = records[i];
                index = dataGridView1.Rows.Add();
                //   dataTownGridRecord.Rows[index].Cells[0].Value = temp[0];
                dataGridView1.Rows[index].Cells[0].Value = country;
                dataGridView1.Rows[index].Cells[1].Value = record.Year;
                dataGridView1.Rows[index].Cells[2].Value = record.AgeLower;
                dataGridView1.Rows[index].Cells[3].Value = record.AgeUpper;
                dataGridView1.Rows[index].Cells[4].Value = record.Generation;
                dataGridView1.Rows[index].Cells[5].Value = record.Sex;
                dataGridView1.Rows[index].Cells[6].Value = record.Suicide_no;
                dataGridView1.Rows[index].Cells[7].Value = record.Population;
                dataGridView1.Rows[index].Cells[8].Value = record.Ratio;
            }
        }

        private void loadFilters(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            loadDataTable(CountryText.Text);

            if (!(yearText.Text == ""))
            {
                YearOption();
            }

            if (!(ageTextInf.Text == "") && !(ageTextSup.Text == ""))
            {
                AgeOption();
            }

            if ((maleButton.Checked) || (femaleButton.Checked))
            {
                GenderOption();
            }

            if (!(generationText.Text == ""))
            {
                GenerationOption();
            }
        }

        public void GenerationOption()
        {
            try
            {
                if ((generationText.Text).Equals(Boo))
                {
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (!(dataGridView1.Rows[i].Cells[5]).Equals(Boo))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        }
                    }
                }
                else if ((generationText.Text).Equals(GeX))
                {
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (!(dataGridView1.Rows[i].Cells[5]).Equals(GeX))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        }
                    }
                }
                else if ((generationText.Text).Equals(Sil))
                {
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (!(dataGridView1.Rows[i].Cells[5]).Equals(Sil))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        }
                    }
                }
                else if ((generationText.Text).Equals(GIG))
                {
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (!(dataGridView1.Rows[i].Cells[5]).Equals(GIG))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        }
                    }
                }
                else if ((generationText.Text).Equals(Mil))
                {
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (!(dataGridView1.Rows[i].Cells[5]).Equals(Mil))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select one of the options that is in the arrow of the text box.");
            }
        }

        public void GenderOption()
        {
            try
            {
                dataGridView1.Rows.Clear();

                int index = 0;

                foreach (Record record in masterClass.RecordsByCountry(CountryText.Text))
                {
                    index = dataGridView1.Rows.Add();

                    if (maleButton.Checked && !femaleButton.Checked)
                    {
                        if (record.Sex.Equals("male"))
                        {
                            dataGridView1.Rows[index].Cells[0].Value = CountryText.Text;
                            dataGridView1.Rows[index].Cells[1].Value = record.Year;
                            dataGridView1.Rows[index].Cells[2].Value = record.AgeLower;
                            dataGridView1.Rows[index].Cells[3].Value = record.AgeUpper;
                            dataGridView1.Rows[index].Cells[4].Value = record.Generation;
                            dataGridView1.Rows[index].Cells[5].Value = record.Sex;
                            dataGridView1.Rows[index].Cells[6].Value = record.Suicide_no;
                            dataGridView1.Rows[index].Cells[7].Value = record.Population;
                            dataGridView1.Rows[index].Cells[8].Value = record.Ratio;
                        }
                    }
                    if (femaleButton.Checked && !maleButton.Checked)
                    {
                        if (record.Sex.Equals("female"))
                        {
                            dataGridView1.Rows[index].Cells[0].Value = CountryText.Text;
                            dataGridView1.Rows[index].Cells[1].Value = record.Year;
                            dataGridView1.Rows[index].Cells[2].Value = record.AgeLower;
                            dataGridView1.Rows[index].Cells[3].Value = record.AgeUpper;
                            dataGridView1.Rows[index].Cells[4].Value = record.Generation;
                            dataGridView1.Rows[index].Cells[5].Value = record.Sex;
                            dataGridView1.Rows[index].Cells[6].Value = record.Suicide_no;
                            dataGridView1.Rows[index].Cells[7].Value = record.Population;
                            dataGridView1.Rows[index].Cells[8].Value = record.Ratio;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AgeOption()
        {
            try
            {
                int nInf = Convert.ToInt32(ageTextInf.Text);
                int nSup = Convert.ToInt32(ageTextSup);
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (!(Convert.ToInt32(dataGridView1.Rows[i].Cells[3]) == nInf)
                        && !(Convert.ToInt32(dataGridView1.Rows[i].Cells[4]) == nSup))
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must enter numbers in this text boxs");
            }
        }

        public void YearOption()
        {
            try
            {
                int n = Convert.ToInt32(yearText.Text);
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2]) != n)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must enter numbers in this text box");
            }
        }

        private void resetDataSet(object sender, EventArgs e)
        {
            loadDataTable(CountryText.Text);
        }
    }
}