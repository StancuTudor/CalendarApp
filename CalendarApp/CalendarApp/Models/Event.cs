namespace CalendarApp.Models
{
    public class Event
    {
        public bool Show { get; set; }
        public string EventName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Color Color { get; set; }

        public Event(string eventName, DateTime? startDate, DateTime? endDate)
        {
            Show = true;
            EventName = eventName;
            StartDate = startDate;
            EndDate = endDate;
            Color = Color.White;
        }
        public Event(string eventName, DateTime? startDate, DateTime? endDate, Color color)
        {
            Show = true;
            EventName = eventName;
            StartDate = startDate;
            EndDate = endDate;
            Color = color;
        }
    }
}
