﻿using System;
using System.Windows.Forms;

namespace Taska3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
        }
    }
}
