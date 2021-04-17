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

            Console.WriteLine("Casos de suicidio de hombres en todo el mundo: " + mc.DeathsCountByGender("male"));
            Console.WriteLine("Casos de suicidio de mujeres en todo el mundo: " + mc.DeathsCountByGender("female"));

            Console.WriteLine("");
            Console.WriteLine("Casos de suicidio de hombres en Colombia: " + mc.DeathsCountByGender("male", "Colombia"));
            Console.WriteLine("Casos de suicidio de mujeres en Colombia: " + mc.DeathsCountByGender("female", "Colombia"));

            //FINAL DEL BLOQUE PARA PRUEBAS

            Application.Run(new MainWindow());
        }
    }
}