namespace CalendarApp
{
    public partial class FormCalendar : Form
    {
        private List<Event> events;
        private List<ListView> listViewDays = [];
        private DateTime currentMonth { get => dtpMonth.Value; set => dtpMonth.Value = value; }

        private DateTime firstOfMonth { get => currentMonth; }
        private DateTime lastOfMonth { get => currentMonth.AddMonths(1).AddDays(-1); }
        private int initialPanelHeight;
        private int initialFormHeight;
        private int rowHeight;
        public FormCalendar(List<Event> events)
        {
            InitializeComponent();
            InitializeListViewDays();

            this.events = events;
            initialPanelHeight = pnlDays.Height;
            initialFormHeight = this.Height;
            rowHeight = listView8.Location.Y - listView1.Location.Y;
        }

        private void InitializeListViewDays()
        {
            foreach (var control in pnlDays.Controls)
            {
                if (control is ListView)
                {
                    listViewDays.Add((ListView)control);
                }
            }
        }

        private void EmptyCalendar()
        {
            for (int i = 0; i < listViewDays.Count; i++)
            {
                listViewDays[i].Columns.Clear();
                listViewDays[i].Items.Clear();
                listViewDays[i].Hide();
            }
        }
        private void FillCalendarForMonth()
        {
            EmptyCalendar();

            int daysInMonth = lastOfMonth.Day;
            int firstDayToFill = (int)(firstOfMonth.DayOfWeek + 6) % 7;
            int lastDayToFill = firstDayToFill + daysInMonth;

            // Resize the calendar if too small
            ResizeCalendar(lastDayToFill);

            // Get events for this month
            var eventsForThisMonth = events.Where(IsEventInMonth).ToList();

            // Fill days
            for (int i = firstDayToFill; i < lastDayToFill; i++)
            {
                int day = i - firstDayToFill + 1;
                listViewDays[i].Columns.Add(day.ToString(), listViewDays[i].Width - 24);
                InsertEvents(listViewDays[i], day, eventsForThisMonth);
                listViewDays[i].Show();
            }
        }

        private bool IsEventInMonth(Event ev)
        {
            DateTime startDate = ev.StartDate == null ? DateTime.MinValue : ev.StartDate.Value;
            DateTime endDate = ev.EndDate == null ? DateTime.MinValue : ev.EndDate.Value;
            return startDate <= lastOfMonth && endDate >= firstOfMonth;
        }

        private void ResizeCalendar(int lastDayToFill)
        {
            int formHeight = initialFormHeight;
            int panelHeight = initialPanelHeight;

            if (lastDayToFill <= 35)
            {
                formHeight -= rowHeight;
                panelHeight -= rowHeight;
            }
            if (lastDayToFill <= 28)
            {
                formHeight -= rowHeight;
                panelHeight -= rowHeight;
            }
            this.Height = formHeight;
            pnlDays.Height = panelHeight;
        }

        private void InsertEvents(ListView listView, int day, List<Event> eventsList)
        {
            var thisDate = new DateTime(currentMonth.Year, currentMonth.Month, day);
            foreach (var ev in eventsList)
            {
                if (IsDateInEvent(thisDate, ev))
                {
                    ListViewItem item = new ListViewItem()
                    {
                        Text = ev.EventName,
                        BackColor = ev.Color
                    };
                    listView.Items.Add(item);
                }
                else
                {
                    listView.Items.Add(string.Empty);
                }
            }
        }

        private bool IsDateInEvent(DateTime date, Event ev)
        {
            DateTime startDate = ev.StartDate == null ? DateTime.MinValue : ev.StartDate.Value;
            DateTime endDate = ev.EndDate == null ? DateTime.MinValue : ev.EndDate.Value;

            return startDate <= date && date <= endDate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(1);
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            FillCalendarForMonth();
        }

        private void listView_Scrolled(object sender, ScrollEventArgs e)
        {
            var senderTopItemIndex = ((ScrollingListView)sender).TopItem?.Index;
            if (senderTopItemIndex == null)
                return;

            foreach (var control in pnlDays.Controls)
            {
                if (control is ScrollingListView)
                {
                    var currentControl = (ScrollingListView)control;
                    if (currentControl.Items.Count - 1 < senderTopItemIndex)
                        continue;
                    var topItem = currentControl.Items[senderTopItemIndex.Value];
                    ((ScrollingListView)control).TopItem = topItem;
                }
            }
        }
    }
}
