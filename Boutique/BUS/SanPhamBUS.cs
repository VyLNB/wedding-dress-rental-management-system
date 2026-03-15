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
    class SanPhamBUS
    {
        private SanPham sanPham = new SanPham();

        public DataTable GetDanhSachSanPham()
        {
            return sanPham.get_DanhSachSanPham();
        }

        public string GenerateNewProductID()
        {
            return sanPham.GenerateNewProductID();
        }

        public DataTable getDataToGridView()
        {
            return sanPham.getDataToGridView();
        }

        public bool InsertSanPham(string maSP, string maLoaiSP, string tenSP, decimal giaTien, int soLuong, string trangThai)
        {
            return sanPham.insertSanPham(maSP, maLoaiSP, tenSP, giaTien, soLuong, trangThai);
        }

        public DataRow GetSanPhamByID(string maSanPham)
        {
            return sanPham.getSanPhamByID(maSanPham);
        }

        public void InsertSanPhamXoa(string maSanPham, string tenSanPham, decimal giaThue, string maLoaiSP)
        {
            sanPham.insertSanPhamXoa(maSanPham, tenSanPham, giaThue, maLoaiSP);
        }

        public int DeleteSanPham(string maSanPham)
        {
            return sanPham.deleteSanPham(maSanPham);
        }

        public bool UpdateSanPham(SanPhamDTO sp)
        {
            return sanPham.updateSanPham(sp);
        }

        //them
        public bool IsSanPhamInChiTietDonThue(string maSanPham)
        {
            return sanPham.IsSanPhamInChiTietDonThue(maSanPham);
        }
    }
}
