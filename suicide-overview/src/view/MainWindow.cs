﻿using suicide_overview.src.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suicide_overview
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunChange_Click(object sender, EventArgs e)
        {
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            mainPane.Controls.Clear();
            Graphs gr = new Graphs();
            mainPane.Controls.Add(gr);
        }

        private void viewColumnsReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPane.Controls.Clear();
            ColumnsReports cr = new ColumnsReports();
            mainPane.Controls.Add(cr);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPane.Controls.Clear();
            Graphs br = new Graphs();
            mainPane.Controls.Add(br);
        }
    }
}
