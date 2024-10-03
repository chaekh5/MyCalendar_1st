namespace MyCalendar
{
    public partial class Form1 : Form
    {
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

            // Get First day of the Month

            DateTime start_of_month = new DateTime(now.Year, now.Month, 1);

            // Get the count of days of the month
            int days = DateTime.DaysInMonth(now.Year, now.Month);

            // Convert the start_of_month to integer

            int day_of_week = Convert.ToInt32(start_of_month.DayOfWeek.ToString("d"));
            
            //first lets create a blank usercontrol

        }
    }
}
