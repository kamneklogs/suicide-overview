using System;
using System.Collections.Generic;

namespace suicide_overview.src.model.DecisionTreeClassifier
{
    internal class Tree
    {
        private List<Dictionary<string, Object>> values;

        private Node root;

        private Dictionary<string, int> variables;

        public string targetVariableName { get; set; }

        public Tree(Dictionary<string, int> variables, string targetVariableName)
        {
            this.variables = variables;

            this.targetVariableName = targetVariableName;
        }

        public void training(List<Dictionary<string, Object>> values)
        {
            this.values = values;

            HashSet<string> targetValues = new HashSet<string>();

            foreach (Dictionary<string, object> dictionary in values)
            {
                if (!targetValues.Contains((string)dictionary[targetVariableName]))
                {
                    targetValues.Add((string)dictionary[targetVariableName]);
                }
            }

            root = new Node(variables, targetVariableName, targetValues);

            root.training(values);
        }

        public double Error()
        {
            List<Double> totalLeafErrors = new List<double>();

            root.AccumulativeError(totalLeafErrors);

            double average = 0;

            foreach (double singularError in totalLeafErrors)
            {
                average += singularError;
            }

            average /= totalLeafErrors.Count;

            return average;
        }

        public Dictionary<string, double> Classifier(Dictionary<string, object> input)
        {
            Dictionary<string, double> probabilities = root.Classifier(input);

            return probabilities;
        }

        public void printTree()
        {
            root.printTree("");
        }
    }
}