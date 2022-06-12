using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Degree : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DSJ0VD4\\SQLEXPRESS;Initial Catalog=onestop_creation;Integrated Security=True");
        SqlCommand cmd;
        public string Student_ID = Login.SetValueforStudentID;

        public Degree()
        {
            InitializeComponent();
            label16.Text = Login.SetValueforStudentID;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox0.Text) || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) ||
                String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) ||
                String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text) || String.IsNullOrEmpty(textBox8.Text) ||
                String.IsNullOrEmpty(textBox9.Text) || String.IsNullOrEmpty(textBox10.Text) || String.IsNullOrEmpty(textBox11.Text)
                )
                MessageBox.Show("Fill all fields");
            else
            {
                //If the checkbox is CHECKED. Add to DB.
                if (checkBox1.Checked)
                {
                    conn.Open();
                   // string query1 = "update student(name,present_address,cnic_no,email,bank_challan_no) values ('"
                    //    + textBox0 + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4 + "','" + textBox7 + "')";

                    string date = DateTime.UtcNow.ToString("d");
                    string query2 = "Insert into request(request_id,student_id,start_date,status_fyp,status_fin) values ('"
                        + Student_ID + "','" + Student_ID + "','" + date + "','pending','pending')";
                   // string query3 = "Insert into fyp_dep_req(fypdr_id, request_id, start_time, decision) values ('"
                    //    + Student_ID + "','" + Student_ID + "','" + date + "','pending')";
                    //string query4 = "Insert into fin_deq_req(fypdr_id, request_id, decision) values ('"
                    //+ Student_ID + "','" + Student_ID + "','pending')";
                    // cmd = new SqlCommand(query1, conn);
                    //s cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    //SqlCommand cmd3 = new SqlCommand(query3, conn);
                    //SqlCommand cmd4 = new SqlCommand(query4, conn);
                    cmd2.ExecuteNonQuery();
                    //cmd3.ExecuteNonQuery();
                    //cmd4.ExecuteNonQuery();

                    MessageBox.Show("Your request has been generated.");
                    this.Hide();
                    StudentLandingPage home = new StudentLandingPage();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Declaration not checked.");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
