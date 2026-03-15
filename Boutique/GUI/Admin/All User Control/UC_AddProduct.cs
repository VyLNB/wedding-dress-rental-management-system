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
//    public partial class UC_AddProduct : Form
//    {
//        public UC_AddProduct()
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
using Microsoft.VisualBasic;
using Boutique.BUS;  // Thêm using cho lớp BUS
using Boutique.DTO;  // Thêm using cho lớp DTO

namespace Boutique.GUI.Admin.All_User_Control
{
    public partial class UC_AddProduct : UserControl
    {

        private SettingBUS settingBUS;
        SanPhamBUS sanPhamBUS = new SanPhamBUS(); // Khởi tạo đối tượng BUS
        //function fn = new function(); // Không cần dùng nữa
        //String query; // Không cần dùng nữa

        public UC_AddProduct()
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


        private void UC_AddProduct_Load(object sender, EventArgs e)
        {
            loadProductData();
        }

        private void loadProductData()
        {
            //query = "select * from sanPham";
            //DataSet ds = fn.getData(query);
            //DataGridViewTSP.DataSource = ds.Tables[0];
            DataGridViewTSP.DataSource = sanPhamBUS.getDataToGridView();
        }

        public string getMaxProductID()
        {
            //query = "SELECT MAX(maSanPham) FROM sanPham";
            //DataSet ds = fn.getData(query);

            //if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            //{
            //    string maxProductID = ds.Tables[0].Rows[0][0].ToString();

            //    if (maxProductID.StartsWith("SP") && int.TryParse(maxProductID.Substring(2), out int lastNumber))
            //    {
            //        int nextNumber = lastNumber + 1;
            //        return $"SP{nextNumber:000}";
            //    }
            //    else
            //    {
            //        MessageBox.Show("Định dạng maSanPham không hợp lệ trong database.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return "SP001";
            //    }
            //}
            //else
            //{
            //    return "SP001";
            //}
            return sanPhamBUS.GenerateNewProductID();
        }

        private void btnThemsp_Click(object sender, EventArgs e)
        {
            if (txtLoaisp.Text != "" && txtTensp.Text != "" && txtSoluong.Text != "" && txtTrangthai.Text != "" && txtGiasp.Text != "")
            {
                string maSP = getMaxProductID();
                string tenloaisp = txtLoaisp.Text;
                //DataSet dsMaLoai = fn.getData("select maLoaiSP FROM loaiSanPham WHERE tenLoaiSP = N'" + tenloaisp + "'");
                DataTable dsMaLoai = sanPhamBUS.GetDanhSachSanPham(); // Giả sử BUS có hàm này để lấy danh sách loại SP

                if (dsMaLoai != null && dsMaLoai.Rows.Count > 0)
                {
                    //string maLoai = dsMaLoai.Tables[0].Rows[0]["maLoaiSP"].ToString();
                    string maLoai = "";
                    foreach (DataRow row in dsMaLoai.Rows)
                    {
                        if (row["tenLoaiSP"].ToString() == tenloaisp)
                        {
                            maLoai = row["maLoaiSP"].ToString();
                            break;
                        }
                    }

                    String tensp = txtTensp.Text;
                    //String soluong = txtSoluong.Text;
                    int soluong = int.Parse(txtSoluong.Text);
                    String trangthai = txtTrangthai.Text;
                    //Int64 gia = Int64.Parse(txtGiasp.Text);
                    decimal gia = decimal.Parse(txtGiasp.Text);

                    //query = "insert into sanPham (maSanPham, tenSanPham, giaThue, trangThai, soLuong, maLoaiSP) " +
                    //        "values ('" + maSP + "', N'" + tensp.Replace("'", "''") + "', " +
                    //        gia + ", N'" + trangthai.Replace("'", "''") + "', " +
                    //        soluong + ", '" + maLoai + "')";
                    //fn.setData(query, "Đã thêm sản phẩm có mã: " + maSP);
                    bool result = sanPhamBUS.InsertSanPham(maSP, maLoai, tensp, gia, soluong, trangthai);
                    if (result)
                    {
                        MessageBox.Show("Đã thêm sản phẩm có mã: " + maSP);
                        loadProductData();
                        clearAll();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại.");
                    }


                    //loadProductData();
                    //clearAll();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm với tên: " + tenloaisp);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        public void clearAll()
        {
            txtSoluong.Clear();
            txtLoaisp.SelectedIndex = -1;
            txtTrangthai.SelectedIndex = -1;
            txtGiasp.Clear();
            txtTensp.Clear();
        }

        private void UC_AddProduct_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddProduct_Enter(object sender, EventArgs e)
        {
            UC_AddProduct_Load(this, null);
        }

        //private void btnXoasp_Click(object sender, EventArgs e)
        //{
        //    if (DataGridViewTSP.SelectedRows.Count > 0)
        //    {
        //        int selectedIndex = DataGridViewTSP.SelectedRows[0].Index;
        //        string maSanPhamToDelete = DataGridViewTSP.Rows[selectedIndex].Cells[0].Value.ToString();

        //        if (!int.TryParse(DataGridViewTSP.Rows[selectedIndex].Cells[4].Value.ToString(), out int soLuongHienCo))
        //        {
        //            MessageBox.Show("Số lượng hiện có không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        string soLuongXoaString = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng cần xóa:", "Xóa sản phẩm", "1");

        //        if (int.TryParse(soLuongXoaString, out int soLuongXoa) && soLuongXoa > 0 && soLuongXoa <= soLuongHienCo)
        //        {
        //            int soLuongConLai = soLuongHienCo - soLuongXoa;
        //            //query = "update sanPham set soLuong = " + soLuongConLai + " where maSanPham = '" + maSanPhamToDelete + "'";
        //            //fn.setData(query, "Đã xóa " + soLuongXoa + " sản phẩm có mã: " + maSanPhamToDelete);
        //            SanPhamDTO sp = new SanPhamDTO(maSanPhamToDelete, "", 0, "", "", soLuongConLai); // Tạo DTO để update số lượng
        //            sanPhamBUS.UpdateSanPham(sp);
        //            MessageBox.Show("Đã xóa " + soLuongXoa + " sản phẩm có mã: " + maSanPhamToDelete);


        //            if (soLuongConLai == 0)
        //            {
        //                if (MessageBox.Show("Số lượng sản phẩm này đã về 0. Bạn có muốn xóa hẳn sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //                {
        //                    //query = "delete from sanPham where maSanPham = '" + maSanPhamToDelete + "'";
        //                    //fn.setData(query, "Đã xóa sản phẩm có mã: " + maSanPhamToDelete);
        //                    sanPhamBUS.DeleteSanPham(maSanPhamToDelete);
        //                    MessageBox.Show("Đã xóa sản phẩm có mã: " + maSanPhamToDelete);
        //                }
        //            }

        //            loadProductData();
        //        }
        //        else if (!string.IsNullOrEmpty(soLuongXoaString))
        //        {
        //            MessageBox.Show("Số lượng xóa không hợp lệ. Vui lòng nhập số lớn hơn 0 và không lớn hơn số lượng hiện có.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một sản phẩm để xóa số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void btnXoasp_Click(object sender, EventArgs e)
        //{
        //    if (DataGridViewTSP.SelectedRows.Count > 0)
        //    {
        //        string maSanPhamToDelete = DataGridViewTSP.SelectedRows[0].Cells[0].Value.ToString();

        //        // Show a confirmation dialog
        //        DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            // Call the BUS to delete the product
        //            int result = sanPhamBUS.DeleteSanPham(maSanPhamToDelete);

        //            if (result > 0)
        //            {
        //                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                loadProductData(); // Refresh the DataGridView
        //            }
        //            else
        //            {
        //                MessageBox.Show("Xóa sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void btnXoasp_Click(object sender, EventArgs e)
        {
            if (DataGridViewTSP.SelectedRows.Count > 0)
            {
                string maSanPhamToDelete = DataGridViewTSP.SelectedRows[0].Cells[0].Value.ToString();

                if (sanPhamBUS.IsSanPhamInChiTietDonThue(maSanPhamToDelete))
                {
                    MessageBox.Show("Không thể xóa sản phẩm này vì nó đang có trong chi tiết đơn thuê.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Ngăn chặn việc xóa
                }

                // Show a confirmation dialog
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    int result = sanPhamBUS.DeleteSanPham(maSanPhamToDelete);

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadProductData(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLoaisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}