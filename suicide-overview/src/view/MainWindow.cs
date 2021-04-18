using suicide_overview.src.model;
using suicide_overview.src.view;
using System;
using System.Windows.Forms;

namespace suicide_overview
{
    public partial class MainWindow : Form
    {
        private MasterClass mc;

        public MainWindow()
        {
            InitializeComponent();

            mc = new MasterClass();
        }

        private void RunChange_Click(object sender, EventArgs e)
        {
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPane.Controls.Clear();
            Graphs gr = new Graphs(mc);

            mainPane.Controls.Add(gr);
        }

        private void viewColumnsReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPane.Controls.Clear();
            RecordsViewer cr = new RecordsViewer(mc);
            mainPane.Controls.Add(cr);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPane.Controls.Clear();
            Graphs br = new Graphs(mc);
            mainPane.Controls.Add(br);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }
    }
}