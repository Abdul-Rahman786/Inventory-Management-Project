namespace Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            loginlabel = new Label();
            label1 = new Label();
            label2 = new Label();
            usernametextBox = new TextBox();
            passwordtextBox = new TextBox();
            label3 = new Label();
            showpasscheckBox = new CheckBox();
            loginbutton = new Button();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginlabel
            // 
            loginlabel.AutoSize = true;
            loginlabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginlabel.Location = new Point(161, 9);
            loginlabel.Name = "loginlabel";
            loginlabel.Size = new Size(126, 30);
            loginlabel.TabIndex = 0;
            loginlabel.Text = "Login Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(196, 118);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(196, 147);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // usernametextBox
            // 
            usernametextBox.Location = new Point(309, 118);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(139, 23);
            usernametextBox.TabIndex = 0;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(309, 147);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(139, 23);
            passwordtextBox.TabIndex = 1;
            passwordtextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(196, 81);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 0;
            label3.Text = "Login";
            // 
            // showpasscheckBox
            // 
            showpasscheckBox.AutoSize = true;
            showpasscheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showpasscheckBox.Location = new Point(309, 176);
            showpasscheckBox.Name = "showpasscheckBox";
            showpasscheckBox.Size = new Size(112, 19);
            showpasscheckBox.TabIndex = 2;
            showpasscheckBox.Text = "Show Password";
            showpasscheckBox.UseVisualStyleBackColor = true;
            showpasscheckBox.CheckedChanged += showpasscheckBox_CheckedChanged;
            // 
            // loginbutton
            // 
            loginbutton.BackgroundImage = (Image)resources.GetObject("loginbutton.BackgroundImage");
            loginbutton.BackgroundImageLayout = ImageLayout.Center;
            loginbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.Image = (Image)resources.GetObject("loginbutton.Image");
            loginbutton.ImageAlign = ContentAlignment.MiddleLeft;
            loginbutton.Location = new Point(196, 201);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(252, 50);
            loginbutton.TabIndex = 3;
            loginbutton.Text = "LOGIN";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(216, 254);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(252, 23);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Not registered yet? click here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 338);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(loginbutton);
            Controls.Add(showpasscheckBox);
            Controls.Add(passwordtextBox);
            Controls.Add(usernametextBox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(loginlabel);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginlabel;
        private Label label1;
        private Label label2;
        private TextBox usernametextBox;
        private TextBox passwordtextBox;
        private Label label3;
        private CheckBox showpasscheckBox;
        private Button loginbutton;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}