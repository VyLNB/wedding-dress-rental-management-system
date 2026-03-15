using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.DAL
{
    class ThanhToan
    {
        public DataTable GetDanhSachThanhToan()
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Gọi phương thức connect() từ lớp Connection
                using (SqlConnection connection = Connection.connect())
                {
                    //conn.Open();
                    string query = "SELECT dt.maDonThue, kh.tenKhachHang, kh.soDienThoai, kh.diaChi, " +
                                            "sp.tenSanPham, ctdt.soLuong, ctdt.giaThue, ctdt.soNgayThue," +
                                           " dt.ngayDat, dt.ngayNhan, dt.ngayTraThucTe, ctdt.thanhTien " +
                                   "FROM khachHang kh INNER JOIN donThue dt ON kh.maKhachHang = dt.maKhachHang " +
                                                      "INNER JOIN chiTietDonThue ctdt ON dt.maDonThue = ctdt.maDonThue " +
                                                      "INNER JOIN sanPham sp ON ctdt.maSanPham = sp.maSanPham " +
                                   "WHERE dt.trangThai = N'Hoàn thành'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return dataTable;
        }
    }
}
