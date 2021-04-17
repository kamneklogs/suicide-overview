using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace suicide_overview.src.model
{
    internal class Loader
    {
        public static void LoadData(Dictionary<string, List<Record>> countries)
        {
            string Path;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {
                try
                {
                    Path = openFileDialog.FileName;

                    var sr = new StreamReader(Path);

                    string s = sr.ReadLine();
                    s = sr.ReadLine();
                    string[] temp = null;

                    while (s != null)
                    {
                        temp = s.Split(',');

                        Record record = new Record(temp[1], temp[2], temp[3], temp[4], Int32.Parse(temp[5]), Int32.Parse(temp[6]), Convert.ToDouble(temp[7]), temp[temp.Length - 1]);
                        if (countries.ContainsKey(temp[0]))
                        {
                            countries[temp[0]].Add(record);
                        }
                        else
                        {
                            countries.Add(temp[0], new List<Record>());
                            countries[temp[0]].Add(record);
                        }

                        //Codigo para sacar registro 0,1,2,3,4,5,6, arr.le-1
                        s = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la carga de los datos");
                }
            }
        }
    }
}