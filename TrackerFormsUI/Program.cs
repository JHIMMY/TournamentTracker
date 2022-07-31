namespace TrackerFormsUI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // Initialize the database connections
        TrackerLibrary.GlobalConfig.InitializeConnections(true, true);

        //Application.Run(new TournamentDashboardForm()); // This will be the default later
        Application.Run(new CreatePrizeForm()); // just for test
    }
}