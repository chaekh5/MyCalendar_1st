using MyCalendar.Ind.DateEvent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class EventForm : Form
    {
        private Form1 form;
        string s_eventdate;
        // 전역변수(static)은 new 인스턴스 참조 필요없음
        int get_month = Form1.month;
        int get_year = Form1.year;
        int get_day;

        public EventForm()
        {
            InitializeComponent();
        }

        public EventForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }


        public void GetDate(int date)
        {
            get_day = date;
            s_eventdate = get_year.ToString() + "년" + get_month.ToString() + "월" + get_day.ToString() + "일";
            textBox1.Text = s_eventdate;
        }

        private void btn_event_save_Click(object sender, EventArgs e)
        {
            input_DB_data();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input_DB_data();
            }
            return;

        }

        private void input_DB_data()
        {
            // 데이터베이스에 이벤트 입력하기
            try
            {
                // DB경로 획득
                StreamReader sr = new(Directory.GetCurrentDirectory() + "/config/DB_path.config");
                string? db_path = sr.ReadLine();
                sr.Close();

                // DB연결
                SQLiteConnection conn = new SQLiteConnection("Data Source = " + db_path);
                conn.Open();
                // row 추가
                string event_Text = textBox2.Text;
                // INSERT 쿼리문 생성
                string sql = "INSERT INTO schedule (Year, Month, Day, Event) values (" + get_year + "," + get_month + "," + get_day + "," + "'" + event_Text + "'" + ");";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                int result = command.ExecuteNonQuery();

                MessageBox.Show("저장되었습니다. 까꿍");
                //string test_sql = "select * from schedule";
                //SQLiteCommand cmd = new SQLiteCommand(test_sql, conn);
                //SQLiteDataReader rdr = cmd.ExecuteReader();
                //while (rdr.Read())
                //{
                //    MessageBox.Show(rdr["Year"] + " " + rdr["Month"] + " " + rdr["Day"] + " " + rdr["Event"]);
                //}
                //rdr.Close();

                conn.Close();

                this.Close();
                
                Program.Display_calendar(get_month, get_year, form);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_event_delete_Click(object sender, EventArgs e)
        {
            EventDeleteForm eventDeleteForm = new EventDeleteForm();
            eventDeleteForm.GetDate(s_eventdate);
            eventDeleteForm.ShowDialog();
            

        }
    }
}
