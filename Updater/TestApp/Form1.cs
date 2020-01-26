﻿using SharpUpdate;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Update : Form
    {
        private QubedotUpdater updater;

        public Update()
        {
            InitializeComponent();

            label1.Text = ProductName + "\n" + ProductVersion;

            updater = new QubedotUpdater(Assembly.GetExecutingAssembly(), this, new Uri("https://raw.githubusercontent.com/henryxrl/SharpUpdate/master/project.xml"));
            //updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri(new System.IO.FileInfo(@"..\..\..\project.xml").FullName));       // for local testing
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
