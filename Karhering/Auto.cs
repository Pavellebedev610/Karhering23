﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karhering
{
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            string connectString = (@"Data Source = C41415\SQLEXPRESS; Initial Catalog=Karhering;Integrated Security=True");
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string query = "SELECT * FROM car ORDER BY id_car";
            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();


            while (reader.Read())
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();

            }
            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                guna2DataGridView1.Rows.Add(s);

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Hub log = new Hub();
            this.Hide();
            log.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
