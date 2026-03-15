//namespace Boutique.GUI.Admin.All_User_Control
//{
//    partial class UC_Setting
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.labelTitle = new System.Windows.Forms.Label();
//            this.btnSaveSettings = new Guna.UI2.WinForms.Guna2Button();
//            this.txtSetting1 = new Guna.UI2.WinForms.Guna2TextBox();
//            this.labelSetting1 = new System.Windows.Forms.Label();
//            this.SuspendLayout();
//            // 
//            // labelTitle
//            // 
//            this.labelTitle.AutoSize = true;
//            this.labelTitle.Font = new System.Drawing.Font("Noto Serif JP", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
//            this.labelTitle.ForeColor = System.Drawing.Color.Black;
//            this.labelTitle.Location = new System.Drawing.Point(20, 20);
//            this.labelTitle.Name = "labelTitle";
//            this.labelTitle.Size = new System.Drawing.Size(300, 76);
//            this.labelTitle.TabIndex = 0;
//            this.labelTitle.Text = "Cài đặt hệ thống";
//            // 
//            // labelSetting1
//            // 
//            this.labelSetting1.AutoSize = true;
//            this.labelSetting1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
//            this.labelSetting1.Location = new System.Drawing.Point(30, 120);
//            this.labelSetting1.Name = "labelSetting1";
//            this.labelSetting1.Size = new System.Drawing.Size(150, 41);
//            this.labelSetting1.TabIndex = 1;
//            this.labelSetting1.Text = "Cài đặt 1:";
//            // 
//            // txtSetting1
//            // 
//            this.txtSetting1.Cursor = System.Windows.Forms.Cursors.IBeam;
//            this.txtSetting1.DefaultText = "";
//            this.txtSetting1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
//            this.txtSetting1.DisabledState.FillColor = System.Drawing.Color.LightGray;
//            this.txtSetting1.DisabledState.ForeColor = System.Drawing.Color.Gray;
//            this.txtSetting1.Font = new System.Drawing.Font("Segoe UI", 10.875F);
//            this.txtSetting1.Location = new System.Drawing.Point(200, 120);
//            this.txtSetting1.Name = "txtSetting1";
//            this.txtSetting1.Size = new System.Drawing.Size(400, 50);
//            this.txtSetting1.TabIndex = 2;
//            // 
//            // btnSaveSettings
//            // 
//            this.btnSaveSettings.BorderRadius = 18;
//            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
//            this.btnSaveSettings.Location = new System.Drawing.Point(200, 200);
//            this.btnSaveSettings.Name = "btnSaveSettings";
//            this.btnSaveSettings.Size = new System.Drawing.Size(200, 50);
//            this.btnSaveSettings.TabIndex = 3;
//            this.btnSaveSettings.Text = "Lưu cài đặt";
//            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
//            // 
//            // UC_Setting
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.btnSaveSettings);
//            this.Controls.Add(this.txtSetting1);
//            this.Controls.Add(this.labelSetting1);
//            this.Controls.Add(this.labelTitle);
//            this.Name = "UC_Setting";
//            this.Size = new System.Drawing.Size(800, 400);
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }

//        #endregion

//        private System.Windows.Forms.Label labelTitle;
//        private System.Windows.Forms.Label labelSetting1;
//        private Guna.UI2.WinForms.Guna2TextBox txtSetting1;
//        private Guna.UI2.WinForms.Guna2Button btnSaveSettings;


//    }
//}

namespace Boutique.GUI.Admin.All_User_Control
{
    partial class UC_Setting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            //this.toggleDarkMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelDarkMode = new System.Windows.Forms.Label();
            this.comboBoxFontStyle = new System.Windows.Forms.ComboBox();
            this.labelFontStyle = new System.Windows.Forms.Label();
            this.btnSaveSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestart = new Guna.UI2.WinForms.Guna2Button(); // Thêm nút Restart
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Noto Serif JP", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(300, 76);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Cài đặt hệ thống";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Vietnamese"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(200, 120);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(200, 28);
            this.comboBoxLanguage.TabIndex = 1;
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelLanguage.Location = new System.Drawing.Point(30, 120);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(120, 41);
            this.labelLanguage.TabIndex = 2;
            this.labelLanguage.Text = "Ngôn ngữ:";
            // 
            // toggleDarkMode
            // 
            //this.toggleDarkMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.toggleDarkMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.toggleDarkMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            //this.toggleDarkMode.CheckedState.InnerColor = System.Drawing.Color.White;
            //this.toggleDarkMode.Location = new System.Drawing.Point(200, 180);
            //this.toggleDarkMode.Name = "toggleDarkMode";
            //this.toggleDarkMode.Size = new System.Drawing.Size(50, 25);
            //this.toggleDarkMode.TabIndex = 3;
            //this.toggleDarkMode.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            //this.toggleDarkMode.UncheckedState.FillColor = System.Drawing.Color.DarkGray;
            //this.toggleDarkMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            //this.toggleDarkMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // labelDarkMode
            // 
            //this.labelDarkMode.AutoSize = true;
            //this.labelDarkMode.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            //this.labelDarkMode.Location = new System.Drawing.Point(30, 180);
            //this.labelDarkMode.Name = "labelDarkMode";
            //this.labelDarkMode.Size = new System.Drawing.Size(150, 41);
            //this.labelDarkMode.TabIndex = 4;
            //this.labelDarkMode.Text = "Chế độ tối:";
            // 
            // comboBoxFontStyle
            // 
            this.comboBoxFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontStyle.FormattingEnabled = true;
            this.comboBoxFontStyle.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Calibri"});
            this.comboBoxFontStyle.Location = new System.Drawing.Point(200, 240);
            this.comboBoxFontStyle.Name = "comboBoxFontStyle";
            this.comboBoxFontStyle.Size = new System.Drawing.Size(200, 28);
            this.comboBoxFontStyle.TabIndex = 5;
            // 
            // labelFontStyle
            // 
            this.labelFontStyle.AutoSize = true;
            this.labelFontStyle.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelFontStyle.Location = new System.Drawing.Point(30, 240);
            this.labelFontStyle.Name = "labelFontStyle";
            this.labelFontStyle.Size = new System.Drawing.Size(120, 41);
            this.labelFontStyle.TabIndex = 6;
            this.labelFontStyle.Text = "Kiểu chữ:";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BorderRadius = 18;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSaveSettings.Location = new System.Drawing.Point(50, 300);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(150, 50);
            this.btnSaveSettings.TabIndex = 7;
            this.btnSaveSettings.Text = "Lưu";
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 18;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Location = new System.Drawing.Point(250, 300);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 50);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BorderRadius = 18;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRestart.Location = new System.Drawing.Point(450, 300);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 50);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Khởi động lại";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // UC_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.labelFontStyle);
            this.Controls.Add(this.comboBoxFontStyle);
            this.Controls.Add(this.labelDarkMode);
            //this.Controls.Add(this.toggleDarkMode);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_Setting";
            this.Size = new System.Drawing.Size(800, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

            this.comboBoxThemeMode = new System.Windows.Forms.ComboBox();
            this.labelThemeMode = new System.Windows.Forms.Label();

            // 
            // labelThemeMode
            // 
            this.labelThemeMode.AutoSize = true;
            this.labelThemeMode.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThemeMode.Location = new System.Drawing.Point(40, 230);
            this.labelThemeMode.Name = "labelThemeMode";
            this.labelThemeMode.Size = new System.Drawing.Size(150, 41);
            this.labelThemeMode.TabIndex = 4;
            this.labelThemeMode.Text = "Chế độ màu:";
            // 
            // comboBoxThemeMode
            // 
            this.comboBoxThemeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThemeMode.FormattingEnabled = true;
            this.comboBoxThemeMode.Items.AddRange(new object[] {
                "Light",
                "Dark",
                "Medium"});
            this.comboBoxThemeMode.Location = new System.Drawing.Point(260, 230);
            this.comboBoxThemeMode.Name = "comboBoxThemeMode";
            this.comboBoxThemeMode.Size = new System.Drawing.Size(200, 28);
            this.comboBoxThemeMode.TabIndex = 5;

            // Add to form
            this.Controls.Add(this.labelThemeMode);
            this.Controls.Add(this.comboBoxThemeMode);
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelLanguage;
        //private Guna.UI2.WinForms.Guna2ToggleSwitch toggleDarkMode;
        private System.Windows.Forms.Label labelDarkMode;
        private System.Windows.Forms.ComboBox comboBoxFontStyle;
        private System.Windows.Forms.Label labelFontStyle;
        private Guna.UI2.WinForms.Guna2Button btnSaveSettings;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnRestart; // Thêm khai báo nút Restart
        private System.Windows.Forms.ComboBox comboBoxThemeMode;
        private System.Windows.Forms.Label labelThemeMode;
    }
}

