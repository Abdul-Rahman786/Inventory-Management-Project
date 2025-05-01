namespace Project
{
    partial class DetailsAndSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsAndSearch));
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            searchtextBox = new TextBox();
            searchbutton = new Button();
            label2 = new Label();
            finalcosttextBox = new TextBox();
            label = new Label();
            label4 = new Label();
            firstdateTimePicker = new DateTimePicker();
            seconddateTimePicker = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(220, -68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(347, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 336);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(774, 265);
            dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 146);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 20;
            label1.Text = "Search by Invoice";
            // 
            // searchtextBox
            // 
            searchtextBox.Location = new Point(33, 179);
            searchtextBox.Name = "searchtextBox";
            searchtextBox.Size = new Size(142, 23);
            searchtextBox.TabIndex = 21;
            // 
            // searchbutton
            // 
            searchbutton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbutton.Location = new Point(33, 208);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(90, 42);
            searchbutton.TabIndex = 22;
            searchbutton.Text = "Search";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 268);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 23;
            label2.Text = "Final Cost";
            // 
            // finalcosttextBox
            // 
            finalcosttextBox.Location = new Point(137, 270);
            finalcosttextBox.Name = "finalcosttextBox";
            finalcosttextBox.ReadOnly = true;
            finalcosttextBox.Size = new Size(89, 23);
            finalcosttextBox.TabIndex = 24;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(538, 146);
            label.Name = "label";
            label.Size = new Size(148, 25);
            label.TabIndex = 23;
            label.Text = "Final Date Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(538, 215);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 23;
            label4.Text = "Second Date Time";
            // 
            // firstdateTimePicker
            // 
            firstdateTimePicker.CustomFormat = "yyyy-MM-dd h:mmtt";
            firstdateTimePicker.Format = DateTimePickerFormat.Custom;
            firstdateTimePicker.Location = new Point(538, 174);
            firstdateTimePicker.Name = "firstdateTimePicker";
            firstdateTimePicker.Size = new Size(200, 23);
            firstdateTimePicker.TabIndex = 25;
            // 
            // seconddateTimePicker
            // 
            seconddateTimePicker.CustomFormat = "yyyy-MM-dd h:mmtt";
            seconddateTimePicker.Format = DateTimePickerFormat.Custom;
            seconddateTimePicker.Location = new Point(538, 243);
            seconddateTimePicker.Name = "seconddateTimePicker";
            seconddateTimePicker.Size = new Size(200, 23);
            seconddateTimePicker.TabIndex = 25;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(538, 288);
            button1.Name = "button1";
            button1.Size = new Size(90, 42);
            button1.TabIndex = 22;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(648, 288);
            button2.Name = "button2";
            button2.Size = new Size(90, 42);
            button2.TabIndex = 22;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DetailsAndSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 609);
            Controls.Add(seconddateTimePicker);
            Controls.Add(firstdateTimePicker);
            Controls.Add(finalcosttextBox);
            Controls.Add(label4);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(searchbutton);
            Controls.Add(searchtextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Name = "DetailsAndSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailsAndSearch";
            Load += DetailsAndSearch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox searchtextBox;
        private Button searchbutton;
        private Label label2;
        private TextBox finalcosttextBox;
        private Label label;
        private Label label4;
        private DateTimePicker firstdateTimePicker;
        private DateTimePicker seconddateTimePicker;
        private Button button1;
        private Button button2;
    }
}