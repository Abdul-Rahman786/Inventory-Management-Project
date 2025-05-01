namespace Project
{
    partial class EditItemcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItemcs));
            panel1 = new Panel();
            button1 = new Button();
            updatebutton = new Button();
            IDtextBox = new TextBox();
            discounttextBox = new TextBox();
            pricetextBox = new TextBox();
            label5 = new Label();
            nametextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(updatebutton);
            panel1.Controls.Add(IDtextBox);
            panel1.Controls.Add(discounttextBox);
            panel1.Controls.Add(pricetextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(nametextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(132, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 221);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(169, 169);
            button1.Name = "button1";
            button1.Size = new Size(135, 42);
            button1.TabIndex = 5;
            button1.Text = "DELETE";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // updatebutton
            // 
            updatebutton.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatebutton.Image = (Image)resources.GetObject("updatebutton.Image");
            updatebutton.Location = new Point(28, 169);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(135, 42);
            updatebutton.TabIndex = 4;
            updatebutton.Text = "UPDATE";
            updatebutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click;
            // 
            // IDtextBox
            // 
            IDtextBox.Location = new Point(120, 34);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.ReadOnly = true;
            IDtextBox.Size = new Size(196, 23);
            IDtextBox.TabIndex = 10;
            // 
            // discounttextBox
            // 
            discounttextBox.Location = new Point(120, 121);
            discounttextBox.Name = "discounttextBox";
            discounttextBox.Size = new Size(196, 23);
            discounttextBox.TabIndex = 3;
            // 
            // pricetextBox
            // 
            pricetextBox.Location = new Point(120, 92);
            pricetextBox.Name = "pricetextBox";
            pricetextBox.Size = new Size(196, 23);
            pricetextBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 34);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 0;
            label5.Text = "ID";
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(120, 63);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(196, 23);
            nametextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 121);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 0;
            label4.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 92);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 0;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 65);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 184);
            label1.Name = "label1";
            label1.Size = new Size(127, 27);
            label1.TabIndex = 18;
            label1.Text = "Edit Item";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(132, -58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(347, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 447);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(619, 150);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // EditItemcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 609);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            Name = "EditItemcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditItemcs";
            Load += EditItemcs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button updatebutton;
        private TextBox IDtextBox;
        private TextBox discounttextBox;
        private TextBox pricetextBox;
        private Label label5;
        private TextBox nametextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}