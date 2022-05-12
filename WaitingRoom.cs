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
    public partial class WaitingRoom : Form
    {
        public WaitingRoom()
        {
            InitializeComponent();
        }

        private void WaitingRoom_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLastname.Clear();
            txtTime.Clear();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            conn.Open();
            string sqlquery = "INSERT INTO WaitingRoom(LastName, Time) values (?,?)";
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlquery;
            cmd.Parameters.AddWithValue("LastName", txtLastname.Text);
            cmd.Parameters.AddWithValue("Time", txtTime.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DEBUG UPLOAD OK RELOADING BELOW");
            conn.Close();
            cmd.Dispose();
            txtLastname.Clear();
            txtTime.Clear();
        }
    }
}
