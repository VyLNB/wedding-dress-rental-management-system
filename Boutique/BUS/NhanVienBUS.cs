using Boutique.DAL;
using Boutique.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.BUS
{
    class NhanVienBUS
    {
        private NhanVien nhanVien = new NhanVien();

        public DataTable GetDanhSachNhanVien()
        {
            return nhanVien.GetDanhSachNhanVien();
        }

        public bool UpdateNhanVien(NhanVienDTO nhanVienDTO)
        {
            return nhanVien.UpdateNhanVien(nhanVienDTO);
        }

        public string GenerateNewID(string prefix)
        {
            return nhanVien.GenerateNewID(prefix);
        }

        //public int DeleteNhanVienChiTiet(NhanVienDTO nhanVienDTO)
        //{
        //    return nhanVien.DeleteNhanVienChiTiet(nhanVienDTO);
        //}

        //public int DeleteNhanVien(NhanVienDTO nhanVienDTO)
        //{
        //    return nhanVien.DeleteNhanVien(nhanVienDTO);
        //}

        public bool DeleteNhanVien(NhanVienDTO nhanVienDTO)
        {
            try
            {
                return nhanVien.DeleteNhanVien(nhanVienDTO); // Gọi phương thức DAL đã sửa
            }
            catch (Exception ex)
            {
                // Ghi log lỗi (tùy chọn, nhưng rất nên làm)
                Console.WriteLine($"Lỗi khi xóa nhân viên: {ex.Message}");
                return false;
            }
        }

        public bool ThemNhanVien(NhanVienDTO nhanVienDTO, string username, string password)
        {
            return nhanVien.ThemNhanVien(nhanVienDTO, username, password);
        }

        public string GenerateNewIDNhanVien(string prefix)
        {
            return nhanVien.GenerateNewIDNhanVien(prefix);
        }
    }
}
