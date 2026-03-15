using System;
using System.Windows.Forms;
using Boutique.BUS;
using Boutique.DTO;

namespace Boutique.GUI.Admin.All_User_Control
{
    public partial class UC_Setting : UserControl
    {
        private SettingBUS settingBUS;

        public event EventHandler SettingsChanged;
        public UC_Setting()
        {
            InitializeComponent();
            settingBUS = new SettingBUS();
            LoadSettings();
        }

        private void LoadSettings()
        {
            SettingDTO settings = settingBUS.GetSettings();
            comboBoxLanguage.SelectedItem = settings.Language;
            comboBoxThemeMode.SelectedItem = settings.ThemeMode;
            comboBoxFontStyle.SelectedItem = settings.FontStyle;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                string language = comboBoxLanguage.SelectedItem.ToString();
                string themeMode = comboBoxThemeMode.SelectedItem.ToString();
                string fontStyle = comboBoxFontStyle.SelectedItem.ToString();

                SettingDTO newSettings = new SettingDTO(language, themeMode, fontStyle);
                settingBUS.SaveSettings(newSettings);

                // Gửi sự kiện thông báo cài đặt đã thay đổi
                SettingsChanged?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("Cài đặt đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Xử lý đăng xuất
            MessageBox.Show("Bạn đã đăng xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Application.Restart();
        }

    }
}
