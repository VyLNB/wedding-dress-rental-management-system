using Boutique.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique.GUI.User
{
    public partial class frmChiTietDonThue : Form
    {

        private ChiTietDonThueBUS chiTietDonThueBUS = new ChiTietDonThueBUS();
        private string maDonThue;
        public frmChiTietDonThue(string maDonThue)
        {
            InitializeComponent();
            this.maDonThue = maDonThue;
        }

        private void frmChiTietDonThue_Load(object sender, EventArgs e)
        {
            DataTable dt = chiTietDonThueBUS.GetChiTietDonThue(maDonThue);
            DataRow row = dt.Rows[0];
            maDonThue_ctdt_txt.Text = row["maDonThue"].ToString();
            maKhachHang_ctdt_txt.Text = row["maKhachHang"].ToString();
            trangThaiDon_ctdt_cbb.Text = row["trangThai"].ToString();
            tenKhachHang_ctdt_txt.Text = row["tenKhachHang"].ToString();
            soDienThoai_ctdt_txt.Text = row["soDienThoai"].ToString();
            diaChi_ctdt_txt.Text = row["diaChi"].ToString();

            try
            {
                DataTable datatable = chiTietDonThueBUS.GetSanPhamTrongDon(maDonThue);
                spDonList.DataSource = datatable;
                spDonList.Columns["maSanPham"].HeaderText = "Mã sản phẩm";
                spDonList.Columns["tenSanPham"].HeaderText = "Tên sản phẩm";
                spDonList.Columns["soLuong"].HeaderText = "Số lượng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateChiTiet_btn_Click(object sender, EventArgs e)
        {
            string maDonThue = maDonThue_ctdt_txt.Text;
            string trangThai = trangThaiDon_ctdt_cbb.SelectedItem as string;
            try
            {
                if (chiTietDonThueBUS.UpdateTrangThaiDon(maDonThue, trangThai))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
