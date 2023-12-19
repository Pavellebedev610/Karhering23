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

namespace Karhering
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string otherFormName = "Nastroiki";
            Form otherForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form.Name == otherFormName);
            otherForm?.Close();
            Registration log = new Registration();
            this.Hide();
            log.Show();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
