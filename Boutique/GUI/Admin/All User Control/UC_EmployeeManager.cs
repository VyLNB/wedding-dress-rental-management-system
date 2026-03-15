////using System;
////using System.Collections.Generic;
////using System.ComponentModel;
////using System.Data;
////using System.Drawing;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using System.Windows.Forms;

////namespace Boutique.GUI.Admin.All_User_Control
////{
////    public partial class UC_EmployeeManager : Form
////    {
////        public UC_EmployeeManager()
////        {
////            InitializeComponent();
////        }
////    }
////}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Boutique.BUS; // Thêm using cho BUS
//using Boutique.DTO; // Thêm using cho DTO

//namespace Boutique.GUI.Admin.All_User_Control
//{
//    public partial class UC_EmployeeManager : UserControl
//    {
//        NhanVienBUS nhanVienBUS = new NhanVienBUS(); // Khởi tạo đối tượng BUS
//        //function fn = new function(); // Không cần dùng nữa
//        //String query; // Không cần dùng nữa

//        public UC_EmployeeManager()
//        {
//            InitializeComponent();
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void UC_EmployeeManager_Load(object sender, EventArgs e)
//        {
//            getMaxID();
//            LoadDanhSachNhanVien(); // Load danh sách nhân viên khi UserControl được load
//        }

//        //---------
//        public void getMaxID()
//        {
//            //query = "select max(staffID) from staff";
//            //DataSet ds = fn.getData(query);

//            //if (ds.Tables[0].Rows[0][0].ToString() != "")
//            //{
//            //    Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
//            //    lblToset.Text = (num + 1).ToString();
//            //}

//            // Thay bằng gọi BUS
//            lblToset.Text = nhanVienBUS.GenerateNewIDNhanVien("ST");
//        }

//        //private void btnDangky_Click(object sender, EventArgs e)
//        //{
//        //    if (txtTenNV.Text != "" && txtEmailNV.Text != "" && txtSdtNV.Text != "" && txtDiachiNV.Text != "" && txtUsernameNV.Text != "" && txtPassNV.Text != "")
//        //    {
//        //        String hoTen = txtTenNV.Text;
//        //        String email = txtEmailNV.Text;
//        //        String soDienThoai = txtSdtNV.Text;
//        //        String diaChi = txtDiachiNV.Text;
//        //        //String staffName = txtUsernameNV.Text;
//        //        //String staffPassword = txtPassNV.Text;
//        //        String staffID = lblToset.Text; // Lấy staffID đã tạo ở hàm getMaxID()

//        //        // Tạo đối tượng DTO
//        //        NhanVienDTO nhanVienDTO = new NhanVienDTO(staffID, hoTen, email, soDienThoai, diaChi);

//        //        try
//        //        {
//        //            // Thêm dữ liệu vào bảng staff và staffChiTiet thông qua BUS
//        //            //bool result = nhanVienBUS.ThemNhanVien(nhanVienDTO, txtUsernameNV.Text, txtPassNV.Text);

//        //            //if (result)
//        //            //{
//        //            //    MessageBox.Show("Đăng ký nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        //            //    clearAll();
//        //            //}
//        //            //else
//        //            //{
//        //            //    MessageBox.Show("Đăng ký không thành công. Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //            //}
//        //            MessageBox.Show("Chức năng thêm nhân viên chưa được triển khai");

//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //        }
//        //    }
//        //    else
//        //    {
//        //        MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        //    }
//        //}

//        private void btnDangky_Click(object sender, EventArgs e)
//        {
//            if (txtTenNV.Text != "" && txtEmailNV.Text != "" && txtSdtNV.Text != "" && txtDiachiNV.Text != ""
//                && txtUsernameNV.Text != "" && txtPassNV.Text != "")
//            {
//                // Lấy thông tin từ các textbox
//                string hoTen = txtTenNV.Text;
//                string email = txtEmailNV.Text;
//                string soDienThoai = txtSdtNV.Text;
//                string diaChi = txtDiachiNV.Text;
//                string username = txtUsernameNV.Text;
//                string password = txtPassNV.Text;

//                // Lấy mã nhân viên mới
//                string staffID = lblToset.Text;

//                // Tạo DTO nhân viên
//                NhanVienDTO nhanVienDTO = new NhanVienDTO(staffID, hoTen, email, soDienThoai, diaChi);

//                try
//                {
//                    bool result = nhanVienBUS.ThemNhanVien(nhanVienDTO, username, password);

//                    if (result)
//                    {
//                        MessageBox.Show("Đăng ký nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        clearAll();
//                        getMaxID(); // tạo ID mới cho lần tiếp theo
//                        LoadDanhSachNhanVien(); // cập nhật lại bảng
//                    }
//                    else
//                    {
//                        MessageBox.Show("Đăng ký không thành công. Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//            else
//            {
//                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//        }


//        private void tabpageTTNV_Enter(object sender, EventArgs e)
//        {
//            //query = "select * from staffChiTiet";
//            //DataSet ds = fn.getData(query);
//            //guna2DataGridView1.DataSource = ds.Tables[0];
//            DataGridViewTTNV.DataSource = nhanVienBUS.GetDanhSachNhanVien();
//            //LoadDanhSachNhanVien();
//        }

//        private void btnCapnhat_Click(object sender, EventArgs e)
//        {
//            if (txtTenNV.Text != "" && txtEmailNV.Text != "" && txtSdtNV.Text != "" && txtDiachiNV.Text != "")
//            {
//                // Lấy dữ liệu từ các TextBox
//                //giasu
//                string staffID = lblToset.Text;
//                string hoTen = txtTenNV.Text;
//                string email = txtEmailNV.Text;
//                string soDienThoai = txtSdtNV.Text;
//                string diaChi = txtDiachiNV.Text;

//                // Tạo đối tượng NhanVienDTO
//                NhanVienDTO nhanVienDTO = new NhanVienDTO(staffID, hoTen, email, soDienThoai, diaChi);

//                try
//                {
//                    // Gọi phương thức cập nhật từ BUS
//                    bool result = nhanVienBUS.UpdateNhanVien(nhanVienDTO);

//                    if (result)
//                    {
//                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        tabpageTTNV_Enter(this, null); // Cập nhật lại DataGridView
//                    }
//                    else
//                    {
//                        MessageBox.Show("Cập nhật không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//            else
//            {
//                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//        }

//        private void DataGridViewTTNV_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (DataGridViewTTNV.Rows.Count > 0)
//            {
//                //duphong SDT cho ID
//                lblToset.Text = DataGridViewTTNV.CurrentRow.Cells[0].Value.ToString();
//                txtTenNV.Text = DataGridViewTTNV.CurrentRow.Cells[1].Value.ToString();
//                txtSdtNV.Text = DataGridViewTTNV.CurrentRow.Cells[2].Value.ToString();
//                txtEmailNV.Text = DataGridViewTTNV.CurrentRow.Cells[3].Value.ToString();
//                txtDiachiNV.Text = DataGridViewTTNV.CurrentRow.Cells[4].Value.ToString();
//            }
//        }

//        //private void btnXoa_Click(object sender, EventArgs e)
//        //{
//        //    if (txtIDdlt.Text.Trim() != "")
//        //    {
//        //        string staffIDToDelete = txtIDdlt.Text.Trim();
//        //        NhanVienDTO nhanVienDTO = new NhanVienDTO(staffIDToDelete, "", "", "", ""); // Chỉ cần staffID để xóa

//        //        try
//        //        {
//        //            //Gọi BUS để xóa nhân viên
//        //            //bool result = nhanVienBUS.XoaNhanVien(nhanVienDTO);
//        //            int row = nhanVienBUS.DeleteNhanVienChiTiet(nhanVienDTO);
//        //            if (row > 0)
//        //            {
//        //                int deleteNhanVien = nhanVienBUS.DeleteNhanVien(nhanVienDTO);
//        //                if (deleteNhanVien > 0)
//        //                {
//        //                    MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        //                    //tabpageTTNV_Enter(this, null); // Cập nhật lại DataGridView
//        //                    //txtIDdlt.Clear();
//        //                    txtIDdlt.Text = "";
//        //                }
//        //                else
//        //                {
//        //                    MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //                }
//        //            }
//        //            //if (result)
//        //            //{
//        //            //    MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        //            //    tabpageTTNV_Enter(this, null); // Cập nhật lại DataGridView
//        //            //    txtIDdlt.Clear();
//        //            //}
//        //            //else
//        //            //{
//        //            //    MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //            //}
//        //            //MessageBox.Show("Chức năng xóa nhân viên chưa được triển khai");
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //        }
//        //    }
//        //    else
//        //    {
//        //        MessageBox.Show("Vui lòng nhập ID nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        //    }
//        //}

//        private void btnXoa_Click(object sender, EventArgs e)
//        {
//            if (txtIDdlt.Text.Trim() != "")
//            {
//                string staffIDToDelete = txtIDdlt.Text.Trim();
//                NhanVienDTO nhanVienDTO = new NhanVienDTO(staffIDToDelete, "", "", "", ""); // Chỉ cần staffID để xóa

//                try
//                {
//                    // Gọi BUS để xóa nhân viên (đã sửa để xóa cả hai bảng)
//                    bool result = nhanVienBUS.DeleteNhanVien(nhanVienDTO);

//                    if (result)
//                    {
//                        MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        // Cập nhật lại DataGridView (gọi phương thức tải lại dữ liệu)
//                        LoadDanhSachNhanVien();
//                        txtIDdlt.Text = ""; // Xóa nội dung textbox
//                    }
//                    else
//                    {
//                        MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//            else
//            {
//                MessageBox.Show("Vui lòng nhập ID nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//        }

//        private void UC_EmployeeManager_Leave(object sender, EventArgs e)
//        {
//            clearAll();
//        }


//        private void clearAll()
//        {
//            txtDiachiNV.Clear();
//            txtEmailNV.Clear();
//            //giasu
//            //lblToset.Clear();
//            txtIDdlt.Clear();
//            txtPassNV.Clear();
//            txtSdtNV.Clear();
//            txtTenNV.Clear();
//            txtUsernameNV.Clear();
//        }

//        private void LoadDanhSachNhanVien()
//        {
//            try
//            {
//                DataTable dt = nhanVienBUS.GetDanhSachNhanVien();
//                DataGridViewTTNV.DataSource = dt;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void tabpageTTNV_Click(object sender, EventArgs e)
//        {
//            LoadDanhSachNhanVien();
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
using Boutique.BUS;
using Boutique.DTO;

namespace Boutique.GUI.Admin.All_User_Control
{
    public partial class UC_EmployeeManager : UserControl
    {
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private SettingBUS settingBUS;
        public UC_EmployeeManager()
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

        private void UC_EmployeeManager_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien(); // Load danh sách nhân viên khi UserControl được load
            getMaxID();
        }

        private void LoadDanhSachNhanVien()
        {
            try
            {
                DataTable danhSach = nhanVienBUS.GetDanhSachNhanVien();
                DataGridViewTTNV.DataSource = danhSach;
                DataGridViewXoaNV.DataSource = danhSach.Copy(); // Sử dụng bản sao để tránh ảnh hưởng lẫn nhau
                setEmployee(DataGridViewTTNV);
                setEmployee(DataGridViewXoaNV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getMaxID()
        {
            lblToset.Text = nhanVienBUS.GenerateNewIDNhanVien("ST"); // Gọi BUS để lấy ID mới
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtEmailNV.Text) || string.IsNullOrWhiteSpace(txtSdtNV.Text) || string.IsNullOrWhiteSpace(txtDiachiNV.Text) || string.IsNullOrWhiteSpace(txtUsernameNV.Text) || string.IsNullOrWhiteSpace(txtPassNV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng xử lý nếu thông tin không đầy đủ
            }

            NhanVienDTO nhanVienDTO = new NhanVienDTO(lblToset.Text, txtTenNV.Text, txtEmailNV.Text, txtSdtNV.Text, txtDiachiNV.Text);

            try
            {
                bool result = nhanVienBUS.ThemNhanVien(nhanVienDTO, txtUsernameNV.Text, txtPassNV.Text);

                if (result)
                {
                    MessageBox.Show("Đăng ký nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                    getMaxID();        // Cập nhật lblToset cho lần thêm tiếp theo
                    LoadDanhSachNhanVien(); // Tải lại danh sách để cập nhật DataGridView
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công. Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtEmailNV.Text) || string.IsNullOrWhiteSpace(txtSdtNV.Text) || string.IsNullOrWhiteSpace(txtDiachiNV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng xử lý nếu thông tin không đầy đủ
            }

            NhanVienDTO nhanVienDTO = new NhanVienDTO(lblToset.Text, txtTenNV.Text, txtEmailNV.Text, txtSdtNV.Text, txtDiachiNV.Text);

            try
            {
                bool result = nhanVienBUS.UpdateNhanVien(nhanVienDTO);

                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien(); // Tải lại danh sách để cập nhật DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDdlt.Text))
            {
                MessageBox.Show("Vui lòng nhập ID nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng xử lý nếu ID không được nhập
            }

            NhanVienDTO nhanVienDTO = new NhanVienDTO(txtIDdlt.Text, "", "", "", "");

            try
            {
                bool result = nhanVienBUS.DeleteNhanVien(nhanVienDTO);

                if (result)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien(); // Tải lại danh sách để cập nhật DataGridView
                    txtIDdlt.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewTTNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTTNV.Rows.Count > 0 && e.RowIndex >= 0) // Kiểm tra hợp lệ của e.RowIndex
            {
                lblToset.Text = DataGridViewTTNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = DataGridViewTTNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSdtNV.Text = DataGridViewTTNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmailNV.Text = DataGridViewTTNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiachiNV.Text = DataGridViewTTNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void tabctrlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Không cần thiết phải gọi setEmployee ở đây, vì đã được gọi trong LoadDanhSachNhanVien
            // và sau mỗi lần thêm, sửa, xóa.
        }

        private void tabpageTTNV_Click(object sender, EventArgs e)
        {
            // Không cần thiết phải gọi LoadDanhSachNhanVien() ở đây.  Nó đã được gọi ở UC_EmployeeManager_Load
            // và sau mỗi lần thêm, sửa, xóa.  Việc gọi lại ở đây có thể gây tải lại không cần thiết.
        }

        private void setEmployee(DataGridView dgv)
        {
            // Đảm bảo rằng DataGridView đã được liên kết với dữ liệu trước khi truy cập Columns
            if (dgv.DataSource != null)
            {
                dgv.Columns[0].HeaderText = "Mã Nhân Viên";
                dgv.Columns[1].HeaderText = "Họ Tên";
                dgv.Columns[2].HeaderText = "Số Điện Thoại";
                dgv.Columns[3].HeaderText = "Email";
                dgv.Columns[4].HeaderText = "Địa Chỉ";
            }
        }

        private void clearAll()
        {
            txtDiachiNV.Clear();
            txtEmailNV.Clear();
            txtIDdlt.Clear();
            txtPassNV.Clear();
            txtSdtNV.Clear();
            txtTenNV.Clear();
            txtUsernameNV.Clear();
        }

        private void UC_EmployeeManager_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (DataGridViewTTNV.SelectedRows.Count == 1)
            {
                // Lấy dữ liệu của dòng được chọn
                DataGridViewRow selectedRow = DataGridViewTTNV.SelectedRows[0];
                string staffID = selectedRow.Cells[0].Value.ToString();
                string hoTen = selectedRow.Cells[1].Value.ToString();
                string soDienThoai = selectedRow.Cells[2].Value.ToString();
                string email = selectedRow.Cells[3].Value.ToString();
                string diaChi = selectedRow.Cells[4].Value.ToString();

                // Tạo một DTO để chứa thông tin nhân viên
                NhanVienDTO nhanVienDTO = new NhanVienDTO(staffID, hoTen, soDienThoai, email, diaChi);

                // Tạo và hiển thị Form sửa nhân viên
                EditEmployeeForm editForm = new EditEmployeeForm();
                editForm.EmployeeInfo = nhanVienDTO; // Truyền thông tin nhân viên vào Form

                // Hiển thị form dưới dạng Dialog và kiểm tra kết quả
                DialogResult result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Nếu người dùng nhấn "Lưu" trong Form sửa, cập nhật thông tin
                    try
                    {
                        bool updateResult = nhanVienBUS.UpdateNhanVien(editForm.EmployeeInfo);
                        if (updateResult)
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachNhanVien(); // Tải lại danh sách để cập nhật DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Nếu người dùng nhấn "Hủy" hoặc đóng form, không làm gì cả (thông tin không thay đổi)
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}