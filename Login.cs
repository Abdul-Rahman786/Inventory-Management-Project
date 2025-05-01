using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Project
{
    public partial class Login : Form
    {
        string connection_str = ConfigurationManager.ConnectionStrings["item_db"].ConnectionString;
        public static string username = "";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "select * from signup where name=@user and password=@password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@user", usernametextBox.Text);
            command.Parameters.AddWithValue("@password", passwordtextBox.Text);
            connection.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("LOGIN SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username = usernametextBox.Text;
                this.Hide();
                Form1 martform = new Form1();
                martform.ShowDialog();

            }
            else
            {
                MessageBox.Show("LOGIN FAILED", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void showpasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool check = showpasscheckBox.Checked;
            switch (check)
            {
                case true:
                    passwordtextBox.UseSystemPasswordChar = false;
                    break;
                default:
                    passwordtextBox.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp su = new SignUp();
            this.Hide();
            su.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
