using Boutique.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; //kiểm tra email

namespace Boutique.GUI
{
    public partial class SignUp : Form
    {
        Connection cn = new Connection();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void signup_loginbtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private bool checkEmail(string email)
        {
            try
            {
                var emailAddress = new MailAddress(email);
                return true;
            } catch
            {
                return false;
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string userName = signup_username.Text;
            string password = signup_password.Text;
            string rePassword = rePassTxt.Text;
            string email = email_txt.Text.Trim();//loại bỏ khoảng trống dư thừa
            string role = "";

            //lấy giá trị role
            if (admin_check.Checked == true)
            {
                role = "admin";
            }

            if (staff_check.Checked == true)
            {
                role = "staff";
            }
            //kiểm tra giá trị nhập vào 
            if (userName == "" || password == "" || rePassword == "" || role == "" || email == "")
            {
                MessageBox.Show("Please enter full information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (password != rePassword)
            {
                MessageBox.Show("Password must match re-entered password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!checkEmail(email)){
                MessageBox.Show("Invalid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else //insert vào database
            {
                //bool insertSuccess = cn.insertUser(userName, password, role, email);
                bool insertSuccess = Connection.insertUser(userName, password, role, email);
                if (insertSuccess)
                {
                    MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sign up failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //kiểm tra giá trị role
        private void admin_check_CheckedChanged(object sender, EventArgs e)
        {
            staff_check.Enabled = !admin_check.Checked;
        }

        private void staff_check_CheckedChanged(object sender, EventArgs e)
        {
            admin_check.Enabled = !staff_check.Checked;
        }
    }
}
