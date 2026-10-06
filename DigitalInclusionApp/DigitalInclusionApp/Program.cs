namespace DigitalInclusionApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Ativa Per-Monitor V2 antes de criar forms
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}