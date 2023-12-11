namespace TechnicianEvaluation
{
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

            Technician rainbow = new Technician(608, "Rainbow", "Martin", 4, 76.5);

            Application.Run(new Form1());
        }
    }
}