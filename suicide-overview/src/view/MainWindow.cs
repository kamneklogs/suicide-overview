﻿using suicide_overview.src.model;
using suicide_overview.src.view;
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

        private void viewGraphicalReport(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPane.Controls.Clear();
            Graphs br = new Graphs(mc);
            mainPane.Controls.Add(br);
        }

        private void loadSimulator(object sender, System.EventArgs e)
        {
            mainPane.Controls.Clear();
            SimulatorWindow sw = new SimulatorWindow(mc);
            mainPane.Controls.Add(sw);
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}