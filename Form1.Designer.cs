namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            invoicetextBox = new TextBox();
            label3 = new Label();
            usertextBox = new TextBox();
            label4 = new Label();
            selectitemcomboBox = new ComboBox();
            label5 = new Label();
            unitpricetextBox = new TextBox();
            label6 = new Label();
            discounttextBox = new TextBox();
            label7 = new Label();
            quantitytextBox = new TextBox();
            label8 = new Label();
            subtotaltextBox = new TextBox();
            label9 = new Label();
            taxtextBox = new TextBox();
            label10 = new Label();
            totalcosttextBox = new TextBox();
            label11 = new Label();
            finalcosttextBox = new TextBox();
            label12 = new Label();
            amounttextBox = new TextBox();
            label13 = new Label();
            changetextBox = new TextBox();
            addbutton = new Button();
            resetbutton = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            clearbutton = new Button();
            insertbutton = new Button();
            button1 = new Button();
            button2 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addItemToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            viewDataToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            dToolStripMenuItem = new ToolStripMenuItem();
            detailsAndSearchToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 200);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Invoice No";
            // 
            // invoicetextBox
            // 
            invoicetextBox.Location = new Point(21, 228);
            invoicetextBox.Name = "invoicetextBox";
            invoicetextBox.ReadOnly = true;
            invoicetextBox.Size = new Size(214, 23);
            invoicetextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 256);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 1;
            label3.Text = "User";
            // 
            // usertextBox
            // 
            usertextBox.Location = new Point(21, 284);
            usertextBox.Name = "usertextBox";
            usertextBox.ReadOnly = true;
            usertextBox.Size = new Size(214, 23);
            usertextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 315);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 1;
            label4.Text = "Selected Item";
            // 
            // selectitemcomboBox
            // 
            selectitemcomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            selectitemcomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            selectitemcomboBox.FormattingEnabled = true;
            selectitemcomboBox.Location = new Point(21, 343);
            selectitemcomboBox.Name = "selectitemcomboBox";
            selectitemcomboBox.Size = new Size(214, 23);
            selectitemcomboBox.TabIndex = 0;
            selectitemcomboBox.SelectedIndexChanged += selectitemcomboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 378);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 1;
            label5.Text = "Unit Price";
            // 
            // unitpricetextBox
            // 
            unitpricetextBox.Location = new Point(21, 406);
            unitpricetextBox.Name = "unitpricetextBox";
            unitpricetextBox.ReadOnly = true;
            unitpricetextBox.Size = new Size(214, 23);
            unitpricetextBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 439);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 1;
            label6.Text = "Discount Per Item";
            // 
            // discounttextBox
            // 
            discounttextBox.Location = new Point(21, 467);
            discounttextBox.Name = "discounttextBox";
            discounttextBox.ReadOnly = true;
            discounttextBox.Size = new Size(214, 23);
            discounttextBox.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(274, 200);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 1;
            label7.Text = "Quantity";
            // 
            // quantitytextBox
            // 
            quantitytextBox.Enabled = false;
            quantitytextBox.Location = new Point(274, 228);
            quantitytextBox.MaxLength = 2;
            quantitytextBox.Name = "quantitytextBox";
            quantitytextBox.Size = new Size(214, 23);
            quantitytextBox.TabIndex = 1;
            quantitytextBox.TextChanged += quantitytextBox_TextChanged;
            quantitytextBox.KeyPress += quantitytextBox_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(274, 256);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 1;
            label8.Text = "Sub Total";
            // 
            // subtotaltextBox
            // 
            subtotaltextBox.Location = new Point(274, 284);
            subtotaltextBox.Name = "subtotaltextBox";
            subtotaltextBox.ReadOnly = true;
            subtotaltextBox.Size = new Size(214, 23);
            subtotaltextBox.TabIndex = 4;
            subtotaltextBox.TextChanged += subtotaltextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(274, 315);
            label9.Name = "label9";
            label9.Size = new Size(42, 25);
            label9.TabIndex = 1;
            label9.Text = "Tax";
            // 
            // taxtextBox
            // 
            taxtextBox.Location = new Point(274, 343);
            taxtextBox.Name = "taxtextBox";
            taxtextBox.ReadOnly = true;
            taxtextBox.Size = new Size(214, 23);
            taxtextBox.TabIndex = 5;
            taxtextBox.TextChanged += taxtextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(274, 378);
            label10.Name = "label10";
            label10.Size = new Size(99, 25);
            label10.TabIndex = 1;
            label10.Text = "Total Cost";
            // 
            // totalcosttextBox
            // 
            totalcosttextBox.Location = new Point(274, 406);
            totalcosttextBox.Name = "totalcosttextBox";
            totalcosttextBox.ReadOnly = true;
            totalcosttextBox.Size = new Size(214, 23);
            totalcosttextBox.TabIndex = 6;
            totalcosttextBox.TextChanged += totalcosttextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(274, 439);
            label11.Name = "label11";
            label11.Size = new Size(98, 25);
            label11.TabIndex = 1;
            label11.Text = "Final Cost";
            // 
            // finalcosttextBox
            // 
            finalcosttextBox.Location = new Point(274, 467);
            finalcosttextBox.Name = "finalcosttextBox";
            finalcosttextBox.ReadOnly = true;
            finalcosttextBox.Size = new Size(214, 23);
            finalcosttextBox.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(537, 200);
            label12.Name = "label12";
            label12.Size = new Size(129, 25);
            label12.TabIndex = 1;
            label12.Text = "Amount Paid";
            // 
            // amounttextBox
            // 
            amounttextBox.Location = new Point(537, 228);
            amounttextBox.Name = "amounttextBox";
            amounttextBox.Size = new Size(236, 23);
            amounttextBox.TabIndex = 3;
            amounttextBox.TextChanged += amounttextBox_TextChanged;
            amounttextBox.KeyPress += amounttextBox_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(537, 256);
            label13.Name = "label13";
            label13.Size = new Size(79, 25);
            label13.TabIndex = 1;
            label13.Text = "Change";
            // 
            // changetextBox
            // 
            changetextBox.Location = new Point(537, 284);
            changetextBox.Name = "changetextBox";
            changetextBox.ReadOnly = true;
            changetextBox.Size = new Size(236, 23);
            changetextBox.TabIndex = 9;
            // 
            // addbutton
            // 
            addbutton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbutton.Location = new Point(22, 496);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(97, 51);
            addbutton.TabIndex = 2;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // resetbutton
            // 
            resetbutton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetbutton.Location = new Point(125, 496);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(97, 51);
            resetbutton.TabIndex = 5;
            resetbutton.Text = "Reset";
            resetbutton.UseVisualStyleBackColor = true;
            resetbutton.Click += resetbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(23, 564);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(752, 170);
            dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(190, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(259, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(248, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // clearbutton
            // 
            clearbutton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearbutton.Location = new Point(681, 499);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(92, 51);
            clearbutton.TabIndex = 6;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // insertbutton
            // 
            insertbutton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbutton.Location = new Point(580, 500);
            insertbutton.Name = "insertbutton";
            insertbutton.Size = new Size(95, 50);
            insertbutton.TabIndex = 4;
            insertbutton.Text = "Insert";
            insertbutton.UseVisualStyleBackColor = true;
            insertbutton.Click += insertbutton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Cooper Black", 15.75F);
            button1.Location = new Point(537, 315);
            button1.Name = "button1";
            button1.Size = new Size(129, 74);
            button1.TabIndex = 14;
            button1.Text = "Print Preview";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Cooper Black", 15.75F);
            button2.Location = new Point(537, 392);
            button2.Name = "button2";
            button2.Size = new Size(129, 72);
            button2.TabIndex = 15;
            button2.Text = "Print";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, aboutToolStripMenuItem, dToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addItemToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Image = (Image)resources.GetObject("fileToolStripMenuItem.Image");
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(53, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Image = (Image)resources.GetObject("addItemToolStripMenuItem.Image");
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(123, 22);
            addItemToolStripMenuItem.Text = "Add Item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(123, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItem1 });
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(55, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Image = (Image)resources.GetObject("editToolStripMenuItem1.Image");
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(94, 22);
            editToolStripMenuItem1.Text = "Edit";
            editToolStripMenuItem1.Click += editToolStripMenuItem1_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewDataToolStripMenuItem });
            viewToolStripMenuItem.Image = (Image)resources.GetObject("viewToolStripMenuItem.Image");
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(60, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // viewDataToolStripMenuItem
            // 
            viewDataToolStripMenuItem.Image = (Image)resources.GetObject("viewDataToolStripMenuItem.Image");
            viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            viewDataToolStripMenuItem.Size = new Size(180, 22);
            viewDataToolStripMenuItem.Text = "View Data";
            viewDataToolStripMenuItem.Click += viewDataToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Image = (Image)resources.GetObject("aboutToolStripMenuItem.Image");
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(68, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // dToolStripMenuItem
            // 
            dToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detailsAndSearchToolStripMenuItem });
            dToolStripMenuItem.Image = (Image)resources.GetObject("dToolStripMenuItem.Image");
            dToolStripMenuItem.Name = "dToolStripMenuItem";
            dToolStripMenuItem.Size = new Size(70, 20);
            dToolStripMenuItem.Text = "Details";
            // 
            // detailsAndSearchToolStripMenuItem
            // 
            detailsAndSearchToolStripMenuItem.Image = (Image)resources.GetObject("detailsAndSearchToolStripMenuItem.Image");
            detailsAndSearchToolStripMenuItem.Name = "detailsAndSearchToolStripMenuItem";
            detailsAndSearchToolStripMenuItem.Size = new Size(180, 22);
            detailsAndSearchToolStripMenuItem.Text = "Details and Search";
            detailsAndSearchToolStripMenuItem.Click += detailsAndSearchToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 749);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(insertbutton);
            Controls.Add(clearbutton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(resetbutton);
            Controls.Add(addbutton);
            Controls.Add(selectitemcomboBox);
            Controls.Add(discounttextBox);
            Controls.Add(unitpricetextBox);
            Controls.Add(usertextBox);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(finalcosttextBox);
            Controls.Add(totalcosttextBox);
            Controls.Add(taxtextBox);
            Controls.Add(subtotaltextBox);
            Controls.Add(changetextBox);
            Controls.Add(amounttextBox);
            Controls.Add(quantitytextBox);
            Controls.Add(invoicetextBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox invoicetextBox;
        private Label label3;
        private TextBox usertextBox;
        private Label label4;
        private ComboBox selectitemcomboBox;
        private Label label5;
        private TextBox unitpricetextBox;
        private Label label6;
        private TextBox discounttextBox;
        private Label label7;
        private TextBox quantitytextBox;
        private Label label8;
        private TextBox subtotaltextBox;
        private Label label9;
        private TextBox taxtextBox;
        private Label label10;
        private TextBox totalcosttextBox;
        private Label label11;
        private TextBox finalcosttextBox;
        private Label label12;
        private TextBox amounttextBox;
        private Label label13;
        private TextBox changetextBox;
        private Button addbutton;
        private Button resetbutton;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button clearbutton;
        private Button insertbutton;
        private Button button1;
        private Button button2;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem viewDataToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem detailsAndSearchToolStripMenuItem;
    }
}
