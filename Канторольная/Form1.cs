﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Канторольная
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DialogResult dr = frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            DialogResult dr = frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
