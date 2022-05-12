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
using System.Windows.Forms.DataVisualization.Charting;

namespace MedicalSoftware
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        private const string ConnectionString = @"Data Source=.\primaryDB.db";
        public static int WaitingRoomTotal = 20;
        public static int Unpaid = 0;
        public static int Paid = 0;
        public static int PayemntPlan = 0;
        public static int TotalPatients = 0;

        public static int SUMUNPAID = 0;
        public static int SUMPAID = 0;
        public static int SUMPAYMENTPLAN = 0;
        private void dashboard_Load(object sender, EventArgs e)
        {
            createPie();
            getBillPercentages();
            refresh();

        }
        private int getSizeofAppointments()
        {
            try
            {
                int waitingcount;
                SQLiteConnection conn = new SQLiteConnection(ConnectionString);
                string query = "SELECT count(Lastname) from WaitingRoom where Lastname NOT NULL";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                waitingcount = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return waitingcount;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        private void getBillPercentages()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(ConnectionString);
                string query = "SELECT count(Patient) from Billing where Patient NOT NULL AND Status = 'Unpaid'";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                Unpaid = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                conn = new SQLiteConnection(ConnectionString);
                query = "SELECT count(Patient) from Billing where Patient NOT NULL AND Status = 'Paid'";
                cmd = new SQLiteCommand(query, conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                Paid = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                conn = new SQLiteConnection(ConnectionString);
                query = "SELECT count(Patient) from Billing where Patient NOT NULL AND Status = 'Payment Plan'";
                cmd = new SQLiteCommand(query, conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                PayemntPlan = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                conn = new SQLiteConnection(ConnectionString);
                query = "SELECT count(Id) from Patients where Lastname NOT NULL";
                cmd = new SQLiteCommand(query, conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                TotalPatients = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                conn = new SQLiteConnection(ConnectionString);
                query = "SELECT count(Amount) from Billing where Patient NOT NULL AND Status = 'Unpaid'";
                cmd = new SQLiteCommand(query, conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                SUMUNPAID = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                conn = new SQLiteConnection(ConnectionString);
                query = "SELECT SUM(Amount) from Billing where Patient NOT NULL AND Status = 'Paid'";
                cmd = new SQLiteCommand(query, conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                SUMPAID = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                conn = new SQLiteConnection(ConnectionString);
                query = "SELECT SUM(Amount) from Billing where Patient NOT NULL AND Status = 'Payment Plan'";
                cmd = new SQLiteCommand(query, conn);
                conn.Open();
                cmd.CommandType = CommandType.Text;
                SUMPAYMENTPLAN = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                Unpaid = 0;
                Paid = 0;
                PayemntPlan = 0;
                TotalPatients = 0;
                SUMUNPAID = 0;
                SUMPAID= 0;
                SUMPAYMENTPLAN = 0;
            }

        }

        private void createPie()
        {
            try
            {
                getBillPercentages();


                decimal unpaidpercent = (decimal)Unpaid;
                decimal paidpercent = (decimal)Paid;
                decimal paymentplanpercent = (decimal)PayemntPlan;

                decimal total = unpaidpercent + paidpercent + paymentplanpercent;

                var unpaidpercent1 = (decimal)unpaidpercent / (decimal)total;
                var paidpercent1 = (decimal)paidpercent / (decimal)total;
                var paymentplanpercent1 = (decimal)paymentplanpercent / (decimal)total;

                
                chartBiling.Series["Money"].Points.Clear();

                chartBiling.Series["Money"].Points.AddXY("Unpaid", unpaidpercent1);
                chartBiling.Series["Money"].Points.AddXY("Paid", paidpercent1);
                chartBiling.Series["Money"].Points.AddXY("Payment Plan", paymentplanpercent1);
                lblActivePatients.Text = TotalPatients.ToString();
                lblTotalEarned.Text = "$" + SUMPAID.ToString();
                lblUnpaid.Text = "$" + (SUMUNPAID + SUMPAYMENTPLAN).ToString();
            }
            catch (Exception ex)
            {
                chartBiling.Series["Money"].Points.Clear();
                chartBiling.Series["Money"].Points.AddXY("Unpaid", 0.3333);
                chartBiling.Series["Money"].Points.AddXY("Paid", 0.3333);
                chartBiling.Series["Money"].Points.AddXY("Payment Plan", 0.3333);
                lblActivePatients.Text = TotalPatients.ToString();
                lblTotalEarned.Text = "$" + SUMPAID.ToString();
                lblUnpaid.Text = "$" + (SUMUNPAID + SUMPAYMENTPLAN).ToString();
            }
            try
            {
                decimal percentageOpen = 0;
                decimal percentageWaiting = ((decimal)getSizeofAppointments() / (decimal)WaitingRoomTotal) * 100;
                percentageOpen = 100 - percentageWaiting;
                chart3.Series["Total Appointments"].Points.Clear();
                chart3.Series["Total Appointments"].Points.AddXY("Available", percentageOpen);
                chart3.Series["Total Appointments"].Points.AddXY("Current", percentageWaiting);
            }
            catch (Exception ex)
            {
                chart3.Series["Total Appointments"].Points.Clear();
                chart3.Series["Total Appointments"].Points.AddXY("Available", 0);
                chart3.Series["Total Appointments"].Points.AddXY("Current", 0);
            }
            lblActivePatients.Text = TotalPatients.ToString();
            lblTotalEarned.Text = "$" + SUMPAID.ToString();
            lblUnpaid.Text = "$" + (SUMUNPAID + SUMPAYMENTPLAN).ToString();
        }



        private void refresh()
        {
            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            string query = "SELECT LastName, Time, Date from Appointments";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridAppointment.DataSource = dt;
            adapter.Dispose();
            conn.Close();

            conn = new SQLiteConnection(ConnectionString);
            query = "SELECT LastName, Time FROM WaitingRoom where LastName NOT NULL";
            cmd = new SQLiteCommand(query, conn);
            dt = new DataTable();
            adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            GridWaitingRm.DataSource = dt;
            adapter.Dispose();
            conn.Close ();

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void GridWaitingRm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            refresh();
            createPie();
            getSizeofAppointments();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
                conn.Open();
                string sqlquery = "Delete from WaitingRoom where Lastname = '" + txtLastname.Text + "'";
                SQLiteCommand command = new SQLiteCommand(sqlquery, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtLastname.Clear();
            txtTime.Clear();
            createPie();
            getSizeofAppointments();
            refresh();
        }

        private void dataGridAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
