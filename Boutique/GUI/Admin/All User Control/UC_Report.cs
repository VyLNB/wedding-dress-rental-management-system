//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Boutique.GUI.Admin.All_User_Control
//{
//    public partial class UC_Report : Form
//    {
//        public UC_Report()
//        {
//            InitializeComponent();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data.SqlClient;
using Boutique.BUS; // Thêm các using cho BUS layers
using Boutique.DTO;


namespace Boutique.GUI.Admin.All_User_Control
{
    public partial class UC_Report : UserControl
    {

        // Khởi tạo các đối tượng BUS
        ThanhToanBUS thanhToanBUS = new ThanhToanBUS();
        DonThueBUS donThueBUS = new DonThueBUS();
        private SettingBUS settingBUS;

        public UC_Report()
        {
            InitializeComponent();
            settingBUS = new SettingBUS();
            ApplySettings();
        }


        public void ApplySettings()
        {
            SettingDTO settings = new SettingBUS().GetSettings();

            if (settings.ThemeMode == "Dark")
            {
                this.BackColor = System.Drawing.Color.Black;
                this.ForeColor = System.Drawing.Color.White;
            }
            else if (settings.ThemeMode == "Medium")
            {
                this.BackColor = System.Drawing.Color.LightSkyBlue; // Màu xanh trung bình
                this.ForeColor = System.Drawing.Color.Black;
            }
            else // Light
            {
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = System.Drawing.Color.Black;
            }

            this.Font = new System.Drawing.Font(settings.FontStyle, 10);
        }

        private void UC_Report_Load(object sender, EventArgs e)
        {
            // Đặt giá trị mặc định cho Guna2DateTimePicker trong tab Thống kê doanh thu
            dtpkStartDoanhthu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpkEndDoanhthu.Value = DateTime.Now;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpkStartDoanhthu.Value.Date;
            DateTime endDate = dtpkEndDoanhthu.Value.Date;

            try
            {
                // Gọi BUS để lấy dữ liệu doanh thu
                DataTable dtDoanhThu = donThueBUS.GetDoanhThuTheoNgay(startDate, endDate);
                DataGridViewDoanhthu.DataSource = dtDoanhThu;

                // Tính toán tổng doanh thu
                decimal tongDoanhThu = 0;
                foreach (DataRow row in dtDoanhThu.Rows)
                {
                    if (row["tongTien"] != DBNull.Value && decimal.TryParse(row["tongTien"].ToString(), out decimal tien))
                    {
                        tongDoanhThu += tien;
                    }
                }

                lblTongDoanhthu.Text = string.Format("Tổng doanh thu: {0:N0} VNĐ", tongDoanhThu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê doanh thu: " + ex.Message);
            }
        }

        private void tabctrlBaocao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
