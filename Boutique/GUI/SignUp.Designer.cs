namespace Boutique.GUI
{
    partial class SignUp
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
            signupbtn = new Button();
            panel2 = new Panel();
            email_txt = new TextBox();
            email = new Label();
            staff_check = new CheckBox();
            admin_check = new CheckBox();
            role = new Label();
            rePassTxt = new TextBox();
            re_enter_pass = new Label();
            signup_password = new TextBox();
            signup_username = new TextBox();
            label3 = new Label();
            username = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            nameBanner = new Label();
            signup_loginbtn = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signupbtn
            // 
            signupbtn.BackColor = SystemColors.GradientActiveCaption;
            signupbtn.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupbtn.Location = new Point(497, 342);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(103, 31);
            signupbtn.TabIndex = 4;
            signupbtn.Text = "SIGNUP";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(email_txt);
            panel2.Controls.Add(email);
            panel2.Controls.Add(staff_check);
            panel2.Controls.Add(admin_check);
            panel2.Controls.Add(role);
            panel2.Controls.Add(rePassTxt);
            panel2.Controls.Add(re_enter_pass);
            panel2.Controls.Add(signup_password);
            panel2.Controls.Add(signup_username);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(username);
            panel2.Location = new Point(308, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 272);
            panel2.TabIndex = 7;
            // 
            // email_txt
            // 
            email_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_txt.Location = new Point(15, 192);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(280, 26);
            email_txt.TabIndex = 10;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(12, 170);
            email.Name = "email";
            email.Size = new Size(49, 19);
            email.TabIndex = 9;
            email.Text = "Email";
            // 
            // staff_check
            // 
            staff_check.AutoSize = true;
            staff_check.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staff_check.Location = new Point(125, 243);
            staff_check.Name = "staff_check";
            staff_check.Size = new Size(62, 23);
            staff_check.TabIndex = 8;
            staff_check.Text = "Staff";
            staff_check.UseVisualStyleBackColor = true;
            staff_check.CheckedChanged += staff_check_CheckedChanged;
            // 
            // admin_check
            // 
            admin_check.AutoSize = true;
            admin_check.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_check.Location = new Point(18, 243);
            admin_check.Name = "admin_check";
            admin_check.Size = new Size(74, 23);
            admin_check.TabIndex = 7;
            admin_check.Text = "Admin";
            admin_check.UseVisualStyleBackColor = true;
            admin_check.CheckedChanged += admin_check_CheckedChanged;
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            role.Location = new Point(15, 221);
            role.Name = "role";
            role.Size = new Size(113, 19);
            role.TabIndex = 6;
            role.Text = "Staff or Admin";
            // 
            // rePassTxt
            // 
            rePassTxt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rePassTxt.Location = new Point(12, 141);
            rePassTxt.Name = "rePassTxt";
            rePassTxt.PasswordChar = '*';
            rePassTxt.Size = new Size(280, 26);
            rePassTxt.TabIndex = 5;
            // 
            // re_enter_pass
            // 
            re_enter_pass.AutoSize = true;
            re_enter_pass.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            re_enter_pass.Location = new Point(12, 118);
            re_enter_pass.Name = "re_enter_pass";
            re_enter_pass.Size = new Size(146, 19);
            re_enter_pass.TabIndex = 4;
            re_enter_pass.Text = "Re-enter password";
            // 
            // signup_password
            // 
            signup_password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_password.Location = new Point(12, 89);
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(280, 26);
            signup_password.TabIndex = 2;
            // 
            // signup_username
            // 
            signup_username.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_username.Location = new Point(12, 36);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(280, 26);
            signup_username.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(12, 14);
            username.Name = "username";
            username.Size = new Size(90, 19);
            username.TabIndex = 0;
            username.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 21);
            label1.Name = "label1";
            label1.Size = new Size(262, 31);
            label1.TabIndex = 6;
            label1.Text = "REGISTER ACCOUNT";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(nameBanner);
            panel1.Controls.Add(signup_loginbtn);
            panel1.Location = new Point(-8, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 388);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(112, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // nameBanner
            // 
            nameBanner.AutoSize = true;
            nameBanner.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameBanner.Location = new Point(112, 187);
            nameBanner.Name = "nameBanner";
            nameBanner.Size = new Size(98, 30);
            nameBanner.TabIndex = 6;
            nameBanner.Text = "Boutique";
            // 
            // signup_loginbtn
            // 
            signup_loginbtn.BackColor = SystemColors.GradientActiveCaption;
            signup_loginbtn.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_loginbtn.Location = new Point(20, 344);
            signup_loginbtn.Name = "signup_loginbtn";
            signup_loginbtn.Size = new Size(274, 31);
            signup_loginbtn.TabIndex = 5;
            signup_loginbtn.Text = "LOGIN";
            signup_loginbtn.UseVisualStyleBackColor = false;
            signup_loginbtn.Click += signup_loginbtn_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 385);
            Controls.Add(signupbtn);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            FormClosed += SignUp_FormClosed;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signupbtn;
        private Panel panel2;
        private TextBox signup_password;
        private TextBox signup_username;
        private Label label3;
        private Label username;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label nameBanner;
        private Button signup_loginbtn;
        private TextBox rePassTxt;
        private Label re_enter_pass;
        private Label role;
        private CheckBox staff_check;
        private CheckBox admin_check;
        private TextBox email_txt;
        private Label email;
    }
}