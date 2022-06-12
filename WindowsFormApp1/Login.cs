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

    
    public partial class Login : Form
    {
        public static string SetValueforStudentID = "";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DSJ0VD4\\SQLEXPRESS;Initial Catalog=onestop_creation;Integrated Security=True");
            conn.Open();
            string id = textBox1.Text;// making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM student WHERE student_id='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", conn);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                MessageBox.Show("Logged in successfully.");
                SetValueforStudentID = id;
                //cm.Dispose();
                conn.Close();
                this.Hide();
                new StudentLandingPage().Show();
            }
            else
            {
                conn.Close();
                MessageBox.Show("Invalid username or password");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }
    }
}
