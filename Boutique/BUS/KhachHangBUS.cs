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
    class KhachHangBUS
    {
        private KhachHang khachHang = new KhachHang();

        public DataTable GetDanhSachKhachHang()
        {
            return khachHang.GetDanhSachKhachHang();
        }

        public string GenerateNewID(string prefix)
        {
            return khachHang.GenerateNewID(prefix);
        }

        public bool InsertKhachHang(KhachHangDTO kh)
        {
            return khachHang.InsertKhachHang(kh);
        }

        public DataRow GetKhachHangByID(string maKhachHang)
        {
            return khachHang.GetKhachHangByID(maKhachHang);
        }

        public void InsertKhachHangXoa(KhachHangDTO kh)
        {
            khachHang.insertKhachHangXoa(kh);
        }

        public int DeleteKhachHang(KhachHangDTO kh)
        {
            return khachHang.deleteKhachHang(kh);
        }

        public bool UpdateKhachHang(KhachHangDTO kh)
        {
            return khachHang.updateKhachHang(kh);
        }
    }
}
