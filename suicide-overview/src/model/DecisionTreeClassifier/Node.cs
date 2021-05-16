using System.Collections.Generic;

namespace suicide_overview.src.model.DecisionTreeClassifier

{
    internal class Node
    {

        //static readonly int 
        public bool isLeaf { get; set; }
        public Decision decision { get; set; }
        public double giniValue { get; set; }

        public Node trueNode { get; set; }
        public Node falseNode { get; set; }

        public Dictionary<string, int> variables { get; set; }

        public Node(Dictionary<string, int> variables)
        {
            this.variables = variables;
        }

        public void training(List<Dictionary<string, object>> values)
        {

            foreach (string variableName in variables.Keys)
            {
                HashSet<object> decisionsSet = new HashSet<object>();

                if (variables[variableName] == 0) // To constant
                {

                }
                else
                {

                }
            }

        }
    }
}