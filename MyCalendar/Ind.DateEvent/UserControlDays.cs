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
        }



        private void UserControlDays_mouseHover(object sender, EventArgs e)
        {
            Testform testform_pop = new Testform();
            testform = testform_pop;            
            testform.Show();
        }

        private void UserControlDays_mouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            testform.Close();        

        }
    }
}
