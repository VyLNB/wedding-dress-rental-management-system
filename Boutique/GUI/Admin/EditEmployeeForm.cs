//using System;
//using System.Windows.Forms;
//using Boutique.DTO; // Đảm bảo bạn using DTO

//namespace Boutique.GUI.Admin.All_User_Control
//{
//    public partial class EditEmployeeForm : Form
//    {
//        public NhanVienDTO EmployeeInfo { get; set; } // Thuộc tính để nhận và trả về thông tin nhân viên

//        public EditEmployeeForm()
//        {
//            InitializeComponent();
//        }

//        private void EditEmployeeForm_Load(object sender, EventArgs e)
//        {
//            // Hiển thị thông tin nhân viên hiện tại lên các control
//            if (EmployeeInfo != null)
//            {
//                txtTenNV.Text = EmployeeInfo.GetStaffName();
//                txtSdtNV.Text = EmployeeInfo.GetSoDienThoai();
//                txtEmailNV.Text = EmployeeInfo.GetStaffEmail();
//                txtDiachiNV.Text = EmployeeInfo.GetDiaChi();
//            }
//        }

//        private void btnLuu_Click(object sender, EventArgs e)
//        {
//            // Lấy thông tin đã chỉnh sửa từ các control
//            if (EmployeeInfo != null)
//            {
//                EmployeeInfo.SetStaffName(txtTenNV.Text);
//                EmployeeInfo.SetSoDienThoai(txtSdtNV.Text);
//                EmployeeInfo.SetStaffEmail(txtEmailNV.Text);
//                EmployeeInfo.SetDiaChi(txtDiachiNV.Text);

//                // Đặt DialogResult để báo hiệu rằng người dùng đã nhấn "Lưu"
//                this.DialogResult = DialogResult.OK;
//            }
//            this.Close(); // Đóng form
//        }

//        private void btnHuy_Click(object sender, EventArgs e)
//        {
//            // Đặt DialogResult để báo hiệu rằng người dùng đã nhấn "Hủy"
//            this.DialogResult = DialogResult.Cancel;
//            this.Close(); // Đóng form
//        }
//    }
//}

using System;
using System.Windows.Forms;
using Boutique.DTO;

namespace Boutique.GUI.Admin.All_User_Control
{
    public partial class EditEmployeeForm : Form
    {
        public NhanVienDTO EmployeeInfo { get; set; }

        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            if (EmployeeInfo != null)
            {
                // Hiển thị đúng các thông tin nhân viên vào control tương ứng
                txtTenNV.Text = EmployeeInfo.GetStaffName();
                txtSdtNV.Text = EmployeeInfo.GetSoDienThoai();
                txtEmailNV.Text = EmployeeInfo.GetStaffEmail();
                txtDiachiNV.Text = EmployeeInfo.GetDiaChi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (EmployeeInfo != null)
            {
                // Gán thông tin người dùng nhập vào lại cho DTO
                EmployeeInfo.SetStaffName(txtTenNV.Text.Trim());
                EmployeeInfo.SetSoDienThoai(txtSdtNV.Text.Trim());
                EmployeeInfo.SetStaffEmail(txtEmailNV.Text.Trim());
                EmployeeInfo.SetDiaChi(txtDiachiNV.Text.Trim());

                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
