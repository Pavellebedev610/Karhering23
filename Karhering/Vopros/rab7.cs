﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karhering.Vopros
{
    public partial class rab7 : Form
    {
        public rab7()
        {
            InitializeComponent();
        }

        private void rab7_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
            MessageBox.Show("Промокод активирован");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Click_1(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
            MessageBox.Show("Промокод активирован");
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
