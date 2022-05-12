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

namespace MedicalSoftware
{
    public partial class calenderSquareFilled : UserControl
    {
        public static string static_day = "";
        public calenderSquareFilled()
        {
            InitializeComponent();
        }
        private const string ConnectionString = @"Data Source=.\primaryDB.db";
        private void calenderSquareFilled_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (schedule.static_month.Length == 1)
            {
                schedule.static_month = "0" + schedule.static_month;
            }
            if (lblDay.Text.Length == 1)
            {
                lblDay.Text = "0" + lblDay.Text;
            }
            string sqlquery = "SELECT Time, Lastname FROM Appointments where Date =  \""+ schedule.static_month + "/" + lblDay.Text + "/"+ schedule.static_year +"\"";
            //MessageBox.Show(sqlquery);

            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            
            SQLiteCommand cmd = new SQLiteCommand(sqlquery,conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            if(adapter== null)
            {
                MessageBox.Show("NULL");
            }
            dataGridView1.DataSource = dt;
            adapter.Dispose();
            
            //cmd.Parameters.AddWithValue("Date", schedule.static_month + "/" + lblDay.Text + "/" + schedule.static_year);


            conn.Close();

        }
        public void days(int day)
        {

            lblDay.Text = day+ "";
            
        }

        private void calenderSquareFilled_Click(object sender, EventArgs e)
        {
            static_day = lblDay.Text;
            newAppPopup newAppPopup = new newAppPopup();
            newAppPopup.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
