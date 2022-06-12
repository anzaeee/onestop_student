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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DSJ0VD4\\SQLEXPRESS;Initial Catalog=onestop_creation;Integrated Security=True");
            conn.Open();
            SqlCommand cm;
            string un = textBox1.Text;
            string pass = textBox2.Text;
            string pn = textBox3.Text;
            string query = "Insert into student(student_id,password,phone_no) values ('" + un + "','" + pass + "','" + pn + "')";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();

            MessageBox.Show("Account has been created");

            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
