using System;
using System.IO;
using System.Windows.Forms;

namespace suicide_overview.src.model
{
    internal class Loader
    {
        private string Path;

        public void LoadData(int n)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            int count = 0;

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {
                try
                {
                    Path = openFileDialog.FileName;

                    var sr = new StreamReader(Path);

                    string s = sr.ReadLine();
                    s = sr.ReadLine();
                    string[] temp = null;


                    while (s != null && count < n)
                    {
                        temp = s.Split(',');

                        s = sr.ReadLine(); 

                        //COdigo para sacar registro

                        count++;

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