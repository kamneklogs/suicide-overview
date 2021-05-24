using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Filters;
using System.Data;

namespace suicide_overview.src.model.AccordFramework_Bridge
{
    internal class AccordAdapter
    {
        public string CountryName { get; }
        private DecisionTree tree;

        private DataTable symbols;
        private Codification codebook;
        private readonly int[][] inputs;
        private readonly int[] outputs;

        public AccordAdapter(string treeName, DataTable originalData)
        {
            CountryName = treeName;
            codebook = new Codification(originalData);
            symbols = codebook.Apply(originalData);
            inputs = symbols.ToJagged<int>("year", "generation", "sex");
            outputs = symbols.ToArray<int>("risk");
        }

        public void Learn()
        {
            var id3learning = new ID3Learning()
            {
                new DecisionVariable("year",     2016-1985),
                new DecisionVariable("generation", 6),
                new DecisionVariable("sex",    2),
            };

            tree = id3learning.Learn(inputs, outputs);
        }

        public string simulate(int year, string generation, string sex)
        {
            var id3learning = new ID3Learning()
            {
                new DecisionVariable("year",     2016-1985),
                new DecisionVariable("generation", 6),
                new DecisionVariable("sex",    2),
            };

            tree = id3learning.Learn(inputs, outputs);

            int[] query = codebook.Transform(new[,]
          {
                { "year",    year.ToString() },
                { "generation", generation    },
                { "sex",    sex   },
            });

            int predicted = tree.Decide(query);
            string answer = codebook.Revert("risk", predicted);

            return answer;
        }
    }
}