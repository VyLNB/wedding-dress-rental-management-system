using Boutique.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.BUS
{
    class ThanhToanBUS
    {
        private ThanhToan thanhToan = new ThanhToan();

        public DataTable GetDanhSachThanhToan()
        {
            return thanhToan.GetDanhSachThanhToan();
        }
    }
}
