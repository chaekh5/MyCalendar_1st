namespace MyCalendar
{
    public partial class Form1 : Form
    {
        int month, year;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayToday();
        }

        private void displayToday()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            display_calendar(month, year);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month -= 12;
                year++;
            }
            display_calendar(month, year);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {

            month--;
            if (month < 1)
            {
                month += 12;
                year--;
            }

            display_calendar(month, year);
        }

        private void display_calendar(int month, int year)
        {
            daycontainer.Controls.Clear();
            title_month.Text = month.ToString() + " 월";
            title_year.Text = year.ToString() + " 년";

            // Get First day of the Month
            DateTime start_of_month = new DateTime(year, month, 1);
            // Get Today's Date
            int nowDate = DateTime.Now.Day;
            int nowMonth = DateTime.Now.Month;
            int nowYear = DateTime.Now.Year;


            // Get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            // Convert the start_of_month to integer
            int day_of_the_week = Convert.ToInt32(start_of_month.DayOfWeek.ToString("d")) + 1;


            //first lets create a blank usercontrol
            for (int i = 1; i < day_of_the_week; i++)
            {
                UserControlBlink ucblank = new UserControlBlink();
                daycontainer.Controls.Add(ucblank);
            }


            // Create Usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);

                daycontainer.Controls.Add(ucDays);

                // 오늘 날짜 색상 하이라이트
                if ((month == nowMonth) && (year == nowYear) && (i == nowDate))
                {
                    ucDays.BackColor = Color.LightYellow;
                }
            }
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            displayToday();
        }
    }
}
