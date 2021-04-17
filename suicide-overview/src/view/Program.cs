using suicide_overview.src.model;
using System;
using System.Windows.Forms;

namespace suicide_overview
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            //INICIO DEL BLOQUE PARA PRUEBAS

            MasterClass mc = new MasterClass();

            //FINAL DEL BLOQUE PARA PRUEBAS

            Application.Run(new MainWindow());
        }
    }
}