﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulare
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 jj = new Form1();
            jj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 jjj = new Form1();
            this.Close();
            Application.Exit();
        }
    }
}
