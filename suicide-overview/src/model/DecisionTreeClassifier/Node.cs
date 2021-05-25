using System;
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

        public double minGini { get; private set; }
        public double giniTotal { get; private set; }

        public Dictionary<string, int> variables { get; set; }

        public string targetVariableName { get; set; }
        public HashSet<string> targetValues { get; set; }

        public Dictionary<string, double> Probabilities { get; set; }

        public Node(Dictionary<string, int> variables, string targetVariableName, HashSet<string> targetValues)
        {

            minGini = 1.1;

            this.variables = variables;

            this.targetValues = targetValues;

            this.targetVariableName = targetVariableName;

            Probabilities = new Dictionary<string, double>();

            
        }

        public void training(List<Dictionary<string, object>> values)
        {
            List<Decision> decisionsList = generateDecisions(values);
            double giniValue = calculateGini(values);
            double minGini = 1.1;
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
                        double result = Convert.ToDouble(dictionary[d.variableName]);

                        if (result < Convert.ToDouble(d.value))
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

            giniTotal = (giniTrue * (Convert.ToDouble(trueList.Count) / Convert.ToDouble(values.Count))) + (giniFalse * (Convert.ToDouble(falseList.Count) / Convert.ToDouble(values.Count)));

                if (giniTotal < minGini)
                {
                    minGini = giniTotal;
                    minGiniDecision = d;
                    minGiniTrueList = trueList;
                    minGiniFalseList = falseList;
                }
            }

            if (giniValue > minGini)
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

                Dictionary<string, int> counts = new Dictionary<string, int>();

                foreach (string tv in targetValues)
                {
                    counts[tv] = 0;
                }

                foreach (Dictionary<string, object> item in values)
                {
                    counts[(string)item[targetVariableName]]++;
                }

                foreach (string tv in targetValues)
                {
                    Probabilities[tv] = (double)counts[tv] / (double)values.Count;
                }
            }
        }

        internal void printTree(string separador)
        {
            if (!isLeaf)
            {
                Console.WriteLine(separador + decision.toString());
                trueNode.printTree(separador + "  ");

                falseNode.printTree(separador + "  ");
            }
            else
            {
                foreach (string item in targetValues)
                {
                    Console.WriteLine(separador + "Probabilidad de " + item + ": " + (Probabilities[item] * 100) + "%\n");
                }
            }
        }

        internal Dictionary<string, double> Classifier(Dictionary<string, object> input)
        {
            if (isLeaf)
                return Probabilities;

            if (decision.typeVariable == 0)
            {
                if (Convert.ToDouble(input[decision.variableName]) < Convert.ToDouble(decision.value))
                    return trueNode.Classifier(input);

                return falseNode.Classifier(input);
            }
            else
            {
                if (((string)input[decision.variableName]).Equals((string)decision.value))
                    return trueNode.Classifier(input);

                return falseNode.Classifier(input);
            }
        }

        //J G(k) = Σ P(i) * (1 - P(i)) i=1
        private double calculateGini(List<Dictionary<string, object>> list)
        {
            double result = 0;

            Dictionary<string, double> counts = new Dictionary<string, double>();

            foreach (string tv in targetValues)
            {
                counts[tv] = 0.0;
            }

            foreach (Dictionary<string, object> item in list)
            {
                counts[(string)item[targetVariableName]]++;
            }

            foreach (string item in targetValues)
            {
                result += (counts[item] / Convert.ToDouble(list.Count)) * (1 - (counts[item] / Convert.ToDouble(list.Count)));
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
                        if (!variableValues.Contains(Convert.ToDouble(dictionary[variableName])))
                        {
                            variableValues.Add(Convert.ToDouble(dictionary[variableName]));
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

        public void AccumulativeError(List<Double> errors)
        {

            if (isLeaf)
            {
                errors.Add(giniTotal);
            }
            else
            {
                if (trueNode != null)
                {
                    trueNode.AccumulativeError(errors);
                }

                if(falseNode != null)
                {
                    falseNode.AccumulativeError(errors);
                }
            }


            
        }
    }
}