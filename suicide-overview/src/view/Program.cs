﻿using suicide_overview.src.model.DecisionTreeClassifier;
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


            //Para prueba
            List<Dictionary<string, object>> setToTraining = new List<Dictionary<string, object>>();
          
            setToTraining.Add(new Dictionary<string, object>() { { "color", "Green" }, { "diameter", 3 }, { "label", "Apple" } });
            setToTraining.Add(new Dictionary<string, object>() { { "color", "Yellow" }, { "diameter", 3 }, { "label", "Apple" } });
            setToTraining.Add(new Dictionary<string, object>() { { "color", "Red" }, { "diameter", 1 }, { "label", "Grape" } });
            setToTraining.Add(new Dictionary<string, object>() { { "color", "Red" }, { "diameter", 1 }, { "label", "Grape" } });
            setToTraining.Add(new Dictionary<string, object>() { { "color", "Yellow" }, { "diameter", 3 }, { "label", "Lemon" } });
            setToTraining.Add(new Dictionary<string, object>() { { "color", "Yellow" }, { "diameter", 1 }, { "label", "Lemon" } });

            Dictionary<string, int> variables = new Dictionary<string, int>();
            variables.Add("color", 1);
            variables.Add("diameter", 0);

            Tree myTree = new Tree(variables, "label");

            myTree.training(setToTraining);

            Dictionary<string, double> p = myTree.Classifier(new Dictionary<string, object>() { { "color", "Yellow" }, { "diameter", 1 } });

            Console.WriteLine("Probabilidad de limon "+p["Lemon"]);
            Console.WriteLine("Probabilidad de manzana " + p["Apple"]);
            Console.WriteLine("Probabilidad de uva " + p["Grape"]);

            myTree.printTree();

            Console.ReadLine();

            //        Application.EnableVisualStyles();
            //          Application.SetCompatibleTextRenderingDefault(true);

            //            Application.Run(new MainWindow());
        }
    }
}