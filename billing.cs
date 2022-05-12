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
    public partial class billing : Form
    {
        public billing()
        {
            InitializeComponent();
        }

        private void txtPatientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)//13 is enter key
            {
                btnSave.PerformClick();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db"))
            {
                if(conn.State == ConnectionState.Open)
                    conn.Open();
                using(DataTable dt = new DataTable("Billing"))
                {
                    using(SQLiteCommand cmd = new SQLiteCommand("Select * from Billing where PatientId=@PatientId or Patient like @Patient", conn))
                    {
                        cmd.Parameters.AddWithValue("PatientId", txtSearch.Text);
                        cmd.Parameters.AddWithValue("Patient", txtSearch.Text);
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        da.Fill(dt);
                        gridpatients.DataSource = dt;

                    }
                }
            }
        }
        private void refresh()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            string query = "SELECT * from Billing WHERE Patient NOT NULL";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            gridpatients.DataSource = dt;
            conn.Close();
            txtCreatedby.Text = Global.globalFirstName + Global.globalLastName;
        }
        private void billing_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private const string ConnectionString = @"Data Source=.\primaryDB.db";
        private void btnSaveNewBill_Click(object sender, EventArgs e)
        {
            int tointswap = Convert.ToInt32(txtPatientId.Text);
            try
            {
                SQLiteConnection conn = new SQLiteConnection(ConnectionString);
                conn.Open();
                string sqlquery = "INSERT INTO Billing(Patient, DateCreated, ServiceProvider, Status, Amount, Notes, CreatedBy, PatientId) values (?,?,?,?,?,?,?,?)";
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlquery;
                cmd.Parameters.AddWithValue("Patient", txtPatientName.Text);
                cmd.Parameters.AddWithValue("DateCreated", txtDateCreated.Text);
                cmd.Parameters.AddWithValue("ServiceProvider", txtService.Text);
                cmd.Parameters.AddWithValue("Status", comboStatus.GetItemText(comboStatus.SelectedItem)); 
                cmd.Parameters.AddWithValue("Amount", txtAmount.Text);
                cmd.Parameters.AddWithValue("Notes", txtNotes.Text);
                cmd.Parameters.AddWithValue("CreatedBy", txtCreatedby.Text);
                cmd.Parameters.AddWithValue("PatientId", tointswap);


                cmd.ExecuteNonQuery();
                MessageBox.Show("DEBUG UPLOAD OK RELOADING BELOW");
                conn.Close();
                txtPatientName.Clear();
                txtPatientId.Clear();
                txtDateCreated.Clear();
                txtService.Clear();
                comboStatus.Items.Clear();
                txtAmount.Clear();
                txtNotes.Clear();
                txtCreatedby.Clear();
                txtPatientId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh();
        }
    }
}
