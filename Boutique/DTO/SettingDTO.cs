namespace Boutique.DTO
{
    public class SettingDTO
    {
        public string Language { get; set; }
        public string ThemeMode { get; set; } // "Light", "Dark", "Medium"
        public string FontStyle { get; set; }

        public SettingDTO(string language, string themeMode, string fontStyle)
        {
            Language = language;
            ThemeMode = themeMode;
            FontStyle = fontStyle;
        }
    }

}
