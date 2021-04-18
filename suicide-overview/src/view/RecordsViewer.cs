using suicide_overview.src.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace suicide_overview.src.view
{
    internal partial class RecordsViewer : UserControl
    {
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

        private void RunLoadTable_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            loadDataTable(CountryToLoadText.Text);
        }

        // filtro paises 
        /*
        private void country_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
			{
                if(!(dataGridView1.Rows[i].cell[0].equals(country))){
                    dataGridView1.Rows.Remove(i);
                }
			}

        }

        private void Year_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
			{
                int year = yearText.Text;
                if(dataGridView1.Rows[i].cell[0] != year){
                    dataGridView1.Rows.Remove(i);
                }
			}

        }

        private void Sex_Click(object sender, EventArgs e)
        {
            TextBox sexTex;
            String sex =  sexTex.Text;

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
			{
                int year = yearText.Text;
                if(dataGridView1.Rows[i].cell[0] != year){
                    dataGridView1.Rows.Remove(i);
                }
			}

        }

        private void age_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
			{
                int year = yearText.Text;
                if(dataGridView1.Rows[i].cell[0] != year){
                    dataGridView1.Rows.Remove(i);
                }
			}

        }
        */
    }
}