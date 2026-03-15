namespace Boutique.GUI
{
    partial class StaffHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHome));
            panel1 = new Panel();
            signout_btn = new Button();
            thanhtoan_btn = new Button();
            staffName = new Label();
            pictureBox1 = new PictureBox();
            donThue_btn = new Button();
            sanPham_btn = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(signout_btn);
            panel1.Controls.Add(thanhtoan_btn);
            panel1.Controls.Add(staffName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(donThue_btn);
            panel1.Controls.Add(sanPham_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 632);
            panel1.TabIndex = 0;
            // 
            // signout_btn
            // 
            signout_btn.BackColor = SystemColors.ActiveCaption;
            signout_btn.BackgroundImageLayout = ImageLayout.None;
            signout_btn.Dock = DockStyle.Bottom;
            signout_btn.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            signout_btn.FlatAppearance.BorderSize = 2;
            signout_btn.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            signout_btn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            signout_btn.FlatStyle = FlatStyle.Flat;
            signout_btn.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signout_btn.Image = (Image)resources.GetObject("signout_btn.Image");
            signout_btn.ImageAlign = ContentAlignment.MiddleLeft;
            signout_btn.Location = new Point(0, 576);
            signout_btn.Name = "signout_btn";
            signout_btn.Size = new Size(234, 56);
            signout_btn.TabIndex = 6;
            signout_btn.UseVisualStyleBackColor = false;
            signout_btn.Click += signout_btn_Click;
            // 
            // thanhtoan_btn
            // 
            thanhtoan_btn.BackColor = SystemColors.GradientInactiveCaption;
            thanhtoan_btn.FlatAppearance.BorderColor = Color.White;
            thanhtoan_btn.FlatAppearance.BorderSize = 2;
            thanhtoan_btn.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            thanhtoan_btn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            thanhtoan_btn.FlatStyle = FlatStyle.Flat;
            thanhtoan_btn.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thanhtoan_btn.Location = new Point(0, 336);
            thanhtoan_btn.Name = "thanhtoan_btn";
            thanhtoan_btn.Size = new Size(223, 38);
            thanhtoan_btn.TabIndex = 4;
            thanhtoan_btn.Text = "Thanh toán";
            thanhtoan_btn.UseVisualStyleBackColor = false;
            thanhtoan_btn.Click += thanhtoan_btn_Click;
            // 
            // staffName
            // 
            staffName.AutoSize = true;
            staffName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staffName.Location = new Point(43, 124);
            staffName.Name = "staffName";
            staffName.Size = new Size(121, 18);
            staffName.TabIndex = 3;
            staffName.Text = "Chào mừng bạn";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // donThue_btn
            // 
            donThue_btn.BackColor = SystemColors.GradientInactiveCaption;
            donThue_btn.FlatAppearance.BorderColor = Color.White;
            donThue_btn.FlatAppearance.BorderSize = 2;
            donThue_btn.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            donThue_btn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            donThue_btn.FlatStyle = FlatStyle.Flat;
            donThue_btn.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            donThue_btn.Location = new Point(0, 275);
            donThue_btn.Name = "donThue_btn";
            donThue_btn.Size = new Size(223, 38);
            donThue_btn.TabIndex = 1;
            donThue_btn.Text = "Đơn thuê";
            donThue_btn.UseVisualStyleBackColor = false;
            donThue_btn.Click += donThue_btn_Click;
            // 
            // sanPham_btn
            // 
            sanPham_btn.BackColor = SystemColors.GradientInactiveCaption;
            sanPham_btn.FlatAppearance.BorderColor = Color.White;
            sanPham_btn.FlatAppearance.BorderSize = 2;
            sanPham_btn.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            sanPham_btn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            sanPham_btn.FlatStyle = FlatStyle.Flat;
            sanPham_btn.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sanPham_btn.Location = new Point(0, 207);
            sanPham_btn.Name = "sanPham_btn";
            sanPham_btn.Size = new Size(223, 38);
            sanPham_btn.TabIndex = 0;
            sanPham_btn.Text = "Sản phẩm";
            sanPham_btn.UseVisualStyleBackColor = false;
            sanPham_btn.Click += sanPham_btn_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(234, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(782, 632);
            panelContainer.TabIndex = 1;
            // 
            // StaffHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 632);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StaffHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            WindowState = FormWindowState.Maximized;
            FormClosed += Home_FormClosed;
            Load += StaffHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button sanPham_btn;
        private Button donThue_btn;
        private Label staffName;
        private PictureBox pictureBox1;
        private Panel panelContainer;
        private Button signout_btn;
        private Button thanhtoan_btn;
    }
}