using System.Data.SQLite;

namespace MyCalendar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }


        public static void Display_calendar(int month, int year, Form1 form)
        {           
            form.Daycontainer_clear();
            form.GetTitleMonth_TitleYear(month, year);

            // Get First day of the Month
            DateTime start_of_month = new DateTime(year, month, 1);
            // Get Today's Date
            int nowDate = DateTime.Now.Day;
            int nowMonth = DateTime.Now.Month;
            int nowYear = DateTime.Now.Year;


            // Get the count of Days of the month
            int days = DateTime.DaysInMonth(year, month);

            // Convert the start_of_month to integer
            int day_of_the_week = Convert.ToInt32(start_of_month.DayOfWeek.ToString("d")) + 1;

            // 데이터베이스에서 이벤트데이터 가져오기
            try
            {
                uint DB_day;
                string? DB_event;   // null 허용 한정자

                // 날짜와 이벤트 리스트 선언
                List<(uint Day, string Event)> dayEventList = new List<(uint Day, string Event)>();

                // DB연결
                SQLiteConnection conn = new SQLiteConnection("Data Source = D:/PROJECT/CS_PROJECT/MyCalendar_sln/db/jians_db.db");
                conn.Open();

                // 쿼리문
                string sql = "SELECT * FROM schedule WHERE Year=" + year + " AND " + "Month=" + month;
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                var reader = cmd.ExecuteReader();

                // 이달의 이벤트만 추출해서 리스트 저장하기
                while (reader.Read())
                {
                    DB_day = Convert.ToUInt32(reader["Day"].ToString());
                    DB_event = reader["Event"].ToString();
                    dayEventList.Add((DB_day, DB_event));
                }

                // 리스트를 배열로 변환
                var dayEventArray = dayEventList.ToArray();

                //first lets create a blank usercontrol
                for (int i = 1; i < day_of_the_week; i++)
                {
                    UserControlBlink ucblank = new UserControlBlink();
                    form.Daycontainer_Control_Add(ucblank);
                }


                // Create Usercontrol for Days
                for (int i = 1; i <= days; i++)
                {
                    UserControlDays ucDays = new UserControlDays(form);
                    ucDays.Days(i);
                    form.Daycontainer_Control_Add(ucDays);

                    foreach (var item in dayEventArray)
                    {
                        if (item.Day == i)
                        {
                            ucDays.Add_event(item.Event);
                        }
                    }

                    // 오늘 날짜 색상 하이라이트
                    if ((month == nowMonth) && (year == nowYear) && (i == nowDate))
                    {
                        ucDays.UserControlDays_Today_highlight();


                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}