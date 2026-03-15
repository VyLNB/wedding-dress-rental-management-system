using Boutique.GUI;
using Boutique.DAL;
using Boutique.GUI.Admin;
namespace Boutique
{
    public partial class Login : Form
    {
        Connection cn = new Connection();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            SignUp signupForm = new SignUp();
            signupForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string userName = login_username.Text;
            string password = login_password.Text;

            if (userName == "" || password == "")
            {
                MessageBox.Show("Please enter full information!");
                return;
            }
            else
            {
                string userRole = cn.checkLogin(userName, password);
                //string userRole=Connection.checkLogin("username", "password");
                if (userRole != null)
                {
                    if (userRole == "admin")
                    {
                        MessageBox.Show("Log in successfully! You are: " + userRole);
                        Home adminForm = new Home();
                        adminForm.Show();
                        this.Hide();
                    }
                    if (userRole == "staff")
                    {
                        MessageBox.Show("Log in successfully! You are: " + userRole);
                        StaffHome staffForm = new StaffHome();
                        staffForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please register an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists("config.txt"))
            {
                StreamReader streamReader = new StreamReader("config.txt");
                String line = streamReader.ReadLine();

                if (line.Equals("windows"))
                {
                    Program.authen = "windows";
                    Program.server = streamReader.ReadLine();
                    Program.database = streamReader.ReadLine();
                    //MessageBox.Show(Program.server + ", " + Program.database);
                }
                else
                {
                    Program.authen = "sql";
                    Program.server = streamReader.ReadLine();
                    Program.database = streamReader.ReadLine();
                    Program.uid = streamReader.ReadLine();
                    Program.password = streamReader.ReadLine();
                }
                streamReader.Close();
            }
            else
            {
                ConfigForm configForm = new ConfigForm();
                configForm.ShowDialog();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword resertPasswordForm = new ForgotPassword();
            resertPasswordForm.Show();
            this.Hide();
        }
    }
}
