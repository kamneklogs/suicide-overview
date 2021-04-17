using System;
using System.IO;
using System.Windows.Forms;

namespace suicide_overview.src.model
{
    internal class Loader
    {
        private string Path;
        
        public Loader()
        {

        }

        public void LoadData()
        {
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

                        s = sr.ReadLine();

                        //COdigo para sacar registro 0,1,2,3,4,5,6, arr.le-1

                       

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