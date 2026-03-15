using Boutique.GUI.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Boutique.DTO
{
    class ChiTietDonThueDTO
    {
        private string maChiTietDonThue;
        private string maDonThue;
        private string maSanPham;
        private int soLuong;
        private decimal giaThue;
        private int soNgayThue;
        private string ghiChu;

        public ChiTietDonThueDTO(string maChiTietDonThue, string maDonThue, string maSanPham, int soLuong, decimal giaThue, int soNgayThue, string ghiChu)
        {
            this.maChiTietDonThue = maChiTietDonThue;
            this.maDonThue = maDonThue;
            this.maSanPham = maSanPham;
            this.soLuong = soLuong;
            this.giaThue = giaThue;
            this.soNgayThue = soNgayThue;
            this.ghiChu = ghiChu;
        }

        public string GetMaChiTietDonThue()
        {
            return this.maChiTietDonThue;
        }

        public void SetMaChiTietDonThue(string maChiTietDonThue)
        {
            this.maChiTietDonThue = maChiTietDonThue;
        }

        public string GetMaDonThue()
        {
            return this.maDonThue;
        }

        public void SetMaDonThue(string maDonThue)
        {
            this.maDonThue = maDonThue;
        }

        public string GetMaSanPham()
        {
            return this.maSanPham;
        }

        public void SetMaSanPham(string maSanPham)
        {
            this.maSanPham = maSanPham;
        }

        public int GetSoLuong()
        {
            return this.soLuong;
        }

        public void SetSoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }

        public decimal GetGiaThue()
        {
            return this.giaThue;
        }

        public void SetGiaThue(decimal giaThue)
        {
            this.giaThue = giaThue;
        }

        public int GetSoNgayThue()
        {
            return this.soNgayThue;
        }

        public void SetSoNgayThue(int soNgayThue)
        {
            this.soNgayThue = soNgayThue;
        }

        public string GetGhiChu()
        {
            return this.ghiChu;
        }

        public void SetGhiChu(string ghiChu)
        {
            this.ghiChu = ghiChu;
        }
    }
}
