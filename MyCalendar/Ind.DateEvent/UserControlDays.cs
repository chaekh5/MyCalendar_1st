using MyCalendar.Ind.DateEvent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyCalendar
{
    public partial class UserControlDays : UserControl
    {

        Testform testform = new Testform();
        EventView eventview = new EventView();
        int date;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
            date = numday;
        }

        public void Add_event(string event_name)
        {
            string add_event_item = "♪ " + event_name + "\n";
            event_list.Items.Add(add_event_item);
        }


        private void UserControlDays_mouseHover(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Testform testform_pop = new Testform();
            EventView eventView_pop = new EventView();
            testform = testform_pop;
            eventView_pop = eventview;

            testform.Show();
            eventView_pop.Show();
        }

        private void UserControlDays_mouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(300);
            testform.Close();

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.GetDate(date);
            eventForm.ShowDialog();
        }

        private void event_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.GetDate(date);
            eventForm.ShowDialog();
        }
    }
}
