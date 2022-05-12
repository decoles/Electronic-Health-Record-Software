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
            if (txtSearch.Text != "")
            {
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
                string query = "SELECT * from Billing WHERE Patient LIKE '" + txtSearch.Text + "' OR Amount LIKE '" + txtSearch.Text + "' OR Status LIKE '" + txtSearch.Text + "' ";
                MessageBox.Show(query.ToString());
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                gridpatients.DataSource = dt;
                conn.Close();
                adapter.Dispose();
            }
            else
            {
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
                string query = "SELECT * from Billing WHERE Patient NOT NULL";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                gridpatients.DataSource = dt;
                conn.Close();
                adapter.Dispose();
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
            adapter.Dispose();
            txtCreatedby.Text = Global.globalFirstName + " " + Global.globalLastName;
        }
        private void billing_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private const string ConnectionString = @"Data Source=.\primaryDB.db";
        private void btnSaveNewBill_Click(object sender, EventArgs e)
        {
            
            try
            {
                int tointswap = Convert.ToInt32(txtPatientId.Text);
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

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCreatedby_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
