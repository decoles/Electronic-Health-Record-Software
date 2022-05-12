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
    public partial class addPatient : Form
    {
        public addPatient()
        {
            InitializeComponent();
        }
        public string value = "";
        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPatient_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtPatientId.Text = random.Next(00000, 99999).ToString();
        }
        private void refreshdata()
        {
            
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            string query = "SELECT Id, Firstname, Lastname from Patients WHERE Firstname NOT NULL";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            gridpatients.DataSource = dt;
            adapter.Dispose();
        }

        private void addPatient_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            txtPatientId.Text = random.Next(00000, 99999).ToString();
            refreshdata();
        }

        private void btnMedClear_Click(object sender, EventArgs e)
        {
            txtMedFirst.Clear();
            txtMedLast.Clear();
            txtMedID.Clear();
            txtMedMedication.Clear();
            txtMedDosage.Clear();
            txtMedNotes.Clear();
        }

        private void bntMedSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            string sqlquery = "INSERT INTO Medication(Medication, Dosage, Name, PatientId, Notes) values (?,?,?,?,?)";
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlquery;
            cmd.Parameters.AddWithValue("Medication", txtMedMedication.Text);
            cmd.Parameters.AddWithValue("Dosage", txtMedDosage.Text);
            cmd.Parameters.AddWithValue("Name", txtMedFirst.Text + " " +txtMedLast.Text);
            cmd.Parameters.AddWithValue("PatientId", txtPatientId.Text);
            cmd.Parameters.AddWithValue("Notes", txtMedNotes);

            cmd.ExecuteNonQuery();
            MessageBox.Show("DEBUG UPLOAD OK RELOADING BELOW");
            conn.Close();
            cmd.Dispose();

            txtMedFirst.Clear();
            txtMedLast.Clear();
            txtMedID.Clear();
            txtMedMedication.Clear();
            txtMedDosage.Clear();
            txtMedNotes.Clear();
        }

        private void btnDiagClear_Click(object sender, EventArgs e)
        {
            txtPatientId.Clear();
            txtDiagIssue.Clear();
            txtMedDosage.Clear();
            txtDiagNotes.Clear();
        }

        private void btnVitalClear_Click(object sender, EventArgs e)
        {
            txtVitalId.Clear();
            txtVitaTemp.Clear();
            txtVitaBP.Clear();
            txtVitaSPO.Clear();
            txtVitalPain.Clear();
            txtVitaNote.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtphone.Clear();
            comboGender.Items.Clear();
            txtbirthday.Clear();
            txtaddress.Clear();
            txtstate.Clear();
            txtzip.Clear();
            txtssn.Clear();
            textBox1.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private const string ConnectionString = @"Data Source=.\primaryDB.db";
        private void btnSave_Click(object sender, EventArgs e)
        {

            int tointswap = Convert.ToInt32(txtPatientId.Text);
            try
            {
                SQLiteConnection conn = new SQLiteConnection(ConnectionString);
                conn.Open();
                string sqlquery = "INSERT INTO Patients(Firstname, Lastname, Address, State, Zipcode, Birthdate, SSN, Phone, Gender, Email) values (?,?,?,?,?,?,?,?,?,?)";
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlquery;
                cmd.Parameters.AddWithValue("Firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("Lastname", txtLastname.Text);
                cmd.Parameters.AddWithValue("Address", txtaddress.Text);
                cmd.Parameters.AddWithValue("State", txtstate.Text);
                cmd.Parameters.AddWithValue("Zipcode", txtzip.Text);
                cmd.Parameters.AddWithValue("Birthdate", txtbirthday.Text);
                cmd.Parameters.AddWithValue("SSN", txtssn.Text);
                cmd.Parameters.AddWithValue("Phone", txtphone.Text);
                cmd.Parameters.AddWithValue("Gender", comboGender.GetItemText(comboGender.SelectedItem));
                cmd.Parameters.AddWithValue("Email", textBox1.Text);



                cmd.ExecuteNonQuery();
                MessageBox.Show("DEBUG UPLOAD OK RELOADING BELOW");
                conn.Close();
                cmd.Dispose();
                txtFirstname.Clear();
                txtLastname.Clear();
                txtphone.Clear();
                comboGender.Items.Clear();
                txtbirthday.Clear();
                txtaddress.Clear();
                txtstate.Clear();
                txtzip.Clear();
                txtssn.Clear();
                textBox1.Clear();
                refreshdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.gridpatients.Update();
        }
        
        private void gridpatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            value = gridpatients.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
            SQLiteCommand cmd = new SQLiteCommand();
            //ON LOGIN GET LAST NAME AND USERNAME AS THAT WILL BE UNIQUE
            conn.Open();
            string query = "SELECT * FROM Patients WHERE Id = '" + value + "'";
            cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                txtPatientId.Text = dataReader[0].ToString();
                txtDiagID.Text = dataReader[0].ToString();
                txtMedID.Text = dataReader[0].ToString();
                txtVitalId.Text = dataReader[0].ToString();
                txtAllergyId.Text = dataReader[0].ToString();
                txtFirstname.Text  = dataReader[1].ToString();
                txtLastname.Text = dataReader[2].ToString();
                txtphone.Text = dataReader[8].ToString();
                comboGender.SelectedValue = dataReader[9].ToString();
                txtbirthday.Text = dataReader[6].ToString();
                txtaddress.Text = dataReader[3].ToString();
                txtstate.Text  = dataReader[4].ToString();
                txtzip.Text = dataReader[5].ToString(); 
                txtssn.Text = dataReader[7].ToString();
                textBox1.Text = dataReader[10].ToString();
                dataReader.Close();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD");
            }
            conn.Close();
            dataReader.Close ();
            //REST OF PARTS
            //ON LOGIN GET LAST NAME AND USERNAME AS THAT WILL BE UNIQUE

        }

        private void btnVitalSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            string sqlquery = "INSERT INTO Vitals(PatientId, Temperature, BloodPressure, Spo2,pain, LevelofAwareness, Notes, Height, Weight) values (?,?,?,?,?,?,?,?,?)";
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlquery;
            cmd.Parameters.AddWithValue("PatientId", txtVitalPain.Text);
            cmd.Parameters.AddWithValue("Temperature", txtVitaTemp.Text);
            cmd.Parameters.AddWithValue("BloodPressure", txtVitaBP.Text);
            cmd.Parameters.AddWithValue("Spo2", txtVitaSPO.Text);
            cmd.Parameters.AddWithValue("pain", txtVitalPain.Text);
            cmd.Parameters.AddWithValue("LevelofAwareness", comboLOV.GetItemText(comboLOV.SelectedItem));
            cmd.Parameters.AddWithValue("Notes", txtVitaNote.Text);
            cmd.Parameters.AddWithValue("Height", txtVitalHeight.Text);
            cmd.Parameters.AddWithValue("Weight", txtVitalWeight.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("DEBUG UPLOAD OK RELOADING BELOW");
            conn.Close();
            cmd.Dispose();


            txtVitalId.Clear();
            txtVitaTemp.Clear();
            txtVitaBP.Clear();
            txtVitaSPO.Clear();
            txtVitalPain.Clear();
            txtVitaNote.Clear();
            txtVitalHeight.Clear();
            txtVitalWeight.Clear();

        }

        private void btnDiagSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            string sqlquery = "INSERT INTO Diagnoses(PatientId, Issue, Severity, Notes) values (?,?,?,?)";
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlquery;
            cmd.Parameters.AddWithValue("PatientId", txtDiagID.Text);
            cmd.Parameters.AddWithValue("Issue", txtDiagIssue.Text);
            cmd.Parameters.AddWithValue("Severity", txtDiagSeverity.Text);
            cmd.Parameters.AddWithValue("Notes", txtDiagSeverity.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("DEBUG UPLOAD OK RELOADING BELOW");
            conn.Close();
            cmd.Dispose();


            txtPatientId.Clear();
            txtDiagIssue.Clear();
            txtMedDosage.Clear();
            txtDiagNotes.Clear();
        }

        private void btnAllergiesSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            string sqlquery = "INSERT INTO Allergies(PatientId, Foodallergies, Drugallergies) values (?,?,?)";
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlquery;
            cmd.Parameters.AddWithValue("PatientId", txtAllergyId.Text);
            cmd.Parameters.AddWithValue("Foodallergies", txtFoodAllergies.Text);
            cmd.Parameters.AddWithValue("Drugallergies", txtDrugAllergies.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DEBUG UPLOAD OK RELOADING BELOW");
            conn.Close();
            cmd.Dispose();

            txtAllergyId.Clear();
            txtFoodAllergies.Clear();
            txtDrugAllergies.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAllergyId.Clear();
            txtFoodAllergies.Clear();
            txtDrugAllergies.Clear();
        }
    }
}
