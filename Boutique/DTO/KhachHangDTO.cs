using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.DTO
{
    class KhachHangDTO
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string email;
        private string soDienThoai;
        private string diaChi;

        public KhachHangDTO(string maKhachHang, string tenKhachHang, string email, string soDienThoai, string diaChi)
        {
            this.maKhachHang = maKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
        }

        public string GetMaKhachHang()
        {
            return this.maKhachHang;
        }

        public void SetMaKhachHang(string maKhachHang)
        {
            this.maKhachHang = maKhachHang;
        }

        public string GetTenKhachHang()
        {
            return this.tenKhachHang;
        }

        public void SetTenKhachHang(string tenKhachHang)
        {
            this.tenKhachHang = tenKhachHang;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetSoDienThoai()
        {
            return this.soDienThoai;
        }

        public void SetSoDienThoai(string soDienThoai)
        {
            this.soDienThoai = soDienThoai;
        }

        public string GetDiaChi()
        {
            return this.diaChi;
        }

        public void SetDiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }
    }
}
