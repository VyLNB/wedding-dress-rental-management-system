using Boutique.DTO;

namespace Boutique.BUS
{
    public class SettingBUS
    {
        private static SettingDTO currentSetting;

        public SettingBUS()
        {
            if (currentSetting == null)
            {
                // Mặc định là chế độ sáng
                currentSetting = new SettingDTO("English", "Light", "Arial");
            }
        }

        public SettingDTO GetSettings()
        {
            return currentSetting;
        }

        public void SaveSettings(SettingDTO setting)
        {
            currentSetting = setting;
        }
    }

}
