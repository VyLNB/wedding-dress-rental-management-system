namespace Boutique.GUI.Admin
{
    partial class frmEditNhanVien
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
            updateNhanVien = new GroupBox();
            emailNhanVien_txt = new TextBox();
            label5 = new Label();
            diaChiNhanVien_txt = new TextBox();
            soDienThoaiNhanVien_txt = new TextBox();
            hoTenNhanVien_txt = new TextBox();
            maNhanVien_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cancel_btn = new Button();
            updateNhanVien_btn = new Button();
            panel1.SuspendLayout();
            updateNhanVien.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(updateNhanVien);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 239);
            panel1.TabIndex = 0;
            // 
            // updateNhanVien
            // 
            updateNhanVien.Controls.Add(emailNhanVien_txt);
            updateNhanVien.Controls.Add(label5);
            updateNhanVien.Controls.Add(diaChiNhanVien_txt);
            updateNhanVien.Controls.Add(soDienThoaiNhanVien_txt);
            updateNhanVien.Controls.Add(hoTenNhanVien_txt);
            updateNhanVien.Controls.Add(maNhanVien_txt);
            updateNhanVien.Controls.Add(label4);
            updateNhanVien.Controls.Add(label3);
            updateNhanVien.Controls.Add(label2);
            updateNhanVien.Controls.Add(label1);
            updateNhanVien.Dock = DockStyle.Fill;
            updateNhanVien.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateNhanVien.Location = new Point(0, 0);
            updateNhanVien.Name = "updateNhanVien";
            updateNhanVien.Size = new Size(431, 239);
            updateNhanVien.TabIndex = 0;
            updateNhanVien.TabStop = false;
            updateNhanVien.Text = "Cập nhật thông tin";
            // 
            // emailNhanVien_txt
            // 
            emailNhanVien_txt.Location = new Point(148, 207);
            emailNhanVien_txt.Name = "emailNhanVien_txt";
            emailNhanVien_txt.Size = new Size(271, 29);
            emailNhanVien_txt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 214);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // diaChiNhanVien_txt
            // 
            diaChiNhanVien_txt.Location = new Point(148, 159);
            diaChiNhanVien_txt.Name = "diaChiNhanVien_txt";
            diaChiNhanVien_txt.Size = new Size(271, 29);
            diaChiNhanVien_txt.TabIndex = 7;
            // 
            // soDienThoaiNhanVien_txt
            // 
            soDienThoaiNhanVien_txt.Location = new Point(148, 113);
            soDienThoaiNhanVien_txt.Name = "soDienThoaiNhanVien_txt";
            soDienThoaiNhanVien_txt.Size = new Size(271, 29);
            soDienThoaiNhanVien_txt.TabIndex = 6;
            // 
            // hoTenNhanVien_txt
            // 
            hoTenNhanVien_txt.Location = new Point(148, 71);
            hoTenNhanVien_txt.Name = "hoTenNhanVien_txt";
            hoTenNhanVien_txt.Size = new Size(271, 29);
            hoTenNhanVien_txt.TabIndex = 5;
            // 
            // maNhanVien_txt
            // 
            maNhanVien_txt.Location = new Point(148, 33);
            maNhanVien_txt.Name = "maNhanVien_txt";
            maNhanVien_txt.Size = new Size(271, 29);
            maNhanVien_txt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 165);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 119);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            panel2.Controls.Add(cancel_btn);
            panel2.Controls.Add(updateNhanVien_btn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 48);
            panel2.TabIndex = 1;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.SkyBlue;
            cancel_btn.FlatAppearance.BorderSize = 0;
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(211, 6);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(101, 32);
            cancel_btn.TabIndex = 1;
            cancel_btn.Text = "Hủy";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // updateNhanVien_btn
            // 
            updateNhanVien_btn.BackColor = Color.SkyBlue;
            updateNhanVien_btn.FlatAppearance.BorderSize = 0;
            updateNhanVien_btn.FlatStyle = FlatStyle.Flat;
            updateNhanVien_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateNhanVien_btn.Location = new Point(318, 6);
            updateNhanVien_btn.Name = "updateNhanVien_btn";
            updateNhanVien_btn.Size = new Size(101, 32);
            updateNhanVien_btn.TabIndex = 0;
            updateNhanVien_btn.Text = "Cập nhật";
            updateNhanVien_btn.UseVisualStyleBackColor = false;
            updateNhanVien_btn.Click += updateNhanVien_btn_Click;
            // 
            // frmEditNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 287);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditNhanVien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmNhanVien";
            Load += frmEditNhanVien_Load;
            panel1.ResumeLayout(false);
            updateNhanVien.ResumeLayout(false);
            updateNhanVien.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox updateNhanVien;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox diaChiNhanVien_txt;
        private TextBox soDienThoaiNhanVien_txt;
        private TextBox hoTenNhanVien_txt;
        private TextBox maNhanVien_txt;
        private Button updateNhanVien_btn;
        private TextBox emailNhanVien_txt;
        private Label label5;
        private Button cancel_btn;
    }
}