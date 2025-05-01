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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Project
{
    public partial class addItem : Form
    {
        string connection_str = ConfigurationManager.ConnectionStrings["item_db"].ConnectionString;

        public addItem()
        {
            InitializeComponent();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "insert into item_table values (@name,@price,@discount)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", nametextBox.Text);
            command.Parameters.AddWithValue("@price", pricetextBox.Text);
            command.Parameters.AddWithValue("@discount", discounttextBox.Text);

            connection.Open();
            int a = command.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("SUCCESSFULLY INSERTED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nametextBox.Clear();
                pricetextBox.Clear();
                discounttextBox.Clear();
                nametextBox.Focus();
            }
            else
            {
                MessageBox.Show("INSERTION FAILED", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            connection.Close();
        }

        private void addItem_Load(object sender, EventArgs e)
        {

        }
    }
}
