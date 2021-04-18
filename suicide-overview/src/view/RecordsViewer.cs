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
    public partial class RecordsViewer : UserControl
    {
        private Loader loader;
        private MasterClass masterClass;
        public RecordsViewer()
        {
            //this.masterClass = masterClass;
            masterClass = new MasterClass();
            InitializeComponent();
            loadDataTable();
        }

        public void loadDataTable()
        {
            int index = 0;
            Dictionary<string, List<Record>> dictionary = masterClass.countries;

            foreach (string item in dictionary.Keys)
            {

                List<Record> records = masterClass.RecordsByCountry(item);

                for (int i = 0; i < records.Count; i++)
                {
                    Record record = records[i];
                    index = dataGridView1.Rows.Add();
                    //   dataTownGridRecord.Rows[index].Cells[0].Value = temp[0];
                    dataGridView1.Rows[index].Cells[0].Value = item;
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
        


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
