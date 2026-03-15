using System;
using System.Windows.Forms;
using Boutique.DAL; // Assuming Connection class is in DAL namespace
using Microsoft.Data.SqlClient;

namespace Boutique.GUI
{
    public partial class GetNewPasswordForm : Form
    {
        private string username;

        public GetNewPasswordForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới và xác nhận lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận lại không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UpdatePassword(username, newPassword))
            {
                MessageBox.Show("Mật khẩu đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật mật khẩu. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdatePassword(string username, string newPassword)
        {
            using (SqlConnection connection = Connection.connect())
            {
                connection.Open();
                if (connection == null)
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string queryAdmin = "UPDATE admin SET adminPassword = @newPassword WHERE adminName = @username";
                string queryStaff = "UPDATE staff SET staffPassword = @newPassword WHERE staffName = @username";
                int rowsAffected = 0;

                using (SqlCommand cmdAdmin = new SqlCommand(queryAdmin, connection))
                {
                    cmdAdmin.Parameters.AddWithValue("@username", username);
                    cmdAdmin.Parameters.AddWithValue("@newPassword", newPassword);
                    rowsAffected = cmdAdmin.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }

                }
                using (SqlCommand cmdStaff = new SqlCommand(queryStaff, connection))
                {
                    cmdStaff.Parameters.AddWithValue("@username", username);
                    cmdStaff.Parameters.AddWithValue("@newPassword", newPassword);
                    rowsAffected = cmdStaff.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}