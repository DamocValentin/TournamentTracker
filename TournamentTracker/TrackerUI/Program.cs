using System;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize DataBase Connection
            TrackerLibrary.GlobalConfig.InitializeConnections(true, false);

            //Application.Run(new TournamentDashboardForm());
            Application.Run(new CreatePrizeForm());
        }
    }
}
