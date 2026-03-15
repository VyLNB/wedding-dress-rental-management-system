using Boutique.GUI.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique.GUI
{
    public partial class StaffHome : Form
    {
        public StaffHome()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sanPham_btn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            SanPhamStaff sanPhamPg = new SanPhamStaff();
            sanPhamPg.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(sanPhamPg);

            //MessageBox.Show($"Panel Size: {panelContainer.ClientSize}\nUserControl Size: {sanPhamPg.Size}");
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void donThue_btn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            DonThueStaff donThuePg = new DonThueStaff();
            donThuePg.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(donThuePg);
        }

        private void thanhtoan_btn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            ThanhToan thanhToanPg = new ThanhToan();
            thanhToanPg.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(thanhToanPg);
        }

        private void StaffHome_Load(object sender, EventArgs e)
        {

        }
    }
}
