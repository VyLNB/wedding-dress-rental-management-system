using Boutique.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.DAL
{
    class DonThue
    {

        //private KhachHangDTO khachHangDTO;
        //private DonThueDTO donThue;
        public DataTable GetDanhSachDonThue()
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Gọi phương thức connect() từ lớp Connection
                using (SqlConnection connection = Connection.connect())
                {
                    //conn.Open();
                    connection.Open();
                    string query = @"SELECT dth.maDonThue, dth.maKhachHang, kh.tenKhachHang, dth.ngayDat, 
                                    dth.ngayNhan, dth.ngayTraDuKien, dth.tienCoc, dth.tongTien, dth.trangThai, dth.ghiChu
                                    FROM donThue dth INNER JOIN khachHang kh ON dth.maKhachHang = kh.maKhachHang 
                                    WHERE dth.trangThai = N'Đang xử lý' OR dth.trangThai = N'Đã nhận' OR dth.trangThai = N'Đã xác nhận' OR dth.trangThai = N'Đã trả' OR dth.trangThai = N'Hủy'";
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

        public int checkKhachHang(KhachHangDTO khachHang)
        {
            string query = "SELECT COUNT(*) FROM khachHang WHERE maKhachHang = @maKhachHang";
            using(SqlConnection connect = Connection.connect())
            {
                if(connect != null)
                {
                    connect.Open();
                    using(SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@maKhachHang", khachHang.GetMaKhachHang());
                        try
                        {
                            return (int)cmd.ExecuteScalar();
                        } 
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            return 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Can not connect to server!");
                    return 0;
                }
            }
        }

        public int CheckSanPham(SanPhamDTO sanPhamDTO)
        {
            string query = "SELECT COUNT(*) FROM sanPham WHERE maSanPham = @maSanPham";
            using (SqlConnection connect = Connection.connect())
            {
                if (connect != null)
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@maSanPham", sanPhamDTO.getMaSanPham());
                        try
                        {
                            return (int)cmd.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            return 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Can not connect to server!");
                    return 0;
                }
            }
        }

        public string GenerateNewDonThueID(string prefix)
        {
            string newID = prefix + "001";
            string query = "SELECT MAX(maDonThue) FROM donThue";
            using (SqlConnection connection = Connection.connect())
            {
                if (connection != null)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            string lastID = result.ToString(); // VD: "US009"
                            int number = int.Parse(lastID.Substring(2)); // Lấy số "009"
                            newID = prefix + (number + 1).ToString("D3"); // Tăng 1 -> "US010"
                        }
                    }
                }
            }
            return newID;
        }

        public bool InsertDonThue(KhachHangDTO khachHang, DonThueDTO donThue)
        {
            // 1. Tính tổng tiền từ bảng chi tiết (nếu có)
            decimal tongTien = 0;
            string queryTinhTong = "SELECT SUM(thanhTien) FROM chiTietDonThue WHERE maDonThue = @maDonThue";

            SqlParameter[] paraTinhTong = new SqlParameter[]
            {
                new SqlParameter("@maDonThue", donThue.GetMaDonThue())
            };


            Connection cn = new Connection();
            //object result = cn.ExecuteScalar(queryTinhTong, paraTinhTong);
            object result = Connection.ExecuteScalar(queryTinhTong, paraTinhTong);
            if (result != null && result != DBNull.Value)
            {
                tongTien = Convert.ToDecimal(result);
            }

            // 2. Thêm đơn thuê vào bảng `donThue` (dùng ActionQueryWithReturn)
            string queryInsert = "INSERT INTO donThue (maDonThue, maKhachHang, ngayNhan, ngayTraDuKien, tienCoc, tongTien, trangThai, ghiChu) " +
                "VALUES (@maDonThue, @maKhachHang, @ngayNhan, @ngayTraDuKien, @tienCoc, @tongTien, @trangThai, @ghiChu)";

            SqlParameter[] paraInsert = new SqlParameter[]
            {
                new SqlParameter("@maDonThue", donThue.GetMaDonThue()),
                new SqlParameter("@maKhachHang", khachHang.GetMaKhachHang()),
                new SqlParameter("@ngayNhan", donThue.GetNgayNhan()),
                new SqlParameter("@ngayTraDuKien", donThue.GetNgayTraDuKien()),
                new SqlParameter("@tienCoc", donThue.GetTienCoc()),
                new SqlParameter("@tongTien", tongTien),
                new SqlParameter("@trangThai", donThue.GetTrangThai()),
                new SqlParameter("@ghiChu", donThue.GetGhiChu())
            };

            int rowAffected = Connection.ActionQueryWithReturn(queryInsert, paraInsert);
            return rowAffected > 0;
        }

        public int CheckDonThueTonTai(string maDonThue)
        {
            string query = "SELECT COUNT(*) FROM donThue WHERE maDonThue = @maDonThue";
            using (SqlConnection connect = Connection.connect())
            {
                if (connect != null)
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@maDonThue", maDonThue);
                        try
                        {
                            return (int)cmd.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            return 0;
                        }
                    }
                }else
                {
                    MessageBox.Show("Can not connect to server!");
                    return 0;
                }
            }
        }

        public DataTable GetDoanhThuTheoNgay(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = Connection.connect())
                {
                    string query = @"
                SELECT maDonThue, ngayNhan, tongTien 
                FROM donThue 
                WHERE ngayNhan BETWEEN @startDate AND @endDate 
                    AND trangThai = N'Hoàn Thành'"; // lọc theo trạng thái hoàn tất

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu doanh thu: " + ex.Message);
            }

            return dt;
        }

        
    }


}
