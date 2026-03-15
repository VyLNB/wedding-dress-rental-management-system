namespace Boutique
{
    internal static class Program
    {
        public static String server = "",
                             database = "",
                             uid = "",
                             password = "",
                             authen = "";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}