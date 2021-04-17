using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suicide_overview.src.model
{
    class Loader
    {
        private string path;


        public void loadData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    path = openFileDialog.FileName;

                    var sr = new StreamReader(path);

                    string s = sr.ReadLine();
                    s = sr.ReadLine();
                    string[] temp = null;

                    while (s != null)
                    {
                        temp = s.Split(',');

                       
                       

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
