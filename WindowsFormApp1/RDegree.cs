﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class RDegree : Form
    {
        public string Student_ID = Login.SetValueforStudentID;
        public RDegree()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLandingPage home = new StudentLandingPage();
            home.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DSJ0VD4\\SQLEXPRESS;Initial Catalog=onestop_creation;Integrated Security=True");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM request WHERE request_id='" + Student_ID + "' AND status = 'approved'", conn);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Your degree issuance has been downloaded.");
                //cm.Dispose();
                conn.Close();
                //Wanted to implement a delete query but could not due to time constraints
            }
            conn.Close();

        }
    }
}
