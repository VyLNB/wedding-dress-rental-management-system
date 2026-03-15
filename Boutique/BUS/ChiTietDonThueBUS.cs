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
    class ChiTietDonThueBUS
    {
        private ChiTietDonThue chiTietDonThue = new ChiTietDonThue();

        public bool InsertChiTietDonThue(ChiTietDonThueDTO chiTietDth)
        {
            return chiTietDonThue.InsertChiTietDonThue(chiTietDth);
        }

        public string GenerateNewChiTietDonThueID(string prefix)
        {
            return chiTietDonThue.GenerateNewChiTietDonThueID(prefix);
        }

        public DataTable GetChiTietDonThue(string maDonThue)
        {
            return chiTietDonThue.GetChiTietDonThue(maDonThue);
        }

        public DataTable GetSanPhamTrongDon(string maDonThue)
        {
            return chiTietDonThue.GetSanPhamTrongDon(maDonThue);
        }

        public bool UpdateTrangThaiDon(string maDonThue, string trangThai)
        {
            return chiTietDonThue.UpdateTrangThaiDon(maDonThue, trangThai);
        }
    }
}
