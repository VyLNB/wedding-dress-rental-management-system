//using Boutique.GUI.Admin;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Boutique.GUI
//{
//    public partial class AdminHome : Form
//    {
//        public AdminHome()
//        {
//            InitializeComponent();
//            menuStrip1.Padding = new Padding(10, 20, 10, 20); // Tăng padding trên và dưới
//        }

//        private void ApplyRoundedCorners(MenuStrip menuStrip, int radius)
//        {
//            GraphicsPath path = new GraphicsPath();
//            Rectangle rect = new Rectangle(0, 0, menuStrip.Width, menuStrip.Height);

//            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
//            path.AddArc(rect.Width - radius * 2 - 1, rect.Y, radius * 2, radius * 2, 270, 90);
//            path.AddArc(rect.Width - radius * 2 - 1, rect.Height - radius * 2 - 1, radius * 2, radius * 2, 0, 90);
//            path.AddArc(rect.X, rect.Height - radius * 2 - 1, radius * 2, radius * 2, 90, 90);
//            path.CloseFigure();

//            menuStrip.Region = new Region(path);
//        }

//        private void AdminHome_Load(object sender, EventArgs e)
//        {
//            ApplyRoundedCorners(menuStrip1, 20); // 10 là độ bo góc

//            panelAdmin.Controls.Clear();
//            NhanVien nhanVienPg = new NhanVien();
//            nhanVienPg.Dock = DockStyle.Fill;
//            panelAdmin.Controls.Add(nhanVienPg);
//        }

//        private void danhSachNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            panelAdmin.Controls.Clear();
//            NhanVien nhanVienPg = new NhanVien();
//            nhanVienPg.Dock = DockStyle.Fill;
//            panelAdmin.Controls.Add(nhanVienPg);
//        }

//        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Login loginForm = new Login();
//            loginForm.Show();
//            this.Hide();
//        }
//    }
//}
