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
            List<Decision> decisionsList = generateDecisions(values);

            foreach (Decision d in decisionsList)
            {
                List<Dictionary<string, object>> trueList = new List<Dictionary<string, object>>();
                List<Dictionary<string, object>> falseList = new List<Dictionary<string, object>>();

                foreach (Dictionary<string, object> dictionary in values)
                {
                    if (d.typeVariable == 0)
                    {
                        double result = (double)dictionary[d.variableName];

                        if (result < (double)d.value)
                        {
                            trueList.Add(dictionary);
                        }
                        else
                        {
                            falseList.Add(dictionary);
                        }
                    }
                    else
                    {
                        double result = (double)dictionary[d.variableName];

                        if (result < (double)d.value)
                        {
                            trueList.Add(dictionary);
                        }
                        else
                        {
                            falseList.Add(dictionary);
                        }
                    }
                }
            }
        }

        private List<Decision> generateDecisions(List<Dictionary<string, object>> values)
        {
            List<Decision> decisionsList = new List<Decision>();
            foreach (string variableName in variables.Keys)
            {
                if (variables[variableName] == 0) // To constant
                {
                    HashSet<double> variableValues = new HashSet<double>();

                    foreach (Dictionary<string, object> dictionary in values)
                    {
                        if (!variableValues.Contains((double)dictionary[variableName]))
                        {
                            variableValues.Add((double)dictionary[variableName]);
                        }
                    }

                    List<double> doubleValues = new List<double>(variableValues);

                    doubleValues.Sort();

                    for (int i = 0; i < doubleValues.Count - 1; i++)
                    {
                        double decisionPoint = (doubleValues[i] + doubleValues[i + 1]) / 2;

                        decisionsList.Add(new Decision(variableName, 0, decisionPoint));
                    }
                }
                else
                {
                    HashSet<object> variableValues = new HashSet<object>();

                    foreach (Dictionary<string, object> dictionary in values)
                    {
                        if (!variableValues.Contains(dictionary[variableName]))
                        {
                            variableValues.Add(dictionary[variableName]);
                        }
                    }

                    if (variableValues.Count > 1)

                        foreach (object item in variableValues)
                        {
                            decisionsList.Add(new Decision(variableName, 1, item));
                        }
                }
            }

            return decisionsList;
        }
    }
}