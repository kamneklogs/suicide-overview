using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Filters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace suicide_overview.src.model.AccordFramework_Bridge
{
    internal class AccordAdapter
    {
        private Dictionary<string, object> query;
        private DataTable data;
        private Codification codebook;
        private int[][] inputs;
        private int[] outputs;

        public AccordAdapter(string treeName, List<Dictionary<string, object>> setToTraining, Dictionary<string, int> variables)
        {
            data = new DataTable(treeName);

            foreach (string item in variables.Keys)
            {
                data.Columns.Add(item);
            }

            foreach (Dictionary<string, object> record in setToTraining)
            {
                ArrayList newRow = new ArrayList();

                foreach (string variableName in variables.Keys)
                {
                    object cell = record[variableName];

                    if (variables[variableName] == 0)
                    {
                        newRow.Add(Convert.ToDouble(cell));
                    }
                    else
                    {
                        newRow.Add((string)cell);
                    }
                }

                data.Rows.Add(newRow);
            }

            codebook = new Codification(data);
            DataTable symbols = codebook.Apply(data);

            string[] inputNames = new string[data.Columns.Count - 1];
            for (int i = 0; i < data.Columns.Count - 1; i++)
            {
                inputNames[i] = data.Columns[i].ColumnName;
            }

            inputs = symbols.ToJagged<int>(inputNames);
            outputs = symbols.ToArray<int>(data.Columns[data.Columns.Count - 1].ColumnName);
        }

        public void training()
        {
            DecisionVariable[] temp= DecisionVariable.FromCodebook(codebook);
            DecisionVariable[] preAttributes = new DecisionVariable[temp.Length-1];

            for (int i = 0;i < preAttributes.Length; i++)
            {
                preAttributes[i] = temp[i];
            }
            var id3learning = new ID3Learning(preAttributes)
{
    // Now that we already have our learning input/ouput pairs, we should specify our
    // decision tree. We will be trying to build a tree to predict the last column, entitled
    // “PlayTennis”. For this, we will be using the “Outlook”, “Temperature”, “Humidity” and
    // “Wind” as predictors (variables which will we will use for our decision). Since those
    // are categorical, we must specify, at the moment of creation of our tree, the
    // characteristics of each of those variables. So:

  
    new DecisionVariable("Outlook",     3), // 3 possible values (Sunny, overcast, rain)
    new DecisionVariable("Temperature", 3), // 3 possible values (Hot, mild, cool)
    new DecisionVariable("Humidity",    2), // 2 possible values (High, normal)
    new DecisionVariable("Wind",        2)  // 2 possible values (Weak, strong)

    // Note: It is also possible to create a DecisionVariable[] from a codebook:
    // DecisionVariable[] attributes = DecisionVariable.FromCodebook(codebook);

};
        }
    }
}