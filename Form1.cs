using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Data;
using System.Numerics;

namespace Project

{
    public partial class Form1 : Form
    {

        int tax = 0;
        int srno = 0;
        string connection_str = ConfigurationManager.ConnectionStrings["item_db"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            getInvoiceID();
            GetItems();
            usertextBox.Text = Login.username;
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "SR #";
            dataGridView1.Columns[1].Name = "ITEM NAME";
            dataGridView1.Columns[2].Name = "UNIT PRICE";
            dataGridView1.Columns[3].Name = "DISCOUNT PRICE";
            dataGridView1.Columns[4].Name = "QUANTITY";
            dataGridView1.Columns[5].Name = "SUB TOTAL";
            dataGridView1.Columns[6].Name = "TAX";
            dataGridView1.Columns[7].Name = "TOTAL COST";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void GetItems()
        {
            selectitemcomboBox.Items.Clear();
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "select * from item_table";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                string item = dr.GetString(1);
                selectitemcomboBox.Items.Add(item);
            }
            selectitemcomboBox.Sorted = true;

            connection.Close();


        }
        void GetPrice()
        {
            int price = 0;
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "select item_price from item_table where item_name = @item_name";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@item_name", selectitemcomboBox.Text);
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                price = Convert.ToInt32(table.Rows[0]["item_price"]);
            }
            unitpricetextBox.Text = price.ToString();
        }

        private void selectitemcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPrice();
            GetDiscount();
            quantitytextBox.Enabled = true;

        }
        void GetDiscount()
        {
            int discount = 0;
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "select item_discount from item_table where item_name = @item_name";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@item_name", selectitemcomboBox.Text);
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                discount = Convert.ToInt32(table.Rows[0]["item_discount"]);
            }
            discounttextBox.Text = discount.ToString();
        }

        private void quantitytextBox_TextChanged(object sender, EventArgs e)
        {
            int price = 0;
            int discount = 0;
            int quantity = 0;
            if (!string.IsNullOrWhiteSpace(unitpricetextBox.Text))
            {
                price = Convert.ToInt32(unitpricetextBox.Text);
            }
            if (!string.IsNullOrWhiteSpace(discounttextBox.Text))
            {
                discount = Convert.ToInt32(discounttextBox.Text);
            }




            if (!int.TryParse(quantitytextBox.Text, out quantity))
            {

                return;
            }


            int subtotal = price * quantity;
            int total = subtotal - discount * quantity;
            subtotaltextBox.Text = total.ToString();
        }

        private void subtotaltextBox_TextChanged(object sender, EventArgs e)
        {
            int subtotal = 0;

            if (!string.IsNullOrEmpty(subtotaltextBox.Text))
            {
                subtotal = Convert.ToInt32(subtotaltextBox.Text);
            }

            if (subtotal >= 6000)
            {
                tax = (int)(subtotal * 0.15);
                taxtextBox.Text = tax.ToString();
            }
            else if (subtotal >= 3000)
            {
                tax = (int)(subtotal * 0.2);
                taxtextBox.Text = tax.ToString();
            }
            else if (subtotal >= 1000)
            {
                tax = (int)(subtotal * 0.08);
                taxtextBox.Text = tax.ToString();
            }
            else
            {
                tax = (int)(subtotal * 0.04);
                taxtextBox.Text = tax.ToString();
            }
        }

        private void totalcosttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void taxtextBox_TextChanged(object sender, EventArgs e)

        {
            int subtotal = 0;
            int tax = 0;
            int total = 0;
            if (!string.IsNullOrEmpty(subtotaltextBox.Text))
            {
                subtotal = Convert.ToInt32(subtotaltextBox.Text);

            }
            if (!string.IsNullOrEmpty(taxtextBox.Text))
            {
                tax = Convert.ToInt32(taxtextBox.Text);

            }
            if (!string.IsNullOrEmpty(subtotaltextBox.Text))
            {
                total = subtotal + tax;
            }



            totalcosttextBox.Text = total.ToString();
        }
        void AddDataToGridview(string srno, string item_name, string unit_price, string discount, string quantity, string sub_total, string tax, string total_cost)
        {
            string[] row = { srno, item_name, unit_price, discount, quantity, sub_total, tax, total_cost };
            dataGridView1.Rows.Add(row);

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (!(selectitemcomboBox.SelectedItem == null) && !(string.IsNullOrEmpty(quantitytextBox.Text)))
            {
                AddDataToGridview((++srno).ToString(), selectitemcomboBox.SelectedItem.ToString(), unitpricetextBox.Text, discounttextBox.Text, quantitytextBox.Text, subtotaltextBox.Text, taxtextBox.Text, totalcosttextBox.Text);

            }
            else
            {
                MessageBox.Show("Select both quantity and selected item ", "Qantity error ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetFinalCost();
            ResetControl();



        }
        void GetFinalCost()
        {
            int final_cost = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[7].Value != null)
                {
                    string cellValue = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    if (int.TryParse(cellValue, out int value))
                    {
                        final_cost += value;
                    }
                }
            }
            finalcosttextBox.Text = final_cost.ToString();
        }
        void ResetControl()
        {
            selectitemcomboBox.SelectedItem = null;
            unitpricetextBox.Clear();
            discounttextBox.Clear();
            quantitytextBox.Clear();
            subtotaltextBox.Clear();
            taxtextBox.Clear();
            totalcosttextBox.Clear();
            taxtextBox.Clear();

        }

        private void amounttextBox_TextChanged(object sender, EventArgs e)
        {
            int finalcost = 0;
            if (!string.IsNullOrEmpty(amounttextBox.Text))
            {

                int amountpaid = Convert.ToInt32(amounttextBox.Text);
                if (!string.IsNullOrEmpty(finalcosttextBox.Text))
                {
                    finalcost = Convert.ToInt32(finalcosttextBox.Text);

                }
                int remain = amountpaid - finalcost;
                changetextBox.Text = remain.ToString();
            }
            else
            {
                changetextBox.Text = "0";
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            ResetControl();
            finalcosttextBox.Clear();
            amounttextBox.Clear();
            changetextBox.Clear();
            quantitytextBox.Enabled = false;

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            ResetControl();
            finalcosttextBox.Clear();
            amounttextBox.Clear();
            changetextBox.Clear();
            quantitytextBox.Enabled = false;
            dataGridView1.Rows.Clear();
            srno = 0;
        }
        void getInvoiceID()
        {
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "select invoice_id from order_master";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count < 1)
            {
                invoicetextBox.Text = "1";
            }
            else
            {
                string query2 = "select max(invoice_id) from order_master";
                SqlCommand command = new SqlCommand(query2, connection);
                connection.Open();
                int a = Convert.ToInt32(command.ExecuteScalar());
                a = a + 1;
                invoicetextBox.Text = a.ToString();

                connection.Close();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(finalcosttextBox.Text))
            {
                SqlConnection connection = new SqlConnection(connection_str);
                string query = "insert into order_master values(@inv_id,@username,@datetime,@finalcost)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@inv_id", invoicetextBox.Text);
                command.Parameters.AddWithValue("@username", usertextBox.Text);
                command.Parameters.AddWithValue("@datetime", DateTime.Now);
                command.Parameters.AddWithValue("@finalcost", finalcosttextBox.Text);
                connection.Open();
                int a = command.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Inserted data Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getInvoiceID();
                    InsertIntoOrderDetails();
                    ResetControl();
                    dataGridView1.Rows.Clear();
                    finalcosttextBox.Clear();



                }
                else
                {
                    MessageBox.Show("Insertion Failed", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }



        }

        private void quantitytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void amounttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bit = Properties.Resources.RoyalMartImage;
            Image img = bit;
            e.Graphics.DrawImage(img, 95, 1, 600, 380);
            e.Graphics.DrawString("Invoice # : " + invoicetextBox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 360));
            e.Graphics.DrawString("Username : " + usertextBox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToShortDateString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 420));
            e.Graphics.DrawString("Time : " + DateTime.Now.ToLongTimeString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 480));
            e.Graphics.DrawString("ITEMS", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(40, 510));
            e.Graphics.DrawString("PRICE", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(250, 510));
            e.Graphics.DrawString("QUANTITY", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(450, 510));
            e.Graphics.DrawString("DISCOUNT", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(600, 510));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 540));


            //for items names
            int gap = 570;
            if (dataGridView1.Rows.Count > 1)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)

                {
                    var cellValue = dataGridView1.Rows[i].Cells[1].Value;
                    string displayValue = cellValue?.ToString() ?? ""; // Null check with fallback to empty string
                    e.Graphics.DrawString(displayValue, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(40, gap));
                    gap += 30;

                }


            }
            //for items price
            int gap1 = 570;
            if (dataGridView1.Rows.Count > 1)
            {
                for (int i = 0; i < (dataGridView1.Rows.Count - 1); i++)

                {
                    int cellValue = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                    e.Graphics.DrawString(cellValue.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(470, gap1));
                    gap1 += 30;

                }


            }
            //for items quantity
            int gap2 = 570;
            if (dataGridView1.Rows.Count > 1)
            {
                for (int i = 0; i < (dataGridView1.Rows.Count - 1); i++)

                {
                    int cellValue = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    e.Graphics.DrawString(cellValue.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(270, gap2));
                    gap2 += 30;

                }


            }
            //for items discount
            int gap3 = 570;
            if (dataGridView1.Rows.Count > 1)
            {
                for (int i = 0; i < (dataGridView1.Rows.Count - 1); i++)

                {
                    int cellValue = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    e.Graphics.DrawString(cellValue.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(620, gap3));
                    gap3 += 30;

                }


            }
            //for calculating subtotal , tax and 
            int subtotalprint = 0;
            int taxprint = 0;
            int finalcost = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                subtotalprint = subtotalprint + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                taxprint = taxprint + Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                finalcost = finalcost + Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 830));
            e.Graphics.DrawString("SUBTOTAL : " + subtotalprint.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 860));
            e.Graphics.DrawString("TAX : " + taxprint.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 890));
            e.Graphics.DrawString("FINAL COST : " + finalcost.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 920));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 950));
            e.Graphics.DrawString("AMOUNT PAID : " + amounttextBox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 980));
            e.Graphics.DrawString("CHANGE : " + changetextBox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1010));
            e.Graphics.DrawString("-----------THANKS FOR TRUST US---------", new Font("Vladimir Script", 15, FontStyle.Bold), Brushes.Black, new Point(220, 1040));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            GetItems();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditItemcs edit = new EditItemcs();
            edit.ShowDialog();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewData vd = new viewData();
            vd.ShowDialog();
        }
        int GetMaxInvoiceID()
        {
            SqlConnection connection = new SqlConnection(connection_str);
            string query = "select max(invoice_id) from order_master";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int maxInvoice = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return maxInvoice;
        }
        void InsertIntoOrderDetails()
        {
            SqlConnection connection = new SqlConnection(connection_str);
            int a = 0;
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string query = "insert into order_details values(@invoice_id,@item_name,@unitprice,@dis_per_item,@quantity,@subtotal,@tax,@finalcost)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@invoice_id", GetMaxInvoiceID());
                    //getting name of item , handle exception also 
                    var value = dataGridView1.Rows[i].Cells[1].Value;

                    if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                    {
                        command.Parameters.AddWithValue("@item_name", value.ToString());
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@item_name", DBNull.Value); // Or handle it as needed
                    }
                    //---------------------------------------
                    command.Parameters.AddWithValue("@unitprice", dataGridView1.Rows[i].Cells[2].Value);
                    command.Parameters.AddWithValue("@dis_per_item", dataGridView1.Rows[i].Cells[3].Value);
                    command.Parameters.AddWithValue("@quantity", dataGridView1.Rows[i].Cells[4].Value);
                    command.Parameters.AddWithValue("@subtotal", dataGridView1.Rows[i].Cells[5].Value);
                    command.Parameters.AddWithValue("@tax", dataGridView1.Rows[i].Cells[6].Value);
                    command.Parameters.AddWithValue("@finalcost", dataGridView1.Rows[i].Cells[7].Value);


                    connection.Open();
                    a = a + command.ExecuteNonQuery();
                    connection.Close();

                }

            }
            catch
            {

            }

            if (a > 0)
            {
                MessageBox.Show("Data inserted into Order_detials successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed insertion of Data into Order_detials", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void detailsAndSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsAndSearch details=new DetailsAndSearch();
            details.ShowDialog();
        }
    }
}
