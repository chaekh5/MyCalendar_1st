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
    public partial class EventForm : Form
    {
        string eventdate;          


        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
           
            

        }

        public void GetDate(string date)
        {
            eventdate = date;
            textBox1.Text = eventdate;
        }
    }
}
