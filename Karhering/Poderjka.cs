﻿using Guna.UI2.WinForms;
using Karhering.Vopros;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Karhering
{
    public partial class Poderjka : Form
    {
        public Poderjka()
        {
            InitializeComponent();
        }

        private void Poderjka_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rab1 log1 = new rab1();
            log1.Show();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rab2 log = new rab2();
            log.Show();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rab4 log = new rab4();
            log.Show();
        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rab3 log = new rab3();
            log.Show();
        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rab5 log = new rab5();
            log.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Click_1(object sender, EventArgs e)
        {
            guna2TextBox2.Clear();
            textBox1.Clear();
            MessageBox.Show("Ваше сообщение отправлено");
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Hub log3 = new Hub();
            this.Hide();
            log3.Show();
        }
    }
}
