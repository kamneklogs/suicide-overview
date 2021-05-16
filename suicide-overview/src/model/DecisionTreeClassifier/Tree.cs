using System;
using System.Collections.Generic;

namespace suicide_overview.src.model.DecisionTreeClassifier
{
    internal class Tree
    {
        private List<Dictionary<string, Object>> values;

        private Node root;

        private Dictionary<string, int> variables;

        private Tree(Dictionary<string, int> variables)
        {
            this.variables = variables;
        }

        public void training(List<Dictionary<string, Object>> values)
        {
            this.values = values;

            root = new Node();
        }
    }
}