using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.DTO
{
    public class NhanVienDTO
    {
        private string staffID;
        private string staffName;
        private string staffEmail;
        private string soDienThoai;
        private string diaChi;

        public NhanVienDTO(string staffID, string staffName, string staffEmail, string soDienThoai, string diaChi)
        {
            this.staffID = staffID;
            this.staffName = staffName;
            this.staffEmail = staffEmail;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
        }

        public string GetStaffID()
        {
            return this.staffID;
        }

        public void SetStaffID(string staffID)
        {
            this.staffID = staffID;
        }

        public string GetStaffName()
        {
            return this.staffName;
        }

        public void SetStaffName(string staffName)
        {
            this.staffName = staffName;
        }

        public string GetStaffEmail()
        {
            return this.staffEmail;
        }

        public void SetStaffEmail(string staffEmail)
        {
            this.staffEmail = staffEmail;
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
