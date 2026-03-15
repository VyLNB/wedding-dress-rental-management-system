using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boutique.DAL;
using Boutique.BUS;
using Boutique.DTO;

namespace Boutique.GUI.Admin
{
    public partial class NhanVien : UserControl
    {
        private NhanVienBUS nhanVienBus = new NhanVienBUS();
        private NhanVienDTO nhanVienDTO;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            SetupDataGridView();
        }

        private void LoadDanhSachNhanVien()
        {
            try
            {
                DataTable dt = nhanVienBus.GetDanhSachNhanVien();
                nhanVienList.DataSource = dt;
                nhanVienList.Columns["staffID"].HeaderText = "Mã nhân viên";
                nhanVienList.Columns["hoTen"].HeaderText = "Họ tên";
                nhanVienList.Columns["email"].HeaderText = "Email";
                //nhanVienList.Columns["hoTen"].HeaderText = "Họ tên";
                nhanVienList.Columns["soDienThoai"].HeaderText = "Số điện thoại";
                nhanVienList.Columns["diaChi"].HeaderText = "Địa chỉ";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            // Đảm bảo tự động tạo cột từ DataSource
            nhanVienList.AutoGenerateColumns = true;

            // Thêm cột hành động với nút
            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Action",
                HeaderText = "Hành động",
                Text = "Sửa | Xóa",
                UseColumnTextForButtonValue = true
            };
            nhanVienList.Columns.Add(actionColumn);

            // Gắn sự kiện CellContentClick
            //nhanVienList.CellContentClick += NhanVienList_CellContentClick;
        }

        //private void NhanVienList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Kiểm tra nếu click vào ô hợp lệ trong cột Action
        //    if (e.RowIndex >= 0 && nhanVienList.Columns[e.ColumnIndex].Name == "Action")
        //    {
        //        // Lấy ID nhân viên từ dòng được click
        //        string staffID = nhanVienList.Rows[e.RowIndex].Cells["staffID"].Value.ToString();
        //        string staffName = nhanVienList.Rows[e.RowIndex].Cells["hoTen"].Value.ToString();
        //        string staffEmail = nhanVienList.Rows[e.RowIndex].Cells["email"].Value.ToString();
        //        string soDienThoai = nhanVienList.Rows[e.RowIndex].Cells["soDienThoai"].Value.ToString();
        //        string diaChi = nhanVienList.Rows[e.RowIndex].Cells["diaChi"].Value.ToString();
        //        nhanVienDTO = new NhanVienDTO(staffID, staffName, staffEmail, soDienThoai, diaChi);

        //        // Hiển thị context menu để chọn hành động
        //        ContextMenuStrip menu = new ContextMenuStrip();
        //        menu.Items.Add("Sửa", null, (s, ev) =>
        //        {
        //            // Logic sửa nhân viên
        //            MessageBox.Show($"Sửa nhân viên có ID: {staffID}");
        //            frmEditNhanVien formEdit = new frmEditNhanVien(nhanVienDTO);
        //            formEdit.ShowDialog();
        //            LoadDanhSachNhanVien();
        //        });
        //        menu.Items.Add("Xóa", null, (s, ev) =>
        //        {
        //            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên có ID: {staffID}?",
        //                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                try
        //                {
        //                    // Gọi hàm xóa từ NhanVienBUS
        //                    //nhanVienBus.DeleteNhanVien(staffID);
        //                    // Tải lại danh sách sau khi xóa
        //                    int rowDeleted = nhanVienBus.DeleteNhanVienChiTiet(nhanVienDTO);
        //                    if (rowDeleted > 0)
        //                    {
        //                        int rows = nhanVienBus.DeleteNhanVien(nhanVienDTO);
        //                        if (rows > 0)
        //                        {
        //                            LoadDanhSachNhanVien();
        //                            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
        //                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        }
        //                    }
        //                    //LoadDanhSachNhanVien();
        //                    //MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
        //                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi",
        //                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        });

                // Hiển thị menu tại vị trí chuột
                //var cellRectangle = nhanVienList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                //menu.Show(nhanVienList, cellRectangle.Left, cellRectangle.Bottom);
           // }
       // }
    }
}
