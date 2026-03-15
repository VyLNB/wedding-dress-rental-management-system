using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Boutique.DTO;
using System.Net.Mail;
using Boutique.DAL;
using Boutique.BUS;

namespace Boutique.GUI.User
{
    public partial class KhachHangToolstrip_item : UserControl
    {
        private KhachHangBUS khachHang;
        private KhachHangDTO khachHangDTO;
        private bool isAdding = false;
        private int insertBtnClickCount = 0; //kiểm tra số lần click insert btn

        public KhachHangToolstrip_item()
        {
            InitializeComponent();
            khachHang = new KhachHangBUS();
        }

        private void Load_DanhSachKhachHang()
        {
            try
            {
                DataTable dt = khachHang.GetDanhSachKhachHang();
                khachHangList.DataSource = dt;
                khachHangList.Columns["maKhachHang"].HeaderText = "Mã khách hàng";
                khachHangList.Columns["tenKhachHang"].HeaderText = "Tên khách hàng";
                khachHangList.Columns["emailKhachHang"].HeaderText = "Email";
                khachHangList.Columns["soDienThoai"].HeaderText = "Số điện thoại";
                khachHangList.Columns["diaChi"].HeaderText = "Địa chỉ";

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KhachHangToolstrip_item_Load(object sender, EventArgs e)
        {
            maKH_txt.Enabled = false;
            tenKhachHang_txt.Enabled = false;
            emailKH_txt.Enabled = false;
            soDienThoaiKH_txt.Enabled = false;
            diaChiKH_txt.Enabled = false;

            Load_DanhSachKhachHang();
        }

        //kiểm tra email
        private bool checkEmail(string email)
        {
            try
            {
                var emailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void insertKH_btn_Click(object sender, EventArgs e)
        {
            insertBtnClickCount++;
            string maSanPham = khachHang.GenerateNewID("KH");

            if (insertBtnClickCount == 1)
            {
                maKH_txt.Enabled = true;
                tenKhachHang_txt.Enabled = true;
                emailKH_txt.Enabled = true;
                soDienThoaiKH_txt.Enabled = true;
                diaChiKH_txt.Enabled = true;

                //string maSanPham = khachHang.GenerateNewID("KH", "khachHang");
                maKH_txt.Text = maSanPham;
            }
            else
            {

                //string maSanPham = khachHang.GenerateNewID("KH", "khachHang");
                //maKH_txt.Text = maSanPham;

                string tenKhachHang = tenKhachHang_txt.Text.Trim();
                string email = emailKH_txt.Text.Trim();
                string soDienThoai = soDienThoaiKH_txt.Text.Trim();
                string diaChi = diaChiKH_txt.Text.Trim();

                //khachHangDTO = new KhachHangDTO(maSanPham, tenKhachHang, email, soDienThoai, diaChi);

                if (maSanPham == "" || tenKhachHang == "" || email == "" || soDienThoai == "" || diaChi == "")
                {
                    MessageBox.Show("Please enter full information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!checkEmail(email))
                {
                    MessageBox.Show("Invalid email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    khachHangDTO = new KhachHangDTO(maSanPham, tenKhachHang, email, soDienThoai, diaChi);
                    bool insertSuccess = khachHang.InsertKhachHang(khachHangDTO);
                    if (insertSuccess)
                    {
                        MessageBox.Show("Insert successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maKH_txt.Text = khachHang.GenerateNewID("KH");
                        tenKhachHang_txt.Text = "";
                        soDienThoaiKH_txt.Text = "";
                        emailKH_txt.Text = "";
                        diaChiKH_txt.Text = "";

                        Load_DanhSachKhachHang();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Insert failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deleteAll_btn_Click(object sender, EventArgs e)
        {
            tenKhachHang_txt.Text = "";
            soDienThoaiKH_txt.Text = "";
            emailKH_txt.Text = "";
            diaChiKH_txt.Text = "";
            maKH_txt.Text = "";
        }

        private void deleteKH_btn_Click(object sender, EventArgs e)
        {
            if (khachHangList.SelectedRows.Count > 0)
            {
                string maKhachHang = khachHangList.SelectedRows[0].Cells["maKhachHang"].Value.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the customer {maKhachHang}?",
                                                      "Confirm?",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataRow kh = khachHang.GetKhachHangByID(maKhachHang);
                        if (kh != null)
                        {
                            string tenKhachHang = kh["tenKhachHang"].ToString();
                            string email = kh["emailKhachHang"].ToString();
                            string soDienThoai = kh["soDienThoai"].ToString();
                            string diaChi = kh["diaChi"].ToString();
                            khachHangDTO = new KhachHangDTO(maKhachHang, tenKhachHang, email, soDienThoai, diaChi);

                            khachHang.InsertKhachHangXoa(khachHangDTO);

                            int rowDeleted = khachHang.DeleteKhachHang(khachHangDTO);
                            if (rowDeleted > 0)
                            {
                                MessageBox.Show("Customer deleted successfully",
                                        "Notification",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                Load_DanhSachKhachHang();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void khachHangList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (!isAdding))
            {
                DataGridViewRow row = khachHangList.Rows[e.RowIndex];
                maKH_txt.Text = row.Cells["maKhachHang"].Value.ToString();
                tenKhachHang_txt.Text = row.Cells["tenKhachHang"].Value.ToString();
                emailKH_txt.Text = row.Cells["emailKhachHang"].Value.ToString();
                soDienThoaiKH_txt.Text = row.Cells["soDienThoai"].Value.ToString();
                diaChiKH_txt.Text = row.Cells["diaChi"].Value.ToString();
            }
        }

        private void updateKH_btn_Click(object sender, EventArgs e)
        {
            string maKhachHang_new = maKH_txt.Text.Trim();
            string tenKhachHang_new = tenKhachHang_txt.Text.Trim();
            string email_new = emailKH_txt.Text.Trim();
            string soDienThoai_new = soDienThoaiKH_txt.Text.Trim();
            string diaChi_new = diaChiKH_txt.Text.Trim();

            khachHangDTO = new KhachHangDTO(maKhachHang_new, tenKhachHang_new, email_new, soDienThoai_new, diaChi_new);
            if (khachHang.UpdateKhachHang(khachHangDTO))
            {
                MessageBox.Show("Customer updated successfully",
                                      "Notification",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                Load_DanhSachKhachHang();
            } 
            else
            {
                MessageBox.Show("No customer found to update!", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
