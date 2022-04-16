using NLog;

namespace BulkRenameFiles
{
    internal static class Program
    {
        private static readonly Logger oLogger = LogManager.GetCurrentClassLogger();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            oLogger.Info("Application init..");
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            oLogger.Info("Mainform closed");
        }
    }
}