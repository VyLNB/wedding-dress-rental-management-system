using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Boutique.DTO
{
    class DonThueDTO
    {
        private string maDonThue;
        private string maKhachHang;
        private DateTime ngayDat;
        private DateTime ngayNhan;
        private DateTime ngayTraDuKien;
        private DateTime ngayTraThucTe;
        private decimal tienCoc;
        private decimal tongTien;
        private string trangThai;
        private string ghiChu;

        public DonThueDTO(string maDonThue, string maKhachHang, DateTime ngayDat, DateTime ngayNhan, DateTime ngayTraDuKien, DateTime ngayTraThucTe, decimal tienCoc, decimal tongTien, string trangThai, string ghiChu)
        {
            this.maDonThue = maDonThue;
            this.maKhachHang = maKhachHang;
            this.ngayDat = ngayDat;
            this.ngayNhan = ngayNhan;
            this.ngayTraDuKien = ngayTraDuKien;
            this.ngayTraThucTe = ngayTraThucTe;
            this.tienCoc = tienCoc;
            this.tongTien = tongTien;
            this.trangThai = trangThai;
            this.ghiChu = ghiChu;
        }

        public DonThueDTO(string maDonThue, string maKhachHang, DateTime ngayNhan, DateTime ngayTraDuKien, decimal tienCoc, string trangThai, string ghiChu)
        {
            this.maDonThue = maDonThue;
            this.maKhachHang = maKhachHang;
            //this.ngayDat = ngayDat;
            this.ngayNhan = ngayNhan;
            this.ngayTraDuKien = ngayTraDuKien;
            //this.ngayTraThucTe = ngayTraThucTe;
            this.tienCoc = tienCoc;
            //this.tongTien = tongTien;
            this.trangThai = trangThai;
            this.ghiChu = ghiChu;
        }

        public string GetMaDonThue()
        {
            return this.maDonThue;
        }

        public void SetMaDonThue(string maDonThue)
        {
            this.maDonThue = maDonThue;
        }

        public string GetMaKhachHang()
        {
            return this.maKhachHang;
        }

        public void SetMaKhachHang(string maKhachHang)
        {
            this.maKhachHang = maKhachHang;
        }

        public DateTime GetNgayDat()
        {
            return this.ngayDat;
        }

        public void SetNgayDat(DateTime ngayDat)
        {
            this.ngayDat = ngayDat;
        }

        public DateTime GetNgayNhan()
        {
            return this.ngayNhan;
        }

        public void SetNgayNhan(DateTime ngayNhan)
        {
            this.ngayNhan = ngayNhan;
        }

        public DateTime GetNgayTraDuKien()
        {
            return this.ngayTraDuKien;
        }

        public void SetNgayTraDuKien(DateTime ngayTraDuKien)
        {
            this.ngayTraDuKien = ngayTraDuKien;
        }

        public DateTime GetNgayTraThucTe() {
            return this.ngayTraThucTe;
        }

        public void SetNgayTraThucTe(DateTime ngayTraThucTe)
        {
            this.ngayTraThucTe = ngayTraThucTe;
        }

        public decimal GetTongTien()
        {
            return this.tongTien;
        }

        public void SetTongTien (decimal tongTien)
        {
            this.tongTien = tongTien;
        }

        public decimal GetTienCoc()
        {
            return this.tienCoc;
        }

        public void SetTienCoc(decimal tienCoc)
        {
            this.tienCoc = tienCoc;
        }

        public string GetTrangThai()
        {
            return this.trangThai;
        }

        public void SetTrangThai(string trangThai)
        {
            this.trangThai = trangThai;
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
