namespace CalendarApp
{
    public class Event
    {
        public string EventName { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Event(string eventName, DateTime? startDate, DateTime? endDate)
        {
            EventName = eventName;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
