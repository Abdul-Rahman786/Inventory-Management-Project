using Microsoft.Data.SqlClient;
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
namespace Project
{
    public partial class EditItemcs : Form
    {
        string connection_str = ConfigurationManager.ConnectionStrings["item_db"].ConnectionString;

        public EditItemcs()
        {
            InitializeComponent();
            BindGridview();
        }

        private void EditItemcs_Load(object sender, EventArgs e)
        {

        }

        void BindGridview()
        {
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "select * from item_table";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IDtextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            nametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pricetextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            discounttextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "update item_table set item_name=@name, item_price=@price, item_discount=@discount where item_id=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", IDtextBox.Text);
            command.Parameters.AddWithValue("@name", nametextBox.Text);
            command.Parameters.AddWithValue("@price", pricetextBox.Text);
            command.Parameters.AddWithValue("@discount", discounttextBox.Text);
            connection.Open();
            int a = command.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridview();
                IDtextBox.Clear();
                nametextBox.Clear();
                pricetextBox.Clear();
                discounttextBox.Clear();
                IDtextBox.Focus();

            }
            else
            {
                MessageBox.Show("Updation Failed", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connection_str);
            string query = "delete from item_table  where item_id=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", IDtextBox.Text);
           
            connection.Open();
            int a = command.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridview();
                IDtextBox.Clear();
                nametextBox.Clear();
                pricetextBox.Clear();
                discounttextBox.Clear();
               

            }
            else
            {
                MessageBox.Show("Deletion Failed", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }


}
