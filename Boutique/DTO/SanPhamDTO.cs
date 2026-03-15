using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.DTO
{
    class SanPhamDTO
    {
        private string maSanPham;
        private string tenSanPham;
        private decimal giaThue;
        private string trangThai;
        private string maLoaiSP;
        private int soLuong;

        public SanPhamDTO(string maSanPham, string tenSanPham, decimal giaThue, string trangThai, string maLoaiSP, int soLuong)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.giaThue = giaThue;
            this.trangThai = trangThai;
            this.maLoaiSP = maLoaiSP;
            this.soLuong = soLuong;
        }

        public string getMaSanPham()
        {
            return this.maSanPham;
        }

        public void setMaSanPham(string maSanPham)
        {
            this.maSanPham = maSanPham;
        }
        
        public string getTenSanPham()
        {
            return this.tenSanPham;
        }

        public void setTenSanPham(string tenSanPham)
        {
            this.tenSanPham = tenSanPham;
        }

        public decimal getGiaThue()
        {
            return this.giaThue;
        }

        public void setGiaThue(decimal giaThue)
        {
            this.giaThue = giaThue;
        }

        public string getTrangThai()
        {
            return this.trangThai;
        }

        public void setTrangThai(string trangThai)
        {
            this.trangThai = trangThai;
        }

        public string getMaLoaiSP()
        {
            return this.maLoaiSP;
        }

        public void setMaLoaiSP(string maLoaiSP)
        {
            this.maLoaiSP = maLoaiSP;
        }

        public int getSoLuong()
        {
            return this.soLuong;
        }

        public void setSoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }
    }
}
