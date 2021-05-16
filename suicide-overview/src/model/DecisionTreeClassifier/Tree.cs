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

        private Tree(Dictionary<string, int> variables, string targetVariableName)
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

            root = new Node(variables);
        }
    }
}