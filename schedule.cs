using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;
/// <summary>
/// Schedule page, some code modeled after Jeov Dev
/// </summary>
namespace MedicalSoftware
{
    public partial class schedule : Form
    {
        private const string ConnectionString = @"Data Source=.\primaryDB.db";
        int month, year;

        public schedule()
        {
            InitializeComponent();
        }
        public static string static_year;
        public static string static_month;

        private void schedule_Load(object sender, EventArgs e)
        {
            //SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            //string query = "SELECT * from Appointments";
            //SQLiteCommand cmd = new SQLiteCommand(query, conn);
            //DataTable dt = new DataTable();
            //SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
           // adapter.Fill(dt);

            //dataGridView1.DataSource = dt;
            displayDays();
            //MessageBox.Show(teststring);
            
        }


        private void displayDays()
        {
            
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            static_year = year.ToString();
            static_month = month.ToString();
            string monthstring = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthstring + " " + year;
            //days in month
            DateTime firstofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(month, month);
            // turn first day to number
            //days of the week
            int dotw = Convert.ToInt32(firstofmonth.DayOfWeek.ToString("d"));
            //Creats first few blank pieces to properly setup calender for days of the week
            for(int i = 1; i < dotw; i++)
            {
                calenderSquare calenderSquare = new calenderSquare();
                panelCalender.Controls.Add(calenderSquare);
            }
            for (int i = 1; i < days; i++)
            {
                calenderSquareFilled calfilled = new calenderSquareFilled();
                calfilled.days(i);
              panelCalender.Controls.Add(calfilled);
            }

        }


        private void btntest_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panelSchedule_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            panelCalender.Controls.Clear();
            month--;
            if (month == 0)
            {
                year--;
                month = 12;
            }

            string monthstring = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthstring + " " + year;
            DateTime now = DateTime.Now;
            //days in month
            static_year = year.ToString();
            static_month = month.ToString();
            DateTime firstofmonth = new DateTime(month, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            // turn first day to number
            //days of the week
            int dotw = Convert.ToInt32(firstofmonth.DayOfWeek.ToString("d"));
            //Creats first few blank pieces to properly setup calender for days of the week
            for (int i = 1; i < dotw; i++)
            {
                calenderSquare calenderSquare = new calenderSquare();
                panelCalender.Controls.Add(calenderSquare);
            }
            for (int i = 1; i < days; i++)
            {
                calenderSquareFilled calfilled = new calenderSquareFilled();
                calfilled.days(i);
                panelCalender.Controls.Add(calfilled);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            string sqlquery = "INSERT INTO Appointments(Firstname, Lastname, Date, Reason, Time) values (?,?,?,?,?)";
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlquery;
            cmd.Parameters.AddWithValue("Firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("Lastname", txtLastname.Text);
            cmd.Parameters.AddWithValue("Date", txtDate.Text);
            cmd.Parameters.AddWithValue("Reason", txtReason.Text);
            cmd.Parameters.AddWithValue("Time", txtTime.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("DEBUG UPLOAD OK");
            conn.Close();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtReason.Clear();
            txtDate.Clear();    
            txtTime.Clear();    
            this.Refresh();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            panelCalender.Controls.Clear();
            month++;
            if (month == 13)
            {
                year++;
                month = 1;
            }

            string monthstring = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthstring + " " + year;
            DateTime now = DateTime.Now;
            static_year = year.ToString();
            static_month = month.ToString();
            //days in month
            DateTime firstofmonth = new DateTime(month, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            // turn first day to number
            //days of the week
            int dotw = Convert.ToInt32(firstofmonth.DayOfWeek.ToString("d"));
            //Creats first few blank pieces to properly setup calender for days of the week
            for (int i = 1; i < dotw; i++)
            {
                calenderSquare calenderSquare = new calenderSquare();
                panelCalender.Controls.Add(calenderSquare);
            }
            for (int i = 1; i < days; i++)
            {
                calenderSquareFilled calfilled = new calenderSquareFilled();
                calfilled.days(i);
                panelCalender.Controls.Add(calfilled);
            }
        }
    }
}
