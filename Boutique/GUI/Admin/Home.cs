//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Boutique.GUI.Admin
//{
//    public partial class Home : Form
//    {
//        public Home()
//        {
//            InitializeComponent();
//        }

//        private void panel2_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void btnExit_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void btnQLSP_Click(object sender, EventArgs e)
//        {
//            pnlMoving.Left = btnQLSP.Left + 50;
//            uC_AddProduct1.Visible = true;
//            uC_AddProduct1.BringToFront();
//        }

//        private void QLNV_Load(object sender, EventArgs e)
//        {
//            uC_AddProduct1.Visible = false;
//            // uC_Report1.Visible = false; // Đảm bảo UC_Report cũng ẩn khi form tải
//            // uC_EmployeeManager1.Visible = false;
//            btnQLSP.PerformClick(); // Hiển thị UC_AddProduct ban đầu
//        }

//        private void btnBCDT_Click(object sender, EventArgs e)
//        {
//            pnlMoving.Left = btnQLSP.Left + 275;

//            // Ẩn UC_AddProduct nếu nó đang hiển thị
//            uC_AddProduct1.Visible = false;
//            uC_AddProduct1.SendToBack(); // Đưa UC_AddProduct ra phía sau các control khác

//            // Hiển thị UC_Report
//            //uC_Report1.Visible = true;
//            // uC_Report1.BringToFront(); // Đưa UC_Report lên phía trước
//        }

//        private void btnQLNV_Click(object sender, EventArgs e)
//        {
//            pnlMoving.Left = btnQLSP.Left + 520;
//            // uC_EmployeeManager1.Visible = true;
//            // uC_EmployeeManager1.BringToFront();
//        }

//        private void btnCaidat_Click(object sender, EventArgs e)
//        {

//        }

//        private void uC_Report1_Load(object sender, EventArgs e)
//        {

//        }

//        private void Home_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boutique.GUI.Admin.All_User_Control;
using System;
using System.Windows.Forms;
using Boutique.GUI.Admin;
using Boutique.BUS;
using Boutique.DTO;


namespace Boutique.GUI.Admin
{
    public partial class Home : Form
    {
        private SettingBUS settingBUS;
        private UC_AddProduct uC_AddProduct1 = new UC_AddProduct();
        private UC_EmployeeManager uC_EmployeeManager1 = new UC_EmployeeManager();
        private UC_Report uC_Report1 = new UC_Report();
        private UC_Setting uC_Setting1 = new UC_Setting();

        public Home()
        {
            InitializeComponent();
            AddUserControls();
            settingBUS = new SettingBUS();
            ApplySettings();

            // Đăng ký sự kiện khi cài đặt thay đổi
            uC_Setting1.SettingsChanged += OnSettingsChanged;
        }

        private void ApplySettings()
        {
            SettingDTO settings = settingBUS.GetSettings();

            // Áp dụng ngôn ngữ
            if (settings.Language == "Vietnamese")
            {
                this.Text = "Trang chủ";
            }
            else
            {
                this.Text = "Home";
            }

            // Áp dụng chế độ màu
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

            // Áp dụng kiểu chữ
            this.Font = new System.Drawing.Font(settings.FontStyle, 10);

            // Áp dụng cài đặt cho các UserControl
            uC_AddProduct1.ApplySettings();
            uC_EmployeeManager1.ApplySettings();
            uC_Report1.ApplySettings();
        }
        private void AddUserControls()
        {
            panel2.Controls.Add(uC_AddProduct1);
            panel2.Controls.Add(uC_EmployeeManager1);
            panel2.Controls.Add(uC_Report1);
            panel2.Controls.Add(uC_Setting1); // Thêm UC_Setting vào pan

            uC_AddProduct1.Dock = DockStyle.Fill;
            uC_EmployeeManager1.Dock = DockStyle.Fill;
            uC_Report1.Dock = DockStyle.Fill;
            uC_Setting1.Dock = DockStyle.Fill;
        }

        private void OnSettingsChanged(object sender, EventArgs e)
        {
            ApplySettings();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnQLSP.Left + 80;
            uC_AddProduct1.Visible = true;
            uC_AddProduct1.BringToFront();
            uC_Report1.SendToBack();
            uC_EmployeeManager1.SendToBack();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            uC_AddProduct1.Visible = false;
            uC_Report1.Visible = false;
            uC_EmployeeManager1.Visible = false;
            btnQLSP.PerformClick();
        }

        private void btnBCDT_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnQLSP.Left + 600;
            uC_AddProduct1.Visible = false;
            uC_AddProduct1.SendToBack();
            uC_Report1.Visible = true;
            uC_Report1.BringToFront();
            uC_EmployeeManager1.SendToBack();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnQLSP.Left + 1130;
            uC_AddProduct1.Visible = false;
            uC_AddProduct1.SendToBack();
            uC_Report1.SendToBack();
            uC_EmployeeManager1.Visible = true;
            uC_EmployeeManager1.BringToFront();
        }

        private void btnCaidat_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnQLSP.Left + 1620; // Di chuyển thanh chỉ báo (nếu có)
            uC_AddProduct1.Visible = false;
            uC_EmployeeManager1.Visible = false;
            uC_Report1.Visible = false;

            uC_Setting1.Visible = true; // Hiển thị UC_Setting
            uC_Setting1.BringToFront(); // Đưa UC_Setting lên phía tr
        }
    }
}