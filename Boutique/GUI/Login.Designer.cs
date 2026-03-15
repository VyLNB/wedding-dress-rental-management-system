namespace Boutique
{
    partial class Login
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            nameBanner = new Label();
            signup_btn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            login_showpass = new CheckBox();
            login_password = new TextBox();
            login_username = new TextBox();
            label3 = new Label();
            username = new Label();
            login_btn = new Button();
            forgotPassword = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(nameBanner);
            panel1.Controls.Add(signup_btn);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 339);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(85, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // nameBanner
            // 
            nameBanner.AutoSize = true;
            nameBanner.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameBanner.Location = new Point(87, 176);
            nameBanner.Name = "nameBanner";
            nameBanner.Size = new Size(98, 30);
            nameBanner.TabIndex = 6;
            nameBanner.Text = "Boutique";
            // 
            // signup_btn
            // 
            signup_btn.BackColor = SystemColors.GradientActiveCaption;
            signup_btn.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.Location = new Point(11, 292);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(264, 31);
            signup_btn.TabIndex = 5;
            signup_btn.Text = "SIGN UP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 54);
            label1.Name = "label1";
            label1.Size = new Size(248, 34);
            label1.TabIndex = 1;
            label1.Text = "LOGIN ACCOUNT";
            // 
            // panel2
            // 
            panel2.Controls.Add(forgotPassword);
            panel2.Controls.Add(login_showpass);
            panel2.Controls.Add(login_password);
            panel2.Controls.Add(login_username);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(username);
            panel2.Location = new Point(303, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 139);
            panel2.TabIndex = 2;
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showpass.Location = new Point(18, 117);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(123, 19);
            login_showpass.TabIndex = 3;
            login_showpass.Text = "Show Password?";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += login_showpass_CheckedChanged;
            // 
            // login_password
            // 
            login_password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(12, 89);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(280, 26);
            login_password.TabIndex = 2;
            // 
            // login_username
            // 
            login_username.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(12, 36);
            login_username.Name = "login_username";
            login_username.Size = new Size(280, 26);
            login_username.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(12, 13);
            username.Name = "username";
            username.Size = new Size(90, 19);
            username.TabIndex = 0;
            username.Text = "User Name";
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.GradientActiveCaption;
            login_btn.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(502, 266);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(93, 31);
            login_btn.TabIndex = 4;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // forgotPassword
            // 
            forgotPassword.AutoSize = true;
            forgotPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPassword.Location = new Point(191, 118);
            forgotPassword.Name = "forgotPassword";
            forgotPassword.Size = new Size(101, 15);
            forgotPassword.TabIndex = 4;
            forgotPassword.TabStop = true;
            forgotPassword.Text = "Forgot Password";
            forgotPassword.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 335);
            Controls.Add(login_btn);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Login_FormClosed;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label username;
        private TextBox login_username;
        private CheckBox login_showpass;
        private TextBox login_password;
        private PictureBox pictureBox1;
        private Label nameBanner;
        private Button signup_btn;
        private Button login_btn;
        private LinkLabel forgotPassword;
    }
}
