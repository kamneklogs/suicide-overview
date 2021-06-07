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

                        int year = Int32.Parse(temp[1]);
                        string sex = temp[2];
                        int ageLower;
                        int ageUpper;

                        string[] age = temp[3].Split(' ');

                        if (age[0].Contains("-"))
                        {
                            string[] ageT = age[0].Split('-');
                            ageLower = Int32.Parse(ageT[0]);
                            ageUpper = Int32.Parse(ageT[1]);
                        }
                        else
                        {
                            ageLower = Int32.Parse(age[0].Substring(0, age[0].Length - 2));
                            ageUpper = 150;
                        }

                        int suicide_no = Int32.Parse(temp[4]);
                        int population = Int32.Parse(temp[5]); ;
                        double ratio = Convert.ToDouble(temp[6]);

                        string generation = temp[temp.Length - 1];

                        Record record = new Record(year, sex, ageLower, ageUpper, suicide_no, population, ratio, generation);
                        if (countries.ContainsKey(temp[0]) && !temp[0].Equals("Austria") && !temp[0].Equals("Iceland") && !temp[0].Equals("Mauritius") && !temp[0].Equals("Netherlands"))
                        {
                           

                               countries[temp[0]].Add(record);
                        }
                        else
                        {
                            if (!temp[0].Equals("Austria") && !temp[0].Equals("Iceland")&& !temp[0].Equals("Mauritius") && !temp[0].Equals("Netherlands"))
                            {
                                countries.Add(temp[0], new List<Record>());
                                countries[temp[0]].Add(record);
                            }
                        }

                        //Codigo para sacar registro 0,1,2,3,4,5,6, arr.le-1
                        s = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}