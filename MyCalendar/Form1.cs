namespace MyCalendar
{
    public partial class Form1 : Form
    {
        int month, year;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            // Get First day of the Month
            DateTime start_of_month = new DateTime(year, month, 1);

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
            }
            title_month.Text = month.ToString() + " ��";

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
           
            daycontainer.Controls.Clear();            

            month++;
            if (month > 12)
            {
                month -= 12;
                year++;
            }
            title_month.Text = month.ToString() + " ��";

            // Get First day of the Month
            DateTime start_of_month = new DateTime(year, month, 1);

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
            }
           


        }
    }
}
