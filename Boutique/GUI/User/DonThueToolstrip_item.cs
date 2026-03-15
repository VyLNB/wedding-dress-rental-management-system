using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boutique.DTO;
using Boutique.DAL;
using Boutique.BUS;

namespace Boutique.GUI.User
{
    public partial class DonThueToolstrip_item : UserControl
    {
        private DonThueBUS donThueBus;
        private DonThueDTO donThueDTO;
        private ChiTietDonThueDTO chiTietDonThueDTO;
        private ChiTietDonThue chiTietDonThueBUS;
        private KhachHangDTO khachHangDTO;
        private int insertBtnClickCount = 0; //kiểm tra lần click
        public DonThueToolstrip_item()
        {
            InitializeComponent();
            donThueBus = new DonThueBUS();
            chiTietDonThueBUS = new ChiTietDonThue();
            //khachHangDTO = new KhachHangDTO();
            //LoadDanhSachDonThue();
        }

        private void LoadDanhSachDonThue()
        {
            try
            {
                DataTable dataTable = donThueBus.GetDanhSachDonThue();
                donThueList.DataSource = dataTable;
                donThueList.Columns["maDonThue"].HeaderText = "Mã đơn thuê";
                donThueList.Columns["maKhachHang"].HeaderText = "Mã khách hàng";
                donThueList.Columns["tenKhachHang"].HeaderText = "Tên khách hàng";
                donThueList.Columns["ngayDat"].HeaderText = "Ngày đặt";
                donThueList.Columns["ngayNhan"].HeaderText = "Ngày nhận";
                donThueList.Columns["ngayTraDuKien"].HeaderText = "Ngày trả dự kiến";
                donThueList.Columns["tienCoc"].HeaderText = "Tiền cọc";
                donThueList.Columns["tongTien"].HeaderText = "Tổng tiền";
                donThueList.Columns["trangThai"].HeaderText = "Trạng thái";
                donThueList.Columns["ghiChu"].HeaderText = "Ghi chú";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertDonThue_btn_Click(object sender, EventArgs e)
        {
            insertBtnClickCount++;
            string maKhachHang = maKhachHang_txt.Text.Trim();
            string maDonThue = string.Empty;
            if (insertBtnClickCount == 1) //click btn insert lần đầu
            { //bỏ vô hiệu hóa các textbox và btn
                maDonThue_txt.Enabled = true;
                maKhachHang_txt.Enabled = true;
                maSanPham_txt.Enabled = true;
                giaThue_txt.Enabled = true;
                soLuong_txt.Enabled = true;
                soNgayThue_txt.Enabled = true;
                tienCoc_txt.Enabled = true;
                nhanHang_date.Enabled = true;
                traDuKien_date.Enabled = true;
                ghiChu_txt.Enabled = true;
                deleteDonThue_btn.Enabled = true;
                chiTietDonThue_btn.Enabled = true;
                insertSanPham_btn.Enabled = true;

                maDonThue_txt.Text = donThueBus.GenerateNewDonThueID("DT");
            }
            else
            {
                //lấy dữ liệu insert vào bảng đơn thuê
                string maDonThueInsert = maDonThue_txt.Text.Trim();
                decimal tienCoc = Convert.ToDecimal(tienCoc_txt.Text.Trim());
                DateTime ngayNhan = nhanHang_date.Value;
                DateTime ngayTraDuKien = traDuKien_date.Value;
                string ghiChu = ghiChu_txt.Text;
                maKhachHang = maKhachHang_txt.Text.Trim();

                //lấy thông tin insert vào bảng chi tiết đơn thuê
                string maSanPham = maSanPham_txt.Text.Trim();
                int soLuong = Convert.ToInt32(soLuong_txt.Text.Trim());
                decimal giaThue = Convert.ToDecimal(giaThue_txt.Text.Trim());
                int soNgayThue = Convert.ToInt32(soNgayThue_txt.Text.Trim());

                khachHangDTO = new KhachHangDTO(maKhachHang, "", "", "", "");
                int count = donThueBus.CheckKhachHang(khachHangDTO);//lấy số lượng khách hàng đc ktr 

                SanPhamDTO sanPhamDTO = new SanPhamDTO(maSanPham, "", 0, "", "", 0);
                int countSP = donThueBus.CheckSanPham(sanPhamDTO);

                if (count == 0)
                {//chưa có khách hàng
                    MessageBox.Show("Vui lòng thêm khách hàng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if(countSP == 0)
                {
                    MessageBox.Show("Sản phẩm không có!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        if (donThueBus.CheckDonThueTonTai(maDonThueInsert) == 0)//chưa có đơn thuê
                        {
                            //tạo đơn thuê mới
                            donThueDTO = new DonThueDTO(maDonThueInsert, maKhachHang, ngayNhan, ngayTraDuKien, tienCoc, "Đang xử lý", ghiChu);
                        }
                        //donThueDTO = new DonThueDTO(maDonThueInsert, maKhachHang, ngayNhan, ngayTraDuKien, tienCoc, "Đang xử lý", ghiChu);
                        if (donThueBus.InsertDonThue(khachHangDTO, donThueDTO))
                        {
                            //insert vào bảng chi tiết đơn thuê --> cập nhật tổng tiền (chỉ mới insert 1 sản phẩm)
                            try
                            {
                                string maChiTietDonThue = chiTietDonThueBUS.GenerateNewChiTietDonThueID("CTDT");
                                chiTietDonThueDTO = new ChiTietDonThueDTO(maChiTietDonThue, maDonThueInsert, maSanPham, soLuong, giaThue, soNgayThue, ghiChu);
                                if (chiTietDonThueBUS.InsertChiTietDonThue(chiTietDonThueDTO))
                                {
                                    MessageBox.Show("Insert successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDanhSachDonThue();
                                    ResetForm();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DonThueToolstrip_item_Load(object sender, EventArgs e)
        {
            maDonThue_txt.Enabled = false;
            maKhachHang_txt.Enabled = false;
            maSanPham_txt.Enabled = false;
            giaThue_txt.Enabled = false;
            soLuong_txt.Enabled = false;
            soNgayThue_txt.Enabled = false;
            tienCoc_txt.Enabled = false;
            nhanHang_date.Enabled = false;
            traDuKien_date.Enabled = false;
            ghiChu_txt.Enabled = false;
            deleteDonThue_btn.Enabled = false;
            chiTietDonThue_btn.Enabled = false;
            insertSanPham_btn.Enabled = false;

            LoadDanhSachDonThue();
        }

        private void ResetForm()
        {
            maDonThue_txt.Text = "";
            maKhachHang_txt.Text = "";
            maSanPham_txt.Text = "";
            tienCoc_txt.Text = "";
            nhanHang_date.Value = DateTime.Today;
            traDuKien_date.Value = DateTime.Today;
            giaThue_txt.Text = "";
            soLuong_txt.Text = "";
            soNgayThue_txt.Text = "";
            ghiChu_txt.Text = "";
        }

        //insert thêm nhiều sản phẩm vào 1 đơn hàng
        private void insertSanPham_btn_Click(object sender, EventArgs e)
        {
            //insert thêm sản phẩm vào chi tiết đơn hàng --> cập nhập tổng tiền 
            string maChiTietDonThue = chiTietDonThueBUS.GenerateNewChiTietDonThueID("CTDT");
            string maDonThue = maDonThue_txt.Text;
            string maSanPham = maSanPham_txt.Text;
            int soLuong = Convert.ToInt32(soLuong_txt.Text);
            decimal giaThue = Convert.ToDecimal(giaThue_txt.Text);
            int soNgayThue = Convert.ToInt32(soNgayThue_txt.Text);
            string ghiChu = ghiChu_txt.Text;
            try
            {
                chiTietDonThueDTO = new ChiTietDonThueDTO(maChiTietDonThue, maDonThue, maSanPham, soLuong, giaThue, soNgayThue, ghiChu);
                if (chiTietDonThueBUS.InsertChiTietDonThue(chiTietDonThueDTO))
                {
                    MessageBox.Show("Insert successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDonThue();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //lấy thông tin từ việc click vào 1 row trong datagridview
        private void donThueList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = donThueList.Rows[e.RowIndex];
                maDonThue_txt.Text = row.Cells["maDonThue"].Value.ToString();
            }
        }

        private void chiTietDonThue_btn_Click(object sender, EventArgs e)
        {
            string maDon = maDonThue_txt.Text;
            frmChiTietDonThue frmChiTiet = new frmChiTietDonThue(maDon);
            frmChiTiet.ShowDialog();

            LoadDanhSachDonThue();
        }
    }
}
