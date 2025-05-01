namespace Project
{
    partial class addItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addItem));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            insertbutton = new Button();
            discounttextBox = new TextBox();
            pricetextBox = new TextBox();
            nametextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(84, -60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(347, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 178);
            label1.Name = "label1";
            label1.Size = new Size(126, 27);
            label1.TabIndex = 15;
            label1.Text = "Add Item";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(insertbutton);
            panel1.Controls.Add(discounttextBox);
            panel1.Controls.Add(pricetextBox);
            panel1.Controls.Add(nametextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(84, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 196);
            panel1.TabIndex = 16;
            // 
            // insertbutton
            // 
            insertbutton.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertbutton.Image = (Image)resources.GetObject("insertbutton.Image");
            insertbutton.Location = new Point(120, 151);
            insertbutton.Name = "insertbutton";
            insertbutton.Size = new Size(135, 42);
            insertbutton.TabIndex = 3;
            insertbutton.Text = "INSERT";
            insertbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            insertbutton.UseVisualStyleBackColor = true;
            insertbutton.Click += insertbutton_Click;
            // 
            // discounttextBox
            // 
            discounttextBox.Location = new Point(120, 109);
            discounttextBox.Name = "discounttextBox";
            discounttextBox.Size = new Size(196, 23);
            discounttextBox.TabIndex = 2;
            // 
            // pricetextBox
            // 
            pricetextBox.Location = new Point(120, 68);
            pricetextBox.Name = "pricetextBox";
            pricetextBox.Size = new Size(196, 23);
            pricetextBox.TabIndex = 1;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(120, 30);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(196, 23);
            nametextBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 109);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 0;
            label4.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 68);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 0;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 30);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // addItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 439);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "addItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addItem";
            Load += addItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private Button insertbutton;
        private TextBox discounttextBox;
        private TextBox pricetextBox;
        private TextBox nametextBox;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}