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
    class NhanVien
    {
        //private NhanVienDTO nhanVienDTO;

        //lấy danh sách nhân viên hiển thị lên
        public DataTable GetDanhSachNhanVien()
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Gọi phương thức connect() từ lớp Connection
                using (SqlConnection connection = Connection.connect())
                {
                    //conn.Open();
                    connection.Open();
                    string query = "SELECT staffID, hoTen, soDienThoai, email, diaChi FROM staffChiTiet";
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

        

        public string GenerateNewID(string prefix)
        {
            string newID = prefix + "001";
            string query = "SELECT MAX(maStaffChiTiet) FROM staffChiTiet";
            using (SqlConnection connection = Connection.connect())
            {
                if (connection != null)
                {
                    //them
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            string lastID = result.ToString().Trim(); // VD: "ST009"
                            if (lastID.Length >= prefix.Length + 3)
                            {
                                string numPart = lastID.Substring(prefix.Length);
                                if (int.TryParse(numPart, out int number))
                                {
                                    newID = prefix + (number + 1).ToString("D3");
                                }
                            }
                        }
                    }
                }
            }
            return newID;
        }


        public string GenerateNewIDNhanVien(string prefix)
        {
            string newID = prefix + "001";
            string query = "SELECT MAX(staffID) FROM staff";
            using (SqlConnection connection = Connection.connect())
            {
                if (connection != null)
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        //connection.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            string lastID = result.ToString().Trim(); // VD: "ST009"
                            if (lastID.Length >= prefix.Length + 3)
                            {
                                string numPart = lastID.Substring(prefix.Length);
                                if (int.TryParse(numPart, out int number))
                                {
                                    newID = prefix + (number + 1).ToString("D3");
                                }
                            }
                        }
                    }
                }
            }
            return newID;
        }

        public bool UpdateNhanVien(NhanVienDTO nhanVienDTO)
        {

            
            string query = "UPDATE staffChiTiet SET hoTen = @hoTen, soDienThoai = @soDienThoai, email = @email, diaChi = @diaChi" +
                            " WHERE staffID = @maNhanVien";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maNhanVien", nhanVienDTO.GetStaffID()),
                new SqlParameter("@hoTen", nhanVienDTO.GetStaffName()),
                new SqlParameter("@soDienThoai", nhanVienDTO.GetSoDienThoai()),
                new SqlParameter("@email", nhanVienDTO.GetStaffEmail()),
                new SqlParameter("@diaChi", nhanVienDTO.GetDiaChi())
            };
            int rowAffected = Connection.ActionQueryWithReturn(query, para);
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public int DeleteNhanVienChiTiet(NhanVienDTO nhanVienDTO)
        //{

        //    string queryDelete = "DELETE FROM staffChiTiet WHERE staffID = @staffID";
        //    SqlParameter[] para = new SqlParameter[]
        //    {
        //        new SqlParameter("@staffID", nhanVienDTO.GetStaffID())
        //    };
        //    return Connection.ActionQueryWithReturn(queryDelete, para);
        //}

        //public int DeleteNhanVien(NhanVienDTO nhanVienDTO)
        //{
        //    string queryDelete = "DELETE FROM staff WHERE staffID = @staffID";
        //    SqlParameter[] para = new SqlParameter[]
        //    {
        //        new SqlParameter("@staffID", nhanVienDTO.GetStaffID())
        //    };
        //    return Connection.ActionQueryWithReturn(queryDelete, para);
        //}

        public bool DeleteNhanVien(NhanVienDTO nhanVienDTO)
        {
            using (SqlConnection connection = Connection.connect())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Xóa từ bảng staffChiTiet
                    string queryDeleteChiTiet = "DELETE FROM staffChiTiet WHERE staffID = @staffID";
                    using (SqlCommand cmdChiTiet = new SqlCommand(queryDeleteChiTiet, connection, transaction))
                    {
                        cmdChiTiet.Parameters.AddWithValue("@staffID", nhanVienDTO.GetStaffID());
                        int rowsAffectedChiTiet = cmdChiTiet.ExecuteNonQuery();
                        // Bạn có thể kiểm tra số dòng bị ảnh hưởng nếu cần
                    }

                    // Xóa từ bảng staff
                    string queryDeleteStaff = "DELETE FROM staff WHERE staffID = @staffID";
                    using (SqlCommand cmdStaff = new SqlCommand(queryDeleteStaff, connection, transaction))
                    {
                        cmdStaff.Parameters.AddWithValue("@staffID", nhanVienDTO.GetStaffID());
                        int rowsAffectedStaff = cmdStaff.ExecuteNonQuery();
                        // Bạn có thể kiểm tra số dòng bị ảnh hưởng nếu cần
                    }

                    transaction.Commit(); // Nếu cả hai thao tác thành công, commit transaction
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback(); // Nếu có lỗi xảy ra, rollback transaction
                    return false;
                }
            }
        }


        public bool ThemNhanVien(NhanVienDTO nhanVienDTO, string username, string password)
        {
            using (SqlConnection connection = Connection.connect())
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                  
                    string queryStaff = "INSERT INTO staff (staffID, staffName, staffPassword, staffEmail) VALUES (@staffID, @staffName, @staffPassword, @staffEmail)";
                    SqlCommand cmd1 = new SqlCommand(queryStaff, connection, transaction);
                    cmd1.Parameters.AddWithValue("@staffID", nhanVienDTO.GetStaffID());
                    cmd1.Parameters.AddWithValue("@staffName", nhanVienDTO.GetStaffName());
                    cmd1.Parameters.AddWithValue("@staffPassword", password); 
                    cmd1.Parameters.AddWithValue("@staffEmail", nhanVienDTO.GetStaffEmail()); 
                    cmd1.ExecuteNonQuery();

                    string queryChiTiet = "INSERT INTO staffChiTiet (maStaffChiTiet, staffID, hoTen, soDienThoai, email, diaChi) " +
                                          "VALUES (@maCT, @staffID, @hoTen, @soDienThoai, @email, @diaChi)";
                    SqlCommand cmd2 = new SqlCommand(queryChiTiet, connection, transaction);
                    cmd2.Parameters.AddWithValue("@maCT", nhanVienDTO.GetStaffID()); // Giả sử dùng chung mã
                    cmd2.Parameters.AddWithValue("@staffID", nhanVienDTO.GetStaffID());
                    cmd2.Parameters.AddWithValue("@hoTen", nhanVienDTO.GetStaffName());
                    cmd2.Parameters.AddWithValue("@soDienThoai", nhanVienDTO.GetSoDienThoai());
                    cmd2.Parameters.AddWithValue("@email", nhanVienDTO.GetStaffEmail());
                    cmd2.Parameters.AddWithValue("@diaChi", nhanVienDTO.GetDiaChi());
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw; // Ném ra lỗi cho tầng BUS xử lý tiếp
                }
            }
        }
    }
}
