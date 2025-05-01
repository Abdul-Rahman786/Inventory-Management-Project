using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;
namespace Project

{
    public partial class DetailsAndSearch : Form
    {
        string connection_str = ConfigurationManager.ConnectionStrings["item_db"].ConnectionString;

        public DetailsAndSearch()
        {
            InitializeComponent();
            BindDataGridview();
        }

        private void DetailsAndSearch_Load(object sender, EventArgs e)
        {

        }
        void BindDataGridview()
        {
            SqlConnection conn = new SqlConnection(connection_str);
            string query = "sp_getBothTablesData";
            SqlCommand sqlcommand = new SqlCommand(query, conn);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqldataadapter = new SqlDataAdapter();
            sqldataadapter.SelectCommand = sqlcommand;
            DataTable table = new DataTable();
            sqldataadapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_str);
            string query = "sp_getBothTablesDatabyID";
            SqlCommand sqlcommand = new SqlCommand(query, conn);
            sqlcommand.Parameters.AddWithValue("@InvoiceID", searchtextBox.Text);


            sqlcommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqldataadapter = new SqlDataAdapter();

            sqldataadapter.SelectCommand = sqlcommand;
            DataTable table = new DataTable();
            sqldataadapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[10].Visible = false;
            if (string.IsNullOrEmpty(searchtextBox.Text))
            {
                MessageBox.Show("Please enter number in the serach field");

            }
            else
            {
                finalcosttextBox.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_str);
            string query = "sp_getBothTablesDatabyDateTime";
            SqlCommand sqlcommand = new SqlCommand(query, conn);
            sqlcommand.Parameters.AddWithValue("@FirstDate", firstdateTimePicker.Value);
            sqlcommand.Parameters.AddWithValue("@SecondDate", seconddateTimePicker.Value);


            sqlcommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqldataadapter = new SqlDataAdapter();

            sqldataadapter.SelectCommand = sqlcommand;
            DataTable table = new DataTable();
            sqldataadapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "MMM dd yyyy HH:mm"; // e.g., "May 01 2025 15:35"
            dataGridView1.Columns[10].Visible = false;
            finalcosttextBox.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindDataGridview();
        }
    }
}
