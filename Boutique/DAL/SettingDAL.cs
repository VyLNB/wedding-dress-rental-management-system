using Boutique.DTO;
using System.IO;
using System.Text.Json;

namespace Boutique.DAL
{
    public class SettingDAL
    {
        private const string SettingsFilePath = "settings.json";
        //private const string SettingsFilePath = @"E:\CongNghePhanMem\baocao\settings.json";

        public SettingDTO LoadSettings()
        {
            if (File.Exists(SettingsFilePath))
            {
                string json = File.ReadAllText(SettingsFilePath);
                return JsonSerializer.Deserialize<SettingDTO>(json);
            }
            return new SettingDTO("English", "Light", "Arial");
        }

        public void SaveSettings(SettingDTO setting)
        {
            string json = JsonSerializer.Serialize(setting);
            File.WriteAllText(SettingsFilePath, json);
        }
    }
}
