using suicide_overview.src.model;
using suicide_overview.src.model.DecisionTreeClassifier;
using System;
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
            MasterClass mc = new MasterClass();

            List<Record> records = mc.RecordsByCountry("Republic of Korea");

            List<Dictionary<string, object>> setToTraining = new List<Dictionary<string, object>>();

            for (int i = 0; i < records.Count; i++)
            {
                setToTraining.Add(records[i].getData());
            }

            Dictionary<string, int> variables = new Dictionary<string, int>();

            variables.Add("Year", 0);
            variables.Add("Sex", 1);
            variables.Add("Generation", 1);

            Tree myTree = new Tree(variables, "Risk");

            myTree.training(setToTraining);

            Dictionary<string, double> p = myTree.Classifier(new Dictionary<string, object>() { { "Year", 2017 }, { "Sex", "male" }, { "Generation", "Millenials" } });

            foreach (string item in p.Keys)
            {
                Console.WriteLine("Probabilidad de riesgo " + item + ": " + (p[item] * 100) + "%");
            }

            //        Application.EnableVisualStyles();
            //          Application.SetCompatibleTextRenderingDefault(true);

            //            Application.Run(new MainWindow());
        }
    }
}