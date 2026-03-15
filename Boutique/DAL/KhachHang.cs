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
    class KhachHang
    {

        //lấy danh sách kh hiển thị lên
        public DataTable GetDanhSachKhachHang()
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Gọi phương thức connect() từ lớp Connection
                using (SqlConnection connection = Connection.connect())
                {
                    //conn.Open();
                    string query = "SELECT * FROM khachHang";
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
            string query = "SELECT MAX(maKhachHang) FROM khachHang";
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

        //thêm khách hàng
        public bool InsertKhachHang(KhachHangDTO khachHang)
        {
            string query = "INSERT INTO khachHang (maKhachHang, tenKhachHang, emailKhachHang, soDienThoai, diaChi) " +
                            "VALUES (@maKhachHang, @tenKhachHang, @emailKhachHang, @soDienThoai, @diaChi)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maKhachHang", khachHang.GetMaKhachHang()),
                new SqlParameter("@tenKhachHang", khachHang.GetTenKhachHang()),
                new SqlParameter("@emailKhachHang", khachHang.GetEmail()),
                new SqlParameter("@soDienThoai", khachHang.GetSoDienThoai()),
                new SqlParameter("@diaChi", khachHang.GetDiaChi())
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

        //lấy khách hàng theo id
        public DataRow GetKhachHangByID(string maKhachHang)
        {
            using (SqlConnection connection = Connection.connect())
            {
                if (connection != null)
                {
                    string queryGetByID = "SELECT tenKhachHang, emailKhachHang, soDienThoai, diaChi " +
                                            "FROM khachHang WHERE maKhachHang = @maKhachHang";
                    using (SqlCommand cmd = new SqlCommand(queryGetByID, connection))
                    {
                        cmd.Parameters.AddWithValue("@maKhachHang", maKhachHang);
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
                }
                else
                {
                    return null;
                }
            }
        }

        public void insertKhachHangXoa(KhachHangDTO khachHang)
        {
            string queryInsert = "INSERT INTO khachHangXoa(maKhachHang, tenKhachHang, email, soDienThoai, diaChi) " +
                                "VALUES (@maKhachHang, @tenKhachHang, @email, @soDienThoai, @diaChi)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maKhachHang", khachHang.GetMaKhachHang()),
                new SqlParameter("@tenKhachHang", khachHang.GetTenKhachHang()),
                new SqlParameter("@email", khachHang.GetEmail()),
                new SqlParameter("@soDienThoai", khachHang.GetSoDienThoai()),
                new SqlParameter("@diaChi", khachHang.GetDiaChi())
            };
            Connection.ActionQuery(queryInsert, para);
        }


        public int deleteKhachHang(KhachHangDTO khachHang)
        {
            string queryDelete = "DELETE FROM khachHang WHERE maKhachHang = @maKhachHang";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maKhachHang", khachHang.GetMaKhachHang())
            };
            return Connection.ActionQueryWithReturn(queryDelete, para);
        }

        public bool updateKhachHang(KhachHangDTO khachHang)
        {
            string query = "UPDATE khachHang SET tenKhachHang = @tenKhachHang, emailKhachHang = @email, soDienThoai = @soDienThoai, diaChi = @diaChi" +
                            " WHERE maKhachHang = @maKhachHang";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maKhachHang", khachHang.GetMaKhachHang()),
                new SqlParameter("@tenKhachHang", khachHang.GetTenKhachHang()),
                new SqlParameter("@email", khachHang.GetEmail()),
                new SqlParameter("@soDienThoai", khachHang.GetSoDienThoai()),
                new SqlParameter("@diaChi", khachHang.GetDiaChi())
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
    }
}
