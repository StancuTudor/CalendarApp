using CalendarApp.Models;

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
                new("Event 1", new DateTime(2024, 6, 4), new DateTime(2024, 6, 8), Color.LightBlue),
                new("Event 2", new DateTime(2024, 6, 7), new DateTime(2024, 6, 15), Color.Red),
                new("Event 3", null, new DateTime(2024, 6, 20), Color.Orange),
                new("Event 4", null, new DateTime(2024, 6, 20), Color.MediumSeaGreen),
                new("Event 5", null, new DateTime(2024, 6, 20), Color.MediumSpringGreen),
                new("Event 6", null, new DateTime(2024, 6, 20), Color.MediumVioletRed),
            };
            Application.Run(new FormCalendar(events));
        }
    }
}