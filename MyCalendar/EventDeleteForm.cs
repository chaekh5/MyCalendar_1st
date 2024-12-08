namespace MyCalendar
{
    public partial class EventDeleteForm : Form
    {
        string event_date = string.Empty;

        public EventDeleteForm()
        {
            InitializeComponent();
        }

        public void Load_event_list()
        {
            UserControlDays userControlDays = new UserControlDays();


        }

        public void GetDate(string date)
        {
            event_date = date;
            date_selected.Text = event_date;
        }

    }


}
