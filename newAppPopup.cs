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
    public partial class newAppPopup : Form
    {
        public newAppPopup()
        {
            InitializeComponent();
            
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
           
        }
        private const string ConnectionString = @"Data Source=.\primaryDB.db";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void newAppPopup_Load(object sender, EventArgs e)
        {
            txtDate.Text = schedule.static_month + "/" + calenderSquareFilled.static_day + "/" + schedule.static_year;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtReason.Clear();
            txtTime.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
