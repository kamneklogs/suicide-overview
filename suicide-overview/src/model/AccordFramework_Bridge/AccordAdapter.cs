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
        private DecisionTree decisionTree;

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
                DataRow dataRowNew = data.NewRow();

                for (int i = 0; i < data.Columns.Count; i++)
                {
                    dataRowNew[data.Columns[i].ColumnName] = newRow[i];
                }

                data.Rows.Add(dataRowNew);
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

            foreach (DataRow dataRow in data.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
        }

        public void Training()
        {
            string[] columns = new string[data.Columns.Count];

            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = data.Columns[i].ColumnName;
            }

            DecisionVariable[] temp = DecisionVariable.FromCodebook(codebook, columns);
            DecisionVariable[] preAttributes = new DecisionVariable[temp.Length - 1];

            for (int i = 0; i < preAttributes.Length; i++)
            {
                preAttributes[i] = temp[i];
            }

            var id3learning = new ID3Learning() { };
            decisionTree = id3learning.Learn(inputs, outputs);
        }

        public void Simulate(ArrayList query)
        {

            //verificar posible error en codebook

            string[,] queryMatrix = new string[query.Count, 2];

            for (int i = 0; i < data.Columns.Count - 1; i++)
            {
                queryMatrix[i, 0] = data.Columns[i].ColumnName;
                queryMatrix[i, 1] = (string)query[i];
            }
            int[] queryInt = codebook.Transform(new[,]
             {
                { "Outlook",     "Sunny"  },
                { "Temperature", "Hot"    },
                { "Humidity",    "High"   },
                { "Wind",        "Strong" }
            });

            int predicted = decisionTree.Decide(queryInt);  // result will be 0

            // We can translate it back to strings using
            string answer = codebook.Revert("PlayTennis", predicted); // Answer will be: "No"

            Console.WriteLine(answer);



            int inds = 18;
        }
    }
}