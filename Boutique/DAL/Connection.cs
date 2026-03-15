
using System;
using System.Data;
using System.Windows.Forms;
using Boutique.BUS;
using Microsoft.Data.SqlClient;

namespace Boutique.DAL
{
    class Connection
    {
        private static string strConnection = ""; // Để chuỗi kết nối ở đây
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();

        public static SqlConnection connect()
        {
            if (Program.authen == "windows")
            {
                strConnection = "Data Source=" + Program.server + ";Initial Catalog=" + Program.database + ";Integrated Security=True;TrustServerCertificate=True;";
            }
            else
            {
                strConnection = "server = " + Program.server + "; database = " + Program.database + "; uid = " + Program.uid + "; pwd = " + Program.password;
            }

            return new SqlConnection(strConnection); // Chỉ tạo và trả về, KHÔNG mở
        }

        public static void ActionQuery(string query, params SqlParameter[] para)
        {
            using (SqlConnection connection = connect())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open(); // Mở kết nối ở đây
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            if (para != null && para.Length > 0)
                            {
                                cmd.Parameters.AddRange(para);
                            }
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi khi thực hiện truy vấn: " + ex.Message);
                    }
                }
                else
                {
                    throw new Exception("Không thể kết nối đến server!");
                }
            } // Kết nối sẽ tự động đóng khi ra khỏi khối using
        }

        public static int ActionQueryWithReturn(string query, params SqlParameter[] para)
        {
            using (SqlConnection connection = connect())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open(); // Mở kết nối ở đây
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            if (para != null && para.Length > 0)
                            {
                                cmd.Parameters.AddRange(para);
                            }
                            return cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi khi thực hiện truy vấn: " + ex.Message);
                    }
                }
                else
                {
                    throw new Exception("Không thể kết nối đến server!");
                }
            } // Kết nối sẽ tự động đóng khi ra khỏi khối using
        }

        //phương thức ExecuteScalar để lấy giá trị SUM
        public static object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = connect())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open(); // Mở kết nối ở đây
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            if (parameters != null && parameters.Length > 0)
                            {
                                cmd.Parameters.AddRange(parameters);
                            }
                            return cmd.ExecuteScalar(); // Trả về kết quả SUM
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi khi thực hiện truy vấn: " + ex.Message);
                    }
                }
                else
                {
                    throw new Exception("Không thể kết nối CSDL!");
                }
            } // Kết nối sẽ tự động đóng khi ra khỏi khối using
        }

        public string checkLogin(string username, string password)
        {
            string role = null; // Lưu loại tài khoản ("admin" hoặc "staff")

            using (SqlConnection connection = connect())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open(); // Mở kết nối ở đây

                        string queryAdmin = "SELECT COUNT(*) FROM admin WHERE adminName = @username AND adminPassword = @password";
                        string queryStaff = "SELECT COUNT(*) FROM staff WHERE staffName = @username AND staffPassword = @password";

                        // Kiểm tra trong bảng admin
                        using (SqlCommand cmd = new SqlCommand(queryAdmin, connection))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                role = "admin"; // Tìm thấy trong bảng admin
                            }
                        }

                        // Kiểm tra trong bảng staff nếu không tìm thấy trong admin
                        if (role == null)
                        {
                            using (SqlCommand cmd = new SqlCommand(queryStaff, connection))
                            {
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@password", password);
                                int count = (int)cmd.ExecuteScalar();
                                if (count > 0)
                                {
                                    role = "staff"; // Tìm thấy trong bảng staff
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi trong quá trình đăng nhập: " + ex.Message);
                    }
                }
            } // Kết nối sẽ tự động đóng

            return role; // Trả về "admin", "staff" hoặc null nếu không tìm thấy
        }

        private static string GenerateNewAdminID()
        {
            string newID = "AD001";
            string query = "SELECT MAX(adminID) FROM admin";

            using (SqlConnection connection = connect())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            object result = cmd.ExecuteScalar();
                            if (result != DBNull.Value && result != null)
                            {
                                string lastID = result.ToString();
                                int number = int.Parse(lastID.Substring(2));
                                newID = "AD" + (number + 1).ToString("D3");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tạo AdminID: " + ex.Message);
                    }
                }
            }

            return newID;
        }

        private static string GenerateNewStaffID()
        {
            string newID = "ST001";
            string query = "SELECT MAX(staffID) FROM staff";

            using (SqlConnection connection = connect())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            object result = cmd.ExecuteScalar();
                            if (result != DBNull.Value && result != null)
                            {
                                string lastID = result.ToString();
                                int number = int.Parse(lastID.Substring(2));
                                newID = "ST" + (number + 1).ToString("D3");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tạo StaffID: " + ex.Message);
                    }
                }
            }

            return newID;
        }

        public static bool insertUser(string username, string password, string role, string email)
        {
            string newAdminID = GenerateNewAdminID();
            string newStaffID = GenerateNewStaffID();

            using (SqlConnection connection = connect())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();

                        if (role == "admin")
                        {
                            string queryAdmin = "INSERT INTO admin (adminID, adminName, adminPassword, adminEmail) VALUES (@adminID, @adminName, @adminPassword, @adminEmail)";
                            using (SqlCommand cmd = new SqlCommand(queryAdmin, connection))
                            {
                                cmd.Parameters.AddWithValue("@adminID", newAdminID);
                                cmd.Parameters.AddWithValue("@adminName", username);
                                cmd.Parameters.AddWithValue("@adminPassword", password);
                                cmd.Parameters.AddWithValue("@adminEmail", email);

                                return cmd.ExecuteNonQuery() > 0;
                            }
                        }
                        else
                        {
                            string queryStaff = "INSERT INTO staff (staffID, staffName, staffPassword, staffEmail) VALUES (@staffID, @staffName, @staffPassword, @staffEmail)";
                            using (SqlCommand cmd = new SqlCommand(queryStaff, connection))
                            {
                                cmd.Parameters.AddWithValue("@staffID", newStaffID);
                                cmd.Parameters.AddWithValue("@staffName", username);
                                cmd.Parameters.AddWithValue("@staffPassword", password);
                                cmd.Parameters.AddWithValue("@staffEmail", email);

                                int rows = cmd.ExecuteNonQuery();
                                if (rows > 0)
                                {
                                    // Thêm dòng staffChiTiet
                                    string maStaffChiTiet = newStaffID.Replace("ST", "CT"); // ví dụ đơn giản tạo mã chi tiết
                                    string queryInsert = "INSERT INTO staffChiTiet(maStaffChiTiet, staffID, email) VALUES (@maStaffChiTiet, @staffID, @email)";
                                    using (SqlCommand cmdDetail = new SqlCommand(queryInsert, connection))
                                    {
                                        cmdDetail.Parameters.AddWithValue("@maStaffChiTiet", maStaffChiTiet);
                                        cmdDetail.Parameters.AddWithValue("@staffID", newStaffID);
                                        cmdDetail.Parameters.AddWithValue("@email", email);
                                        return cmdDetail.ExecuteNonQuery() > 0;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message);
                    }
                }
            }

            return false;
        }
    }
}