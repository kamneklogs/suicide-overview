using suicide_overview.src.model.DecisionTreeClassifier;
using System;
using System.Windows.Forms;

namespace suicide_overview.src.view
{
    public partial class TreeViewer : Form
    {
        public Node Root { get; private set; }

        public TreeViewer(Node decisionTreeRootNode)
        {
            InitializeComponent();

            this.Root = decisionTreeRootNode;
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TreeViewer_Load(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(Root.GetFinalTag());

            addChildren(Root, node);

            treeView.Nodes.Add(node);
        }

        private void addChildren(Node decisiontreeNode, TreeNode treeViewNode)
        {
            if (decisiontreeNode.falseNode != null)
            {
                TreeNode falsechild = new TreeNode(decisiontreeNode.falseNode.GetFinalTag());

                addChildren(decisiontreeNode.falseNode, falsechild);

                treeViewNode.Nodes.Add(falsechild);
            }

            if (decisiontreeNode.trueNode != null)
            {
                TreeNode trueChild = new TreeNode(decisiontreeNode.trueNode.GetFinalTag());

                addChildren(decisiontreeNode.trueNode, trueChild);

                treeViewNode.Nodes.Add(trueChild);
            }
        }
    }
}