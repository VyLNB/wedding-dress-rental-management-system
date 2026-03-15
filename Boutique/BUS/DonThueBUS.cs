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
    class DonThueBUS
    {
        private DonThue donThue = new DonThue();

        public DataTable GetDanhSachDonThue()
        {
            return donThue.GetDanhSachDonThue();
        }

        public int CheckKhachHang(KhachHangDTO khachHang)
        {
            return donThue.checkKhachHang(khachHang);
        }

        public string GenerateNewDonThueID(String prefix)
        {
            return donThue.GenerateNewDonThueID(prefix);
        }

        public bool InsertDonThue(KhachHangDTO khachHang, DonThueDTO dt)
        {
            return donThue.InsertDonThue(khachHang, dt);
        }

        public int CheckDonThueTonTai(string maDonThue)
        {
            return donThue.CheckDonThueTonTai(maDonThue);
        }

        public int CheckSanPham(SanPhamDTO sanPhamDTO)
        {
            return donThue.CheckSanPham(sanPhamDTO);
        }

        public DataTable GetDoanhThuTheoNgay(DateTime startDate, DateTime endDate)
        {
            return donThue.GetDoanhThuTheoNgay(startDate, endDate);
        }

    }
}
