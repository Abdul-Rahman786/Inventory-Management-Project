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
    public partial class viewData : Form
    {
        string connection_str = ConfigurationManager.ConnectionStrings["item_db"].ConnectionString;

        public viewData()
        {
            InitializeComponent();
            BindGridview();
        }

        private void viewData_Load(object sender, EventArgs e)
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

        private void additembutton_Click(object sender, EventArgs e)
        {
            addItem additem = new addItem();
            additem.ShowDialog();
        }

        private void updateitembutton_Click(object sender, EventArgs e)
        {
            EditItemcs edit = new EditItemcs();
            edit.ShowDialog();
        }

        private void deleteitembutton_Click(object sender, EventArgs e)
        {
            EditItemcs edit = new EditItemcs();
            edit.ShowDialog();
        }

        private void viewData_Activated(object sender, EventArgs e)
        {
            BindGridview();
        }
    }
}
