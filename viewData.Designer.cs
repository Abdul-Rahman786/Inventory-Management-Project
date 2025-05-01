namespace Project
{
    partial class viewData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewData));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            additembutton = new Button();
            updateitembutton = new Button();
            deleteitembutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 169);
            label1.Name = "label1";
            label1.Size = new Size(141, 27);
            label1.TabIndex = 20;
            label1.Text = "View Data";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(152, -69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(347, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(601, 238);
            dataGridView1.TabIndex = 21;
            // 
            // additembutton
            // 
            additembutton.Anchor = AnchorStyles.Left;
            additembutton.Font = new Font("Cooper Black", 12F);
            additembutton.Location = new Point(63, 452);
            additembutton.Name = "additembutton";
            additembutton.Size = new Size(120, 45);
            additembutton.TabIndex = 22;
            additembutton.Text = "Add Item";
            additembutton.UseVisualStyleBackColor = true;
            additembutton.Click += additembutton_Click;
            // 
            // updateitembutton
            // 
            updateitembutton.Anchor = AnchorStyles.Left;
            updateitembutton.Font = new Font("Cooper Black", 12F);
            updateitembutton.Location = new Point(258, 452);
            updateitembutton.Name = "updateitembutton";
            updateitembutton.Size = new Size(120, 45);
            updateitembutton.TabIndex = 22;
            updateitembutton.Text = "Update Item";
            updateitembutton.UseVisualStyleBackColor = true;
            updateitembutton.Click += updateitembutton_Click;
            // 
            // deleteitembutton
            // 
            deleteitembutton.Anchor = AnchorStyles.Left;
            deleteitembutton.Font = new Font("Cooper Black", 12F);
            deleteitembutton.Location = new Point(448, 452);
            deleteitembutton.Name = "deleteitembutton";
            deleteitembutton.Size = new Size(129, 45);
            deleteitembutton.TabIndex = 22;
            deleteitembutton.Text = "Delete Item";
            deleteitembutton.UseVisualStyleBackColor = true;
            deleteitembutton.Click += deleteitembutton_Click;
            // 
            // viewData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 509);
            Controls.Add(deleteitembutton);
            Controls.Add(updateitembutton);
            Controls.Add(additembutton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "viewData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewData";
            Activated += viewData_Activated;
            Load += viewData_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button additembutton;
        private Button updateitembutton;
        private Button deleteitembutton;
    }
}