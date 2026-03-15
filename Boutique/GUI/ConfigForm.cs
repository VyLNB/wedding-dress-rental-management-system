using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique.GUI
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConFigForm_Load(object sender, EventArgs e)
        {
            if (winAuthen_check.Checked == true)
            {
                uid_txt.ReadOnly = true;
                password_config_txt.ReadOnly = true;
            }
            else
            {
                uid_txt.ReadOnly = false;
                password_config_txt.ReadOnly = false;
            }
        }

        private void winAuthen_check_CheckedChanged(object sender, EventArgs e)
        {
            if (winAuthen_check.Checked == true)
            {
                uid_txt.ReadOnly = true;
                password_config_txt.ReadOnly = true;
            }
            else
            {
                uid_txt.ReadOnly = false;
                password_config_txt.ReadOnly = false;
            }
        }

        private void save_config_btn_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("config.txt");
            if (winAuthen_check.Checked == true)
            {
                streamWriter.WriteLine("windows");
                streamWriter.WriteLine(server_txt.Text);
                streamWriter.WriteLine(database_txt.Text);
            }
            else
            {
                streamWriter.WriteLine("sql");
                streamWriter.WriteLine(server_txt.Text);
                streamWriter.WriteLine(database_txt.Text);
                streamWriter.WriteLine(uid_txt.Text);
                streamWriter.WriteLine(password_config_txt.Text);
            }
            streamWriter.Close();
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
