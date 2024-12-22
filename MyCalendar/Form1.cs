using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class Form1 : Form
    {
        public static int month, year;

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

            Program.Display_calendar(month, year, this);            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month -= 12;
                year++;
            }
            Program.Display_calendar(month, year, this);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {

            month--;
            if (month < 1)
            {
                month += 12;
                year--;
            }

            Program.Display_calendar(month, year, this);
        }


        private void btn_today_Click(object sender, EventArgs e)
        {
            displayToday();
        }

        public void Daycontainer_clear()
        {
            daycontainer.Controls.Clear();
        }
        public void GetTitleMonth_TitleYear(int month, int year)
        {
            title_month.Text = month.ToString() + " ¿ù";
            title_year.Text = year.ToString() + " ³â";
        }
        public void Daycontainer_Control_Add(UserControlDays item)
        {
            daycontainer.Controls.Add(item);
        }
        public void Daycontainer_Control_Add(UserControlBlink item)
        {
            daycontainer.Controls.Add(item);
        }



    }
}
