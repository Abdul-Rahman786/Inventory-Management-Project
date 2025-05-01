using Microsoft.Data.SqlClient;
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

namespace Project
{
    public partial class SignUp : Form
    {
        string connection_str = ConfigurationManager.ConnectionStrings["item_db"].ConnectionString;

        public SignUp()
        {
            InitializeComponent();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signupbutton_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "insert into signup  values ( @uname,@sname,@gender ,@age,@address,@email,@password)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@uname", ntextBox.Text);
            command.Parameters.AddWithValue("@sname", sntextBox.Text);
            command.Parameters.AddWithValue("@gender", gcomboBox.Text);
            command.Parameters.AddWithValue("@age", agnumericUpDown.Text);
            command.Parameters.AddWithValue("@address", addtextBox.Text);
            command.Parameters.AddWithValue("@email", emtextBox.Text);
            command.Parameters.AddWithValue("@password", patextBox.Text);
            connection.Open();
            int a = command.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("SUCCESSFULLY LOGIN", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Username " + ntextBox.Text + "Password " + patextBox.Text, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login loginform = new Login();
                loginform.ShowDialog();
            }
            else
            {
                MessageBox.Show("LOGIN FAILED", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            connection.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    patextBox.UseSystemPasswordChar = false;
                    break;
                default:
                    confirmpasswordtextBox.UseSystemPasswordChar = true;
                    break;
            }
        }
    }
}
