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

            updater = new QubedotUpdater(Assembly.GetExecutingAssembly(), this, new Uri("https://raw.githack.com/dennisripp/Testupdater/master/Updater/project.xml"));
            // updater = new QubedotUpdater(Assembly.GetExecutingAssembly(), this, new Uri(@"C:\Users\denni\Desktop\Test updater\project.xml").FullName));       // for local testing
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
