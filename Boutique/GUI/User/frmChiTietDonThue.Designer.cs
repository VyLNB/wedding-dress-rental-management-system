namespace Boutique.GUI.User
{
    partial class frmChiTietDonThue
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
            groupboxChiTiet = new GroupBox();
            updateChiTiet_btn = new Button();
            diaChi_ctdt_txt = new TextBox();
            soDienThoai_ctdt_txt = new TextBox();
            tenKhachHang_ctdt_txt = new TextBox();
            trangThaiDon_ctdt_cbb = new ComboBox();
            maKhachHang_ctdt_txt = new TextBox();
            maDonThue_ctdt_txt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupbox_sp = new GroupBox();
            spDonList = new DataGridView();
            groupboxChiTiet.SuspendLayout();
            groupbox_sp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spDonList).BeginInit();
            SuspendLayout();
            // 
            // groupboxChiTiet
            // 
            groupboxChiTiet.Controls.Add(updateChiTiet_btn);
            groupboxChiTiet.Controls.Add(diaChi_ctdt_txt);
            groupboxChiTiet.Controls.Add(soDienThoai_ctdt_txt);
            groupboxChiTiet.Controls.Add(tenKhachHang_ctdt_txt);
            groupboxChiTiet.Controls.Add(trangThaiDon_ctdt_cbb);
            groupboxChiTiet.Controls.Add(maKhachHang_ctdt_txt);
            groupboxChiTiet.Controls.Add(maDonThue_ctdt_txt);
            groupboxChiTiet.Controls.Add(label6);
            groupboxChiTiet.Controls.Add(label5);
            groupboxChiTiet.Controls.Add(label4);
            groupboxChiTiet.Controls.Add(label3);
            groupboxChiTiet.Controls.Add(label2);
            groupboxChiTiet.Controls.Add(label1);
            groupboxChiTiet.Dock = DockStyle.Top;
            groupboxChiTiet.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupboxChiTiet.Location = new Point(0, 0);
            groupboxChiTiet.Name = "groupboxChiTiet";
            groupboxChiTiet.Size = new Size(602, 193);
            groupboxChiTiet.TabIndex = 0;
            groupboxChiTiet.TabStop = false;
            groupboxChiTiet.Text = "Chi tiết đơn thuê";
            // 
            // updateChiTiet_btn
            // 
            updateChiTiet_btn.BackColor = Color.PowderBlue;
            updateChiTiet_btn.FlatAppearance.BorderSize = 0;
            updateChiTiet_btn.FlatStyle = FlatStyle.Flat;
            updateChiTiet_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateChiTiet_btn.Location = new Point(490, 161);
            updateChiTiet_btn.Name = "updateChiTiet_btn";
            updateChiTiet_btn.Size = new Size(100, 26);
            updateChiTiet_btn.TabIndex = 12;
            updateChiTiet_btn.Text = "Cập nhật";
            updateChiTiet_btn.UseVisualStyleBackColor = false;
            updateChiTiet_btn.Click += updateChiTiet_btn_Click;
            // 
            // diaChi_ctdt_txt
            // 
            diaChi_ctdt_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diaChi_ctdt_txt.Location = new Point(415, 118);
            diaChi_ctdt_txt.Name = "diaChi_ctdt_txt";
            diaChi_ctdt_txt.Size = new Size(175, 26);
            diaChi_ctdt_txt.TabIndex = 11;
            // 
            // soDienThoai_ctdt_txt
            // 
            soDienThoai_ctdt_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soDienThoai_ctdt_txt.Location = new Point(415, 78);
            soDienThoai_ctdt_txt.Name = "soDienThoai_ctdt_txt";
            soDienThoai_ctdt_txt.Size = new Size(175, 26);
            soDienThoai_ctdt_txt.TabIndex = 10;
            // 
            // tenKhachHang_ctdt_txt
            // 
            tenKhachHang_ctdt_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenKhachHang_ctdt_txt.Location = new Point(415, 40);
            tenKhachHang_ctdt_txt.Name = "tenKhachHang_ctdt_txt";
            tenKhachHang_ctdt_txt.Size = new Size(175, 26);
            tenKhachHang_ctdt_txt.TabIndex = 9;
            // 
            // trangThaiDon_ctdt_cbb
            // 
            trangThaiDon_ctdt_cbb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trangThaiDon_ctdt_cbb.FormattingEnabled = true;
            trangThaiDon_ctdt_cbb.Items.AddRange(new object[] { "Đang xử lý", "Đã xác nhận", "Đã nhận", "Đã trả ", "Hoàn thành", "Hủy" });
            trangThaiDon_ctdt_cbb.Location = new Point(139, 118);
            trangThaiDon_ctdt_cbb.Name = "trangThaiDon_ctdt_cbb";
            trangThaiDon_ctdt_cbb.Size = new Size(134, 26);
            trangThaiDon_ctdt_cbb.TabIndex = 8;
            // 
            // maKhachHang_ctdt_txt
            // 
            maKhachHang_ctdt_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maKhachHang_ctdt_txt.Location = new Point(139, 78);
            maKhachHang_ctdt_txt.Name = "maKhachHang_ctdt_txt";
            maKhachHang_ctdt_txt.Size = new Size(134, 26);
            maKhachHang_ctdt_txt.TabIndex = 7;
            // 
            // maDonThue_ctdt_txt
            // 
            maDonThue_ctdt_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maDonThue_ctdt_txt.Location = new Point(139, 40);
            maDonThue_ctdt_txt.Name = "maDonThue_ctdt_txt";
            maDonThue_ctdt_txt.Size = new Size(134, 26);
            maDonThue_ctdt_txt.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 118);
            label6.Name = "label6";
            label6.Size = new Size(108, 18);
            label6.TabIndex = 5;
            label6.Text = "Trạng thái đơn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(292, 118);
            label5.Name = "label5";
            label5.Size = new Size(57, 18);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(292, 78);
            label4.Name = "label4";
            label4.Size = new Size(100, 18);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 43);
            label3.Name = "label3";
            label3.Size = new Size(117, 18);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(113, 18);
            label2.TabIndex = 1;
            label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(95, 18);
            label1.TabIndex = 0;
            label1.Text = "Mã đơn thuê";
            // 
            // groupbox_sp
            // 
            groupbox_sp.Controls.Add(spDonList);
            groupbox_sp.Dock = DockStyle.Fill;
            groupbox_sp.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupbox_sp.Location = new Point(0, 193);
            groupbox_sp.Name = "groupbox_sp";
            groupbox_sp.Size = new Size(602, 318);
            groupbox_sp.TabIndex = 1;
            groupbox_sp.TabStop = false;
            groupbox_sp.Text = "Sản phẩm trong đơn";
            // 
            // spDonList
            // 
            spDonList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            spDonList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            spDonList.Dock = DockStyle.Fill;
            spDonList.Location = new Point(3, 25);
            spDonList.Name = "spDonList";
            spDonList.Size = new Size(596, 290);
            spDonList.TabIndex = 0;
            // 
            // frmChiTietDonThue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 511);
            Controls.Add(groupbox_sp);
            Controls.Add(groupboxChiTiet);
            Name = "frmChiTietDonThue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết đơn thuê";
            Load += frmChiTietDonThue_Load;
            groupboxChiTiet.ResumeLayout(false);
            groupboxChiTiet.PerformLayout();
            groupbox_sp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spDonList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupboxChiTiet;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox soDienThoai_ctdt_txt;
        private TextBox tenKhachHang_ctdt_txt;
        private ComboBox trangThaiDon_ctdt_cbb;
        private TextBox maKhachHang_ctdt_txt;
        private TextBox maDonThue_ctdt_txt;
        private Label label6;
        private TextBox diaChi_ctdt_txt;
        private GroupBox groupbox_sp;
        private DataGridView spDonList;
        private Button updateChiTiet_btn;
    }
}