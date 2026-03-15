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
using Boutique.DTO;
using Boutique.BUS;

namespace Boutique.GUI
{
    public partial class SanPhamStaff : UserControl
    {

        private SanPhamBUS sanPham;
        private SanPhamDTO sanPhamDTO;
        private bool isAdding = false;
        public SanPhamStaff()
        {
            InitializeComponent();
            sanPham = new SanPhamBUS();

        }

        //thêm sản phẩm
        private void insert_btn_Click(object sender, EventArgs e)
        {
            //isAdding = true;

            maSp_txt.Enabled = true;
            loaiSp_box.Enabled = true;
            tenSp_txt.Enabled = true;
            giaTienSp_txt.Enabled = true;
            soLuongSp_txt.Enabled = true;
            trangThaiSP_box.Enabled = true;
            delete_btn.Enabled = true;
            update_btn.Enabled = true;

            string maSp_new = sanPham.GenerateNewProductID();
            maSp_txt.Text = maSp_new;

            if (loaiSp_box.SelectedItem != null && trangThaiSP_box.SelectedItem != null)
            {
                String loaiSanPham = loaiSp_box.SelectedValue.ToString();
                String tenSanPham = tenSp_txt.Text;
                Decimal giaTien = Convert.ToDecimal(giaTienSp_txt.Text); //cần kiểm tra dữ liệu nhập vào về giá tiền
                int soLuong = int.Parse(soLuongSp_txt.Text);
                String trangThai = trangThaiSP_box.SelectedItem.ToString();


                if (maSp_new == "" || loaiSanPham == "" || tenSanPham == "" || giaTien == 0 || soLuong == 0 || trangThai == "")
                {
                    MessageBox.Show("Please enter full information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool insertSuccess = sanPham.InsertSanPham(maSp_new, loaiSanPham, tenSanPham, giaTien, soLuong, trangThai);
                    if (insertSuccess)
                    {
                        MessageBox.Show("Insert successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maSp_txt.Text = "";
                        giaTienSp_txt.Text = "";
                        soLuongSp_txt.Text = "";
                        tenSp_txt.Text = "";

                        // Đặt lại loại sản phẩm về trạng thái không chọn
                        loaiSp_box.SelectedIndex = -1;

                        trangThaiSP_box.SelectedIndex = -1;
                        load_DanhSachSanPham();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Insert failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void SanPhamStaff_Load(object sender, EventArgs e)
        {
            maSp_txt.Enabled = false;
            loaiSp_box.Enabled = false;
            tenSp_txt.Enabled = false;
            giaTienSp_txt.Enabled = false;
            soLuongSp_txt.Enabled = false;
            trangThaiSP_box.Enabled = false;
            delete_btn.Enabled = false;
            update_btn.Enabled = false;

            load_DanhMucSanPham();
            load_DanhSachSanPham();
        }


        private void deleteAll_btn_Click(object sender, EventArgs e)
        {
            maSp_txt.Text = "";
            giaTienSp_txt.Text = "";
            soLuongSp_txt.Text = "";
            tenSp_txt.Text = "";

            // Đặt lại ComboBox (Loại sản phẩm) về trạng thái không chọn
            loaiSp_box.SelectedIndex = -1;

            trangThaiSP_box.SelectedIndex = -1;
        }

        //lấy danh mục sản phẩm hiển thị ở combo box
        private void load_DanhMucSanPham()
        {
            try
            {
                DataTable dataTable = sanPham.GetDanhSachSanPham();
                loaiSp_box.DataSource = dataTable;
                loaiSp_box.DisplayMember = "tenLoaiSP";
                loaiSp_box.ValueMember = "maLoaiSP";
                loaiSp_box.SelectedIndex = -1;

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có loại sản phẩm nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //lấy danh sách sản phẩm
        private void load_DanhSachSanPham()
        {
            try
            {
                DataTable dt = sanPham.getDataToGridView();
                sanPhamTable.DataSource = dt;
                sanPhamTable.Columns["maSanPham"].HeaderText = "Mã sản phẩm";
                sanPhamTable.Columns["tenSanPham"].HeaderText = "Tên sản phẩm";
                sanPhamTable.Columns["giaThue"].HeaderText = "Giá thuê";
                sanPhamTable.Columns["trangThai"].HeaderText = "Trạng thái";
                sanPhamTable.Columns["soLuong"].HeaderText = "Số lượng";

                sanPhamTable.Columns["maLoaiSP"].Visible = false;
                sanPhamTable.Columns["ngayThem"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (sanPhamTable.SelectedRows.Count > 0)
            {
                string maSanPham = sanPhamTable.SelectedRows[0].Cells["maSanPham"].Value.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the product {maSanPham}?",
                                                      "Confirm?",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataRow sp = sanPham.GetSanPhamByID(maSanPham);
                        if (sp != null)
                        {
                            string tenSanPham = sp["tenSanPham"].ToString();
                            decimal giaThue = Convert.ToDecimal(sp["giaThue"]);
                            string maLoaiSP;
                            if (sp.Table.Columns.Contains("MaLoaiSP"))
                            {
                                maLoaiSP = sp["maLoaiSP"].ToString();
                            }
                            else
                            {
                                maLoaiSP = string.Empty;
                            }

                            sanPham.InsertSanPhamXoa(maSanPham, tenSanPham, giaThue, maLoaiSP);

                            int rowDelete = sanPham.DeleteSanPham(maSanPham);
                            if (rowDelete > 0)
                            {
                                MessageBox.Show("Product deleted successfully",
                                        "Notification",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                load_DanhSachSanPham();
                            }
                            else
                            {
                                MessageBox.Show("No product found to delete!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please select a product to delete!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void sanPhamTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (!isAdding))
            {
                DataGridViewRow row = sanPhamTable.Rows[e.RowIndex];
                maSp_txt.Text = row.Cells["maSanPham"].Value.ToString();
                tenSp_txt.Text = row.Cells["tenSanPham"].Value.ToString();
                giaTienSp_txt.Text = row.Cells["giaThue"].Value.ToString();
                soLuongSp_txt.Text = row.Cells["soLuong"].Value.ToString();
                trangThaiSP_box.Text = row.Cells["trangThai"].Value.ToString();

                string maLoaiSP = row.Cells["maLoaiSP"].Value?.ToString();
                if (!string.IsNullOrEmpty(maLoaiSP))
                {
                    loaiSp_box.SelectedValue = maLoaiSP;
                }
                else
                {
                    loaiSp_box.SelectedIndex = -1;
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string maSanPham_new = maSp_txt.Text.Trim();
            string tenSanPham_new = tenSp_txt.Text.Trim();
            decimal giaTien_new = Convert.ToDecimal(giaTienSp_txt.Text.Trim());
            int soLuong_new = int.Parse(soLuongSp_txt.Text.Trim());
            string trangThai_new = trangThaiSP_box.SelectedItem.ToString();
            string maLoaiSP_new;

            if (loaiSp_box.SelectedValue != null)
            {
                maLoaiSP_new = loaiSp_box.SelectedValue.ToString();
            }
            else
            {
                maLoaiSP_new = "";
            }
            sanPhamDTO = new SanPhamDTO(maSanPham_new, tenSanPham_new, giaTien_new, trangThai_new, maLoaiSP_new, soLuong_new);
            if (sanPham.UpdateSanPham(sanPhamDTO))
            {
                MessageBox.Show("Product updated successfully",
                                       "Notification",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                load_DanhSachSanPham();
            }
            else
            {
                MessageBox.Show("No product found to update!", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
