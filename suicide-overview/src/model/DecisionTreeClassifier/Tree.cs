using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suicide_overview.src.model.DecisionTreeClassifier
{
    class Tree
    {
        List<Dictionary<string, Object>> values;

        Node root;

        Dictionary<string, int> variables;

        Tree(Dictionary<string,int> variables)
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
