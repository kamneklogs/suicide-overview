using System.Collections.Generic;

namespace suicide_overview.src.model.DecisionTreeClassifier

{
    internal class Node
    {
        //static readonly int
        public bool isLeaf { get; set; }

        public Decision decision { get; set; }

        public Node trueNode { get; set; }
        public Node falseNode { get; set; }

        public Dictionary<string, int> variables { get; set; }

        public string targetVariableName { get; set; }
        public HashSet<string> targetValues { get; set; }

        public Node(Dictionary<string, int> variables, string targetVariableName, HashSet<string> targetValues)
        {
            this.variables = variables;

            this.targetValues = targetValues;

            this.targetVariableName = targetVariableName;
        }

        public void training(List<Dictionary<string, object>> values)
        {
            List<Decision> decisionsList = generateDecisions(values);
            double giniValue = calculateGini(values);
            double minGini = 1;
            Decision minGiniDecision = null;
            List<Dictionary<string, object>> minGiniTrueList = null;
            List<Dictionary<string, object>> minGiniFalseList = null;

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
                        string result = (string)dictionary[d.variableName];

                        if (result.Equals(d.value))
                        {
                            trueList.Add(dictionary);
                        }
                        else
                        {
                            falseList.Add(dictionary);
                        }
                    }
                }

                //verify
                double giniTrue = calculateGini(trueList);
                double giniFalse = calculateGini(falseList);

                double giniTotal = (giniTrue * (trueList.Count / values.Count)) + (giniFalse * (falseList.Count / values.Count));
                if (giniTotal < minGini)
                {
                    minGini = giniTotal;
                    minGiniDecision = d;
                    minGiniTrueList = trueList;
                    minGiniFalseList = falseList;
                }
            }

            if (giniValue >= minGini)
            {
                trueNode = new Node(variables, targetVariableName, targetValues);
                falseNode = new Node(variables, targetVariableName, targetValues);

                trueNode.training(minGiniTrueList);
                falseNode.training(minGiniFalseList);

                decision = minGiniDecision;
                isLeaf = false;
            }
            else
            {
                isLeaf = true;
            }
        }

        //J G(k) = Σ P(i) * (1 - P(i)) i=1
        private double calculateGini(List<Dictionary<string, object>> list)
        {
            double result = 0;

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string tv in targetValues)
            {
                counts[tv] = 0;
            }

            foreach (Dictionary<string, object> item in list)
            {
                counts[(string)item[targetVariableName]]++;
            }

            foreach (string item in targetValues)
            {
                result += (counts[item] / list.Count) * (1 - (counts[item] / list.Count));
            }

            return result;
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
                    HashSet<string> variableValues = new HashSet<string>();

                    foreach (Dictionary<string, object> dictionary in values)
                    {
                        if (!variableValues.Contains((string)dictionary[variableName]))
                        {
                            variableValues.Add((string)dictionary[variableName]);
                        }
                    }

                    if (variableValues.Count > 1)

                        foreach (string item in variableValues)
                        {
                            decisionsList.Add(new Decision(variableName, 1, item));
                        }
                }
            }

            return decisionsList;
        }
    }
}