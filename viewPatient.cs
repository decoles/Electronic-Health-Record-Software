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
    public partial class viewPatient : Form
    {
        public viewPatient()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void viewPatient_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            string query = "SELECT Id, Firstname, Lastname from Patients WHERE Firstname NOT NULL";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            gridpatientsChange.DataSource = dt;
            adapter.Dispose();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
       
        }
        public string value = "";
        private void txtemail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void gridpatientsChange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            value = gridpatientsChange.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            SQLiteCommand cmd = new SQLiteCommand();
            //ON LOGIN GET LAST NAME AND USERNAME AS THAT WILL BE UNIQUE
            conn.Open();
            string query = "SELECT * FROM Patients WHERE Id = '" + value + "'";
            cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                lblPatientId.Text = dataReader[0].ToString();
                lblfirstname.Text = dataReader[1].ToString();
                lbllastname.Text = dataReader[2].ToString();
                lblphone.Text = dataReader[8].ToString();
                lblgender.Text = dataReader[9].ToString();
                lblbirth.Text = dataReader[6].ToString();
                lbladdress.Text = dataReader[3].ToString();
                lblState.Text = dataReader[4].ToString();
                lblzip.Text = dataReader[5].ToString();
                lblssn.Text = dataReader[7].ToString();
                lblemail.Text = dataReader[10].ToString();
                dataReader.Close();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD");
            }
            conn.Close();
            dataReader.Close();
            //REST OF PARTS
            //ON LOGIN GET LAST NAME AND USERNAME AS THAT WILL BE UNIQUE
            conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            query = "SELECT Medication, Dosage, Name, PatientId from Medication WHERE PatientId = '"+value+"'";
            cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            GridMeds.DataSource = dt;
            adapter.Dispose();
            conn.Close();


            conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            query = "SELECT PatientId, Issue, Severity Notes from Diagnoses WHERE PatientId = '" + value + "'";
            cmd = new SQLiteCommand(query, conn);
            dt = new DataTable();
            adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            gridDiag.DataSource = dt;
            adapter.Dispose();
            conn.Close();

            conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            query = "SELECT PatientId, Temperature, BloodPresure, Spo2, pain, LevelofAwareness, Notes, Height, Weight from Vitals WHERE PatientId = '" + value + "'";
            cmd = new SQLiteCommand(query, conn);
            dt = new DataTable();
            adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            gridVital.DataSource = dt;
            adapter.Dispose();
            conn.Close();

            conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            query = "SELECT PatientId, Foodallergies, Drugallergies from Allergies  WHERE PatientId = '" + value + "'";
            cmd = new SQLiteCommand(query, conn);
            dt = new DataTable();
            adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataAllergies.DataSource = dt;
            adapter.Dispose();
            conn.Close();

        }
    }
}
