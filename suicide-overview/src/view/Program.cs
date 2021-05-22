using suicide_overview.src.model.AccordFramework_Bridge;
using System;
using System.Collections;
using System.Collections.Generic;

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
            List<Dictionary<string, object>> setToTraining = new List<Dictionary<string, object>>();
            setToTraining.Add(new Dictionary<string, object>() { { "Day", "D1" }, { "Outlook", "Sunny" }, { "Temperature", "High" }, { "Humidity", "Weak" }, { "PlayTennis", "no" } });

            setToTraining.Add(new Dictionary<string, object>() { { "Day", "D2" }, { "Outlook", "Rain" }, { "Temperature", "High" }, { "Humidity", "Weak" }, { "PlayTennis", "no" } });

            setToTraining.Add(new Dictionary<string, object>() { { "Day", "D3" }, { "Outlook", "Sunny" }, { "Temperature", "Normal" }, { "Humidity", "Weak" }, { "PlayTennis", "si" } });

            setToTraining.Add(new Dictionary<string, object>() { { "Day", "D4" }, { "Outlook", "Sunny" }, { "Temperature", "High" }, { "Humidity", "Strong" }, { "PlayTennis", "si" } });

            Dictionary<string, int> variables = new Dictionary<string, int>();
            variables.Add("Day", 1);
            variables.Add("Outlook", 1);
            variables.Add("Temperature", 1);
            variables.Add("Humidity", 1);
            variables.Add("PlayTennis", 1);

            AccordAdapter ac = new AccordAdapter("Juego de tenis", setToTraining, variables);

            ac.Training();

            ArrayList query = new ArrayList();

            query.Add("Hot");
            query.Add("High");
            query.Add("Hot");
            query.Add("Strong");

           // ac.Simulate(query); ERROR HERE

            //     Application.EnableVisualStyles();
            //   Application.SetCompatibleTextRenderingDefault(true);
            // Application.Run(new MainWindow());

            //A partir de este momento estamos en development

            //Ya estamos en la rama AccordImplementation

            //Ya tenemos accord
        }
    }
}