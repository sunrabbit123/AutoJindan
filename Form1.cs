﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IronPython.Hosting;

namespace AutoJindan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            try
            {
                var source = engine.CreateScriptSourceFromFile(@"AutoJindan.py");
                source.Execute(scope);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void button2_User(object sender, EventArgs e)
        {
            new User().ShowDialog();
        }
    }
}
