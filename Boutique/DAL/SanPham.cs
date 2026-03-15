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
    class SanPham
    {
        //lấy danh sách loại sản phẩm 
        public DataTable get_DanhSachSanPham()
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Gọi phương thức connect() từ lớp Connection
                using (SqlConnection connection = Connection.connect())
                {
                    //conn.Open();
                    string query = "SELECT maLoaiSP, tenLoaiSP FROM loaiSanPham";
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
        
        public string GenerateNewProductID()
        {
            string newID = "SP001";
            string query = "SELECT MAX(maSanPham) FROM sanPham";
            using (SqlConnection connection = Connection.connect())
            {
                if (connection != null)
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            string lastID = result.ToString(); // VD: "US009"
                            int number = int.Parse(lastID.Substring(2)); // Lấy số "009"
                            newID = "SP" + (number + 1).ToString("D3"); // Tăng 1 -> "US010"
                        }
                    }
                }
            }

            return newID;
        }

        //lấy danh sách sản phẩm hiển thị lên 
        public DataTable getDataToGridView()
        {

            DataTable dataTable = new DataTable();
            try
            {
                // Gọi phương thức connect() từ lớp Connection
                using (SqlConnection connection = Connection.connect())
                {
                    //conn.Open();
                    string query = "SELECT * FROM sanPham";
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

        public bool insertSanPham(string maSP, string maLoaiSP, string tenSP, decimal giaTien, int soLuong, string trangThai)
        {
            //String maSP_insert = GenerateNewProductID();
            string loaiSP_insert = maLoaiSP;
            string tenSP_insert = tenSP;
            decimal giaTien_insert = giaTien;
            int soLuong_insert = soLuong;
            string trangThai_insert = trangThai;

            using(SqlConnection connection = Connection.connect())
            {
                if (connection != null)
                {
                    connection.Open();
                    string queryInsert = "INSERT INTO sanPham(maSanPham, tenSanPham, giaThue, trangThai, maLoaiSP, soLuong) " +
                        "VALUES (@maSanPham, @tenSanPham, @giaThue, @trangThai, @maLoaiSP, @soLuong)";
                    using (SqlCommand cmd = new SqlCommand(queryInsert, connection))
                    {
                        cmd.Parameters.AddWithValue("@maSanPham", maSP);
                        cmd.Parameters.AddWithValue("@tenSanPham", tenSP_insert);
                        cmd.Parameters.AddWithValue("@giaThue", giaTien_insert);
                        cmd.Parameters.AddWithValue("@trangThai", trangThai_insert);
                        cmd.Parameters.AddWithValue("@maLoaiSP", loaiSP_insert);
                        cmd.Parameters.AddWithValue("@soLuong", soLuong_insert);

                        int row = cmd.ExecuteNonQuery();
                        return row > 0;
                    } 
                }
                return false;
            }
        }

        //lấy sản phẩm theo ID
        public DataRow getSanPhamByID(string maSanPham)
        {
            using(SqlConnection connection = Connection.connect())
            {
                if (connection != null)
                {
                    string queryGetByID = "SELECT maSanPham, tenSanPham, giathue, maLoaiSP FROM sanPham WHERE maSanPham = @maSanPham";
                    using (SqlCommand cmd = new SqlCommand(queryGetByID, connection))
                    {
                        cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                return dt.Rows[0];
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                } else
                {
                    return null;
                }
            }
        }

        

        //insert vào bảng sanPhamXoa
        public void insertSanPhamXoa(string maSanPham, string tenSanPham, decimal giaThue, string maLoaiSP)
        {
            string queryInsert = "INSERT INTO sanPhamXoa(maSanPham, tenSanPham, giaThue, maLoaiSP) VALUES (@maSanPham, @tenSanPham, @giaThue, @maLoaiSP)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maSanPham", maSanPham),
                new SqlParameter("@tenSanPham", tenSanPham),
                new SqlParameter("@giaThue", giaThue),
                new SqlParameter("@maLoaiSP", maLoaiSP),
            };
            Connection.ActionQuery(queryInsert, para);
        }

        

        public int deleteSanPham(string maSanPham)
        {
            int result = 0;
            SqlConnection connection = Connection.connect(); // Lấy đối tượng kết nối

            try
            {
                if (connection != null)
                {
                    connection.Open();
                    string sql = "DELETE FROM SanPham WHERE maSanPham = @maSanPham";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@maSanPham", maSanPham);
                    result = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc xử lý ngoại lệ khác
                Console.WriteLine("Lỗi xóa sản phẩm: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Đảm bảo đóng kết nối trong khối finally
                }
            }
            return result;
        }

        public bool updateSanPham(SanPhamDTO sp)
        {
            string query = "UPDATE sanPham SET TenSanPham = @TenSanPham, GiaThue = @GiaThue, TrangThai = @TrangThai, SoLuong = @SoLuong, maLoaiSP = @maLoaiSP WHERE MaSanPham = @MaSanPham";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", sp.getMaSanPham()),
                new SqlParameter("@TenSanPham", sp.getTenSanPham()),
                new SqlParameter("@GiaThue", sp.getGiaThue()),
                new SqlParameter("@trangThai", sp.getTrangThai()),
                new SqlParameter("@SoLuong", sp.getSoLuong()),
                new SqlParameter("@maLoaiSP", sp.getMaLoaiSP())
            };
            int rowAffected = Connection.ActionQueryWithReturn(query, para);
            if (rowAffected > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        

        public bool IsSanPhamInChiTietDonThue(string maSanPham)
        {
            using (SqlConnection connection = Connection.connect())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();
                        string sql = "SELECT COUNT(*) FROM chiTietDonThue WHERE maSanPham = @maSanPham";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@maSanPham", maSanPham);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        // Xử lý hoặc ghi log lỗi (ví dụ: Console.WriteLine(ex.Message))
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
