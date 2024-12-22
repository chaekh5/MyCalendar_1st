using MyCalendar.Ind.DateEvent;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;


namespace MyCalendar
{
    public partial class UserControlDays : UserControl
    {
        
        Testform testform = new Testform();
        EventView eventview = new EventView();

        int select_year = Form1.year;
        int select_month = Form1.month;
        int date;
        private Form1 form;

       

        public UserControlDays()
        {
            InitializeComponent();
        }

        public UserControlDays(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void Days(int numday)
        {
            lbdays.Text = numday + "";
            date = numday;
        }

        public void Add_event(string event_name)
        {
            string add_event_item = "☆ " + event_name + "\n";            
            event_list.Items.Add(add_event_item);
        }


        private void UserControlDays_mouseHover(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
            //Testform testform_pop = new Testform();
            //EventView eventView_pop = new EventView();
            //testform = testform_pop;
            //eventView_pop = eventview;

            //testform.Show();
            //eventView_pop.Show();
        }

        private void UserControlDays_mouseLeave(object sender, EventArgs e)
        {
            //Thread.Sleep(300);
            //testform.Close();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(form);
            eventForm.GetDate(date);
            eventForm.ShowDialog();
        }

        private void event_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(event_list.SelectedItem != null)
            {
                string? selected_value = event_list.SelectedItem.ToString();
                if (selected_value.Length > 0)
                {
                    selected_value = selected_value.Substring(2);
                    selected_value = selected_value.TrimEnd('\n');
                }
                // 해당아이템 삭제 여부 질문


                // 아이템 삭제
                try
                {
                    // DB경로 획득
                    StreamReader sr = new(Directory.GetCurrentDirectory() + "/config/DB_path.config");
                    string? db_path = sr.ReadLine();
                    sr.Close();

                    // DB연결
                    SQLiteConnection conn = new SQLiteConnection("Data Source = " + db_path);
                    conn.Open();
                    // DELETE 쿼리문 생성
                    string sql = "DELETE FROM schedule WHERE Year = " + select_year + " AND Month = " + select_month + " AND Day = " + date + " AND Event = '" + (selected_value) + "';";
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    int result = command.ExecuteNonQuery();

                    MessageBox.Show("삭제되었습니다. 까꿍");

                    conn.Close();

                    Program.Display_calendar(select_month, select_year, form);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }        
            else
            {

                EventForm eventForm = new EventForm(form);
                eventForm.GetDate(date);
                eventForm.ShowDialog();
            }
            

        }

        public void UserControlDays_Today_highlight()
        {
            this.BackColor = Color.LightYellow;
            this.event_list.BackColor = Color.LightYellow;
        }


    }
}
