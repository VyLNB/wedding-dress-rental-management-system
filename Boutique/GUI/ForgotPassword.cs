using System;
using System.Data;
using System.Windows.Forms;
using Boutique.DAL; // Assuming Connection class is in DAL namespace
using Microsoft.Data.SqlClient;

namespace Boutique.GUI
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckUsernameAndEmail(username, email))
            {
                // Nếu thông tin khớp, mở form GetNewPasswordForm và truyền username
                GetNewPasswordForm getNewPasswordForm = new GetNewPasswordForm(username);
                this.Hide();  // Ẩn form ForgotPassword
                getNewPasswordForm.ShowDialog();
                this.Close(); // Đóng form ForgotPassword sau khi GetNewPasswordForm đóng
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc email không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private bool CheckUsernameAndEmail(string username, string email)
        //{

        //    using (SqlConnection connection = Connection.connect())
        //    {
        //        connection.Open();
        //        if (connection == null)
        //        {
        //            MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }

        //        string queryAdmin = "SELECT COUNT(*) FROM admin WHERE adminName = @username AND adminEmail = @email";
        //        string queryStaff = "SELECT COUNT(*) FROM staff WHERE staffName = @username AND staffEmail = @email";

        //        using (SqlCommand cmdAdmin = new SqlCommand(queryAdmin, connection))
        //        {
        //            cmdAdmin.Parameters.AddWithValue("@username", username);
        //            cmdAdmin.Parameters.AddWithValue("@email", email);
        //            int count = (int)cmdAdmin.ExecuteScalar();
        //            if (count > 0)
        //            {
        //                return true;
        //            }
        //        }

        //        using (SqlCommand cmdStaff = new SqlCommand(queryStaff, connection))
        //        {
        //            cmdStaff.Parameters.AddWithValue("@username", username);
        //            cmdStaff.Parameters.AddWithValue("@email", email);
        //            int count = (int)cmdStaff.ExecuteScalar();
        //            if (count > 0)
        //            {
        //                return true;
        //            }
        //        }

        //        return false;
        //    }
        //}

        private bool CheckUsernameAndEmail(string username, string email)
        {
            using (SqlConnection connection = Connection.connect())
            {
                if (connection == null)
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                try
                {
                    connection.Open(); // Mở kết nối tại đây, sau khi kiểm tra null

                    string queryAdmin = "SELECT COUNT(*) FROM admin WHERE adminName = @username AND adminEmail = @email";
                    string queryStaff = "SELECT COUNT(*) FROM staff WHERE staffName = @username AND staffEmail = @email";

                    using (SqlCommand cmdAdmin = new SqlCommand(queryAdmin, connection))
                    {
                        cmdAdmin.Parameters.AddWithValue("@username", username);
                        cmdAdmin.Parameters.AddWithValue("@email", email);
                        int count = (int)cmdAdmin.ExecuteScalar();
                        if (count > 0)
                            return true;
                    }

                    using (SqlCommand cmdStaff = new SqlCommand(queryStaff, connection))
                    {
                        cmdStaff.Parameters.AddWithValue("@username", username);
                        cmdStaff.Parameters.AddWithValue("@email", email);
                        int count = (int)cmdStaff.ExecuteScalar();
                        if (count > 0)
                            return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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