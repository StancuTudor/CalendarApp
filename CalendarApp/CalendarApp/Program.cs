namespace CalendarApp
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

            List<Event> events = new List<Event>()
            {
                new("Event 1", new DateTime(2024, 6, 4), new DateTime(2024, 6, 8)),
                new("Event 2", new DateTime(2024, 6, 7), new DateTime(2024, 6, 15))
            };
            Application.Run(new FormCalendar(events));
        }
    }
}