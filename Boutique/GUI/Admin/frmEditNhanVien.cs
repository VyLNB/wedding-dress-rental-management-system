using Boutique.BUS;
using Boutique.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique.GUI.Admin
{
    public partial class frmEditNhanVien : Form
    {
        private NhanVienDTO nhanVienDTO;
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public frmEditNhanVien(NhanVienDTO nhanVien)
        {
            this.nhanVienDTO = nhanVien;
            InitializeComponent();
        }

        private void frmEditNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            maNhanVien_txt.Text = nhanVienDTO.GetStaffID();
            hoTenNhanVien_txt.Text = nhanVienDTO.GetStaffName();
            soDienThoaiNhanVien_txt.Text = nhanVienDTO.GetSoDienThoai();
            diaChiNhanVien_txt.Text = nhanVienDTO.GetDiaChi();
            emailNhanVien_txt.Text = nhanVienDTO.GetStaffEmail();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            NhanVien nhanVienForm = new NhanVien();
            nhanVienForm.Show();
            this.Hide();
        }

        private void updateNhanVien_btn_Click(object sender, EventArgs e)
        {
            string maNhanVien = maNhanVien_txt.Text.Trim();
            string hoTen = hoTenNhanVien_txt.Text.Trim();
            string soDienThoai = soDienThoaiNhanVien_txt.Text.Trim();
            string diaChi = diaChiNhanVien_txt.Text.Trim();
            string email = emailNhanVien_txt.Text.Trim();

            nhanVienDTO = new NhanVienDTO(maNhanVien, hoTen, email, soDienThoai, diaChi);

            bool updateSuccess = nhanVienBUS.UpdateNhanVien(nhanVienDTO);
            if (updateSuccess)
            {
                MessageBox.Show("Employee update successful",
                                        "Notification",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                NhanVien nhanVienForm = new NhanVien();
                nhanVienForm.Show();
                this.Hide();
                LoadNhanVien();
            }
        }
    }
}
