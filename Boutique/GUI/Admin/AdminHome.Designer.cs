//namespace Boutique.GUI
//{
//    partial class AdminHome
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

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            menuStrip1 = new MenuStrip();
//            nhanVienToolStripMenuItem = new ToolStripMenuItem();
//            danhSachNhanVienToolStripMenuItem = new ToolStripMenuItem();
//            luongNhanVienToolStripMenuItem = new ToolStripMenuItem();
//            sanPhamToolStripMenuItem = new ToolStripMenuItem();
//            doanhThuToolStripMenuItem = new ToolStripMenuItem();
//            dangXuatToolStripMenuItem = new ToolStripMenuItem();
//            panelAdmin = new Panel();
//            menuStrip1.SuspendLayout();
//            SuspendLayout();
//            // 
//            // menuStrip1
//            // 
//            menuStrip1.BackColor = Color.LightSteelBlue;
//            menuStrip1.Items.AddRange(new ToolStripItem[] { nhanVienToolStripMenuItem, sanPhamToolStripMenuItem, doanhThuToolStripMenuItem, dangXuatToolStripMenuItem });
//            menuStrip1.Location = new Point(0, 0);
//            menuStrip1.Name = "menuStrip1";
//            menuStrip1.Size = new Size(903, 35);
//            menuStrip1.TabIndex = 0;
//            menuStrip1.Text = "menuStrip1";
//            // 
//            // nhanVienToolStripMenuItem
//            // 
//            nhanVienToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSachNhanVienToolStripMenuItem, luongNhanVienToolStripMenuItem });
//            nhanVienToolStripMenuItem.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
//            nhanVienToolStripMenuItem.Size = new Size(132, 31);
//            nhanVienToolStripMenuItem.Text = "Nhân viên";
//            // 
//            // danhSachNhanVienToolStripMenuItem
//            // 
//            danhSachNhanVienToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            danhSachNhanVienToolStripMenuItem.Name = "danhSachNhanVienToolStripMenuItem";
//            danhSachNhanVienToolStripMenuItem.Size = new Size(223, 22);
//            danhSachNhanVienToolStripMenuItem.Text = "Danh sách nhân viên";
//            danhSachNhanVienToolStripMenuItem.Click += danhSachNhanVienToolStripMenuItem_Click;
//            // 
//            // luongNhanVienToolStripMenuItem
//            // 
//            luongNhanVienToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            luongNhanVienToolStripMenuItem.Name = "luongNhanVienToolStripMenuItem";
//            luongNhanVienToolStripMenuItem.Size = new Size(223, 22);
//            luongNhanVienToolStripMenuItem.Text = "Lương nhân viên";
//            // 
//            // sanPhamToolStripMenuItem
//            // 
//            sanPhamToolStripMenuItem.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
//            sanPhamToolStripMenuItem.Size = new Size(135, 31);
//            sanPhamToolStripMenuItem.Text = "Sản phẩm";
//            // 
//            // doanhThuToolStripMenuItem
//            // 
//            doanhThuToolStripMenuItem.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
//            doanhThuToolStripMenuItem.Size = new Size(137, 31);
//            doanhThuToolStripMenuItem.Text = "Doanh thu";
//            // 
//            // dangXuatToolStripMenuItem
//            // 
//            dangXuatToolStripMenuItem.Font = new Font("Arial", 18F);
//            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
//            dangXuatToolStripMenuItem.Size = new Size(134, 31);
//            dangXuatToolStripMenuItem.Text = "Đăng xuất";
//            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
//            // 
//            // panelAdmin
//            // 
//            panelAdmin.Dock = DockStyle.Fill;
//            panelAdmin.Location = new Point(0, 35);
//            panelAdmin.Name = "panelAdmin";
//            panelAdmin.Size = new Size(903, 472);
//            panelAdmin.TabIndex = 1;
//            // 
//            // AdminHome
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(903, 507);
//            Controls.Add(panelAdmin);
//            Controls.Add(menuStrip1);
//            FormBorderStyle = FormBorderStyle.None;
//            MainMenuStrip = menuStrip1;
//            Name = "AdminHome";
//            Text = "Admin";
//            WindowState = FormWindowState.Maximized;
//            Load += AdminHome_Load;
//            menuStrip1.ResumeLayout(false);
//            menuStrip1.PerformLayout();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private MenuStrip menuStrip1;
//        private ToolStripMenuItem nhanVienToolStripMenuItem;
//        private ToolStripMenuItem danhSachNhanVienToolStripMenuItem;
//        private ToolStripMenuItem luongNhanVienToolStripMenuItem;
//        private ToolStripMenuItem sanPhamToolStripMenuItem;
//        private ToolStripMenuItem doanhThuToolStripMenuItem;
//        private Panel panelAdmin;
//        private ToolStripMenuItem dangXuatToolStripMenuItem;
//    }
//}