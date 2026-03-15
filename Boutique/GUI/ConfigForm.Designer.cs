namespace Boutique.GUI
{
    partial class ConfigForm
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
            panel1 = new Panel();
            showPassword_config = new CheckBox();
            winAuthen_check = new CheckBox();
            password_config_txt = new TextBox();
            uid_txt = new TextBox();
            database_txt = new TextBox();
            server_txt = new TextBox();
            password = new Label();
            uid = new Label();
            database = new Label();
            server = new Label();
            save_config_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(showPassword_config);
            panel1.Controls.Add(winAuthen_check);
            panel1.Controls.Add(password_config_txt);
            panel1.Controls.Add(uid_txt);
            panel1.Controls.Add(database_txt);
            panel1.Controls.Add(server_txt);
            panel1.Controls.Add(password);
            panel1.Controls.Add(uid);
            panel1.Controls.Add(database);
            panel1.Controls.Add(server);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 210);
            panel1.TabIndex = 0;
            // 
            // showPassword_config
            // 
            showPassword_config.AutoSize = true;
            showPassword_config.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPassword_config.Location = new Point(133, 174);
            showPassword_config.Name = "showPassword_config";
            showPassword_config.Size = new Size(119, 20);
            showPassword_config.TabIndex = 9;
            showPassword_config.Text = "Show Password";
            showPassword_config.UseVisualStyleBackColor = true;
            // 
            // winAuthen_check
            // 
            winAuthen_check.AutoSize = true;
            winAuthen_check.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winAuthen_check.Location = new Point(299, 175);
            winAuthen_check.Name = "winAuthen_check";
            winAuthen_check.Size = new Size(158, 20);
            winAuthen_check.TabIndex = 8;
            winAuthen_check.Text = "Window Authentication";
            winAuthen_check.UseVisualStyleBackColor = true;
            winAuthen_check.CheckedChanged += winAuthen_check_CheckedChanged;
            // 
            // password_config_txt
            // 
            password_config_txt.Location = new Point(133, 145);
            password_config_txt.Name = "password_config_txt";
            password_config_txt.PasswordChar = '*';
            password_config_txt.Size = new Size(324, 23);
            password_config_txt.TabIndex = 7;
            // 
            // uid_txt
            // 
            uid_txt.Location = new Point(133, 107);
            uid_txt.Name = "uid_txt";
            uid_txt.Size = new Size(324, 23);
            uid_txt.TabIndex = 6;
            // 
            // database_txt
            // 
            database_txt.Location = new Point(133, 66);
            database_txt.Name = "database_txt";
            database_txt.Size = new Size(324, 23);
            database_txt.TabIndex = 5;
            // 
            // server_txt
            // 
            server_txt.Location = new Point(133, 26);
            server_txt.Name = "server_txt";
            server_txt.Size = new Size(324, 23);
            server_txt.TabIndex = 4;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(12, 142);
            password.Name = "password";
            password.Size = new Size(94, 22);
            password.TabIndex = 3;
            password.Text = "Password";
            // 
            // uid
            // 
            uid.AutoSize = true;
            uid.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uid.Location = new Point(12, 104);
            uid.Name = "uid";
            uid.Size = new Size(75, 22);
            uid.TabIndex = 2;
            uid.Text = "User ID";
            // 
            // database
            // 
            database.AutoSize = true;
            database.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            database.Location = new Point(12, 63);
            database.Name = "database";
            database.Size = new Size(91, 22);
            database.TabIndex = 1;
            database.Text = "Database";
            // 
            // server
            // 
            server.AutoSize = true;
            server.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            server.Location = new Point(12, 23);
            server.Name = "server";
            server.Size = new Size(66, 22);
            server.TabIndex = 0;
            server.Text = "Server";
            // 
            // save_config_btn
            // 
            save_config_btn.FlatAppearance.MouseDownBackColor = Color.White;
            save_config_btn.FlatAppearance.MouseOverBackColor = Color.White;
            save_config_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save_config_btn.Location = new Point(366, 216);
            save_config_btn.Name = "save_config_btn";
            save_config_btn.Size = new Size(91, 29);
            save_config_btn.TabIndex = 1;
            save_config_btn.Text = "Save";
            save_config_btn.UseVisualStyleBackColor = true;
            save_config_btn.Click += save_config_btn_Click;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 257);
            Controls.Add(save_config_btn);
            Controls.Add(panel1);
            Name = "ConfigForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Config Form";
            Load += ConFigForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label server;
        private TextBox server_txt;
        private Label password;
        private Label uid;
        private Label database;
        private CheckBox showPassword_config;
        private CheckBox winAuthen_check;
        private TextBox password_config_txt;
        private TextBox uid_txt;
        private TextBox database_txt;
        private Button save_config_btn;
    }
}