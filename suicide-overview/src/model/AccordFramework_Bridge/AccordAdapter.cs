﻿using Accord.MachineLearning.DecisionTrees;
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

        public void Training()
        {
            DecisionVariable[] temp= DecisionVariable.FromCodebook(codebook);
            DecisionVariable[] preAttributes = new DecisionVariable[temp.Length-1];

            for (int i = 0;i < preAttributes.Length; i++)
            {
                preAttributes[i] = temp[i];
            }
            var id3learning = new ID3Learning(){ };
            DecisionTree decisionTree = id3learning.Learn(inputs, outputs);
        }

        public void Simulate(ArrayList query)
        {
            object[,] queryMatrix = new object[2,query.Count];

            for (int i = 0; i < data.Columns.Count-1; i++)
            {
                queryMatrix[0, i] = data.Columns[i].ColumnName;
                queryMatrix[1, i] = query[i];
            }

        }

    }
}