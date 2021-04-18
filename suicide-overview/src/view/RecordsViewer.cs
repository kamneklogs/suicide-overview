using suicide_overview.src.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace suicide_overview.src.view
{
    internal partial class RecordsViewer : UserControl
    {
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
            //dataGridView1.Rows.Clear();

            try
            {
                List<Record> records = masterClass.RecordsByCountry(CountryText.Text);

                for (int i = 0; i < records.Count; i++)
                {
                    if (maleButton.Checked == true && femaleButton.Checked == false)
                    {
                        if (records[i].Sex.Equals("female"))
                        {
                            records[i].ToAdd = false;
                        }
                    }

                    if (femaleButton.Checked == true && maleButton.Checked == false)
                    {
                        if (records[i].Sex.Equals("male"))
                        {
                            records[i].ToAdd = false;
                        }
                    }

                    if (!yearText.Text.Equals(""))
                    {
                        if (records[i].Year != Int32.Parse(yearText.Text))
                        {
                            records[i].ToAdd = false;
                        }
                    }

                    if (!generationText.Text.Equals(""))
                    {
                        if (!records[i].Generation.Equals(generationText.Text))
                        {
                            records[i].ToAdd = false;
                        }
                    }
                }

                int index;
                for (int i = 0; i < records.Count; i++)
                {
                    Record record = records[i];

                    if (record.ToAdd)
                    {
                        index = dataGridView1.Rows.Add();
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

                foreach (Record item in records)
                {
                    item.ToAdd = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetDataSet(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            maleButton.Checked = false;
            femaleButton.Checked = false;
            generationText.Text = "";
            yearText.Text = "";
            loadDataTable(CountryText.Text);
        }
    }
}