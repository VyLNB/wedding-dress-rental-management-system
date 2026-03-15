using Boutique.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.DAL
{
    class ChiTietDonThue
    {
        public bool InsertChiTietDonThue(ChiTietDonThueDTO chiTietDonThue)
        {
            string queryInsert = "INSERT INTO chiTietDonThue (maChiTietDonThue, maDonThue, maSanPham, soLuong, giaThue, soNgayThue, ghiChu) " +
                "VALUES (@maChiTietDonThue, @maDonThue, @maSanPham, @soLuong, @giaThue, @soNgayThue, @ghiChu)";

            SqlParameter[] paraInsert = new SqlParameter[]
            {
                new SqlParameter("@maChiTietDonThue", chiTietDonThue.GetMaChiTietDonThue()),
                new SqlParameter("@maDonThue", chiTietDonThue.GetMaDonThue()),
                new SqlParameter("@maSanPham", chiTietDonThue.GetMaSanPham()),
                new SqlParameter("@soLuong", chiTietDonThue.GetSoLuong()),
                new SqlParameter("@giaThue", chiTietDonThue.GetGiaThue()),
                new SqlParameter("@soNgayThue", chiTietDonThue.GetSoNgayThue()),
                new SqlParameter("@ghiChu", chiTietDonThue.GetGhiChu())
            };

            int rowAffected = Connection.ActionQueryWithReturn(queryInsert, paraInsert);
            return rowAffected > 0;
        }

        public string GenerateNewChiTietDonThueID(string prefix)
        {
            string newID = prefix + "001";
            string query = "SELECT MAX(maChiTietDonThue) FROM chiTietDonThue";
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
                            int number = int.Parse(lastID.Substring(4)); // Lấy số "009"
                            newID = prefix + (number + 1).ToString("D3"); // Tăng 1 -> "US010"
                        }
                    }
                }
            }
            return newID;
        }

        public DataTable GetChiTietDonThue(string maDonThue)
        {
            DataTable dt = new DataTable();
            try
            {
                // Gọi phương thức connect() từ lớp Connection
                using (SqlConnection connection = Connection.connect())
                {
                    //conn.Open();
                    connection.Open();
                    string query = @"SELECT dt.maDonThue, dt.maKhachHang, kh.tenKhachHang, kh.soDienThoai, kh.diaChi, dt.trangThai
                                    FROM donThue dt
                                    INNER JOIN khachHang kh ON dt.maKhachHang = kh.maKhachHang
                                    WHERE dt.maDonThue = @maDonThue";

                    //SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    //adapter.Fill(dt);
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@maDonThue", maDonThue);
                        //connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetSanPhamTrongDon(string maDonThue)
        {
            DataTable dt = new DataTable();
            try
            {
                // Gọi phương thức connect() từ lớp Connection
                using (SqlConnection connection = Connection.connect())
                {
                    //conn.Open();
                    connection.Open();
                    string query = @"SELECT ctdt.maSanPham, sp.tenSanPham, ctdt.soLuong
                                    FROM chiTietDonThue ctdt
                                    INNER JOIN sanPham sp ON ctdt.maSanPham = sp.maSanPham
                                    WHERE ctdt.maDonThue = @maDonThue";

                    //SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    //adapter.Fill(dt);
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@maDonThue", maDonThue);
                        //connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return dt;
        }

        public bool UpdateTrangThaiDon(string maDonThue, string trangThai)
        {
            string updateQuery = "UPDATE donThue SET trangThai = @trangThai" +
                            " WHERE maDonThue = @maDonThue";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@trangThai", trangThai),
                new SqlParameter("@maDonThue", maDonThue),

            };
            int rowAffected = Connection.ActionQueryWithReturn(updateQuery, para);
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
