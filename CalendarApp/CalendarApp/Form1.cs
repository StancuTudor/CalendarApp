using Microsoft.VisualBasic;

namespace CalendarApp
{
    public partial class FormCalendar : Form
    {
        private List<Event> events;
        private List<ListView> listViewDays = [];
        private DateTime currentMonth { get => dtpMonth.Value; set => dtpMonth.Value = value; }
        public FormCalendar(List<Event> events)
        {
            InitializeComponent();
            InitializeListViewDays();

            this.events = events;
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

            DateTime firstOfMonth = currentMonth;
            DateTime lastOfMonth = currentMonth.AddMonths(1).AddDays(-1);

            int firstDayToFill = (int)(firstOfMonth.DayOfWeek + 6) % 7;
            int daysInMonth = lastOfMonth.Day;

            for (int i = firstDayToFill; i < firstDayToFill + daysInMonth; i++)
            {
                listViewDays[i].Columns.Add((i - firstDayToFill + 1).ToString(), listViewDays[i].Width - 4);
                listViewDays[i].Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            FillCalendarForMonth();
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(1);
        }
    }
}
