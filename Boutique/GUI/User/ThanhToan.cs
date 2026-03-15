using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boutique.BUS;
using Boutique.DAL;
using System.Drawing.Printing;

namespace Boutique.GUI.User
{
    public partial class ThanhToan : UserControl
    {

        private ThanhToanBUS thanhToanBUS = new ThanhToanBUS();
        public ThanhToan()
        {
            InitializeComponent();
            LoadDanhSachThanhToan();
        }

        private void LoadDanhSachThanhToan()
        {
            try
            {
                DataTable dt = thanhToanBUS.GetDanhSachThanhToan();
                thanhToanList.DataSource = dt;
                thanhToanList.Columns["maDonThue"].HeaderText = "Mã đơn thuê";
                thanhToanList.Columns["tenKhachHang"].HeaderText = "Tên khách hàng";
                thanhToanList.Columns["soDienThoai"].HeaderText = "Số điện thoại";
                thanhToanList.Columns["diaChi"].HeaderText = "Địa chỉ";
                thanhToanList.Columns["tenSanPham"].HeaderText = "Tên sản phẩm";
                thanhToanList.Columns["giaThue"].HeaderText = "Giá thuê";
                thanhToanList.Columns["soLuong"].HeaderText = "Số lượng";
                thanhToanList.Columns["soNgayThue"].HeaderText = "Số ngày thuê";
                thanhToanList.Columns["ngayDat"].HeaderText = "Ngày đặt";
                thanhToanList.Columns["ngayNhan"].HeaderText = "Ngày nhận";
                thanhToanList.Columns["ngayTraThucTe"].HeaderText = "Ngày trả";
                thanhToanList.Columns["thanhTien"].HeaderText = "Thành tiền";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            LoadDanhSachThanhToan();
        }

        private void inHoaDon_btn_Click(object sender, EventArgs e)
        {
            //kiểm tra có hàng nào được chọn không
            if (thanhToanList.SelectedRows.Count > 0)
            {
                string maDonThue = thanhToanList.SelectedRows[0].Cells["maDonThue"].Value.ToString();

                if (string.IsNullOrEmpty(maDonThue))
                {
                    MessageBox.Show("Mã đơn thuê không hợp lệ!", "Lỗi");
                    return;
                }
                //danh sách lưu sản phẩm trong đơn hàng có cùng mã đơn
                List<string> sanPhamHoaDon = new List<string>();
                decimal tongTien = 0;

                //duyệt qua các hàng tìm các đơn có cùng mã đơn
                foreach (DataGridViewRow row in thanhToanList.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng trống cuối cùng
                    if (row.Cells["maDonThue"].Value.ToString() == maDonThue) 
                    {

                        string tenSanPham = row.Cells["tenSanPham"].Value.ToString();
                        decimal giaThue = Convert.ToDecimal(row.Cells["giaThue"].Value.ToString());
                        int soLuong = Convert.ToInt32(row.Cells["soLuong"].Value.ToString());
                        int soNgayThue = Convert.ToInt32(row.Cells["soNgayThue"].Value.ToString());
                        decimal thanhTien = Convert.ToDecimal(row.Cells["thanhTien"].Value.ToString());

                        tongTien += thanhTien;

                        sanPhamHoaDon.Add($"Sản phẩm: {tenSanPham}, Giá thuê: {giaThue}, Số lượng: {soLuong}, Số ngày thuê: {soNgayThue}, Thành tiền: {thanhTien}");
                    }
                }

                string hoaDon = "=====================================\n";
                hoaDon += "           HÓA ĐƠN THUÊ SẢN PHẨM\n";
                hoaDon += "=====================================\n";
                hoaDon += $"Mã đơn thuê: {maDonThue}\n";
                hoaDon += "-------------------------------------\n";
                hoaDon += string.Join("\n", sanPhamHoaDon);
                hoaDon += "\n-------------------------------------\n";
                hoaDon += $"Tổng tiền: {tongTien:N0} VNĐ\n";
                hoaDon += "=====================================\n";
                hoaDon += "Cảm ơn quý khách đã sử dụng dịch vụ!\n";
                hoaDon += "=====================================\n";

                MessageBox.Show(hoaDon, "In hóa đơn");

                PrintHoaDon(hoaDon);
            }
        }

        private void PrintHoaDon(string hoaDon)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                // Vẽ nội dung hóa đơn lên trang in
                e.Graphics.DrawString(hoaDon, new Font("Arial", 12), Brushes.Black, new PointF(10, 10));
            };

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            // Hiển thị hộp thoại in
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi in hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
