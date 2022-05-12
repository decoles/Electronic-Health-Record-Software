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
    public partial class PickAPatientFrm : Form
    {
        public PickAPatientFrm()
        {
            InitializeComponent();
        }
        private const string ConnectionString = @"Data Source=.\primaryDB.db";
        private void PickAPatientFrm_Load(object sender, EventArgs e)
        {
                  
        Global.currentPatient = "";
        SQLiteConnection conn = new SQLiteConnection(ConnectionString);
        string query = "SELECT Id, Firstname, Lastname FROM Patients WHERE Firstname NOT NULL";
        SQLiteCommand cmd = new SQLiteCommand(query, conn);
        DataTable dt = new DataTable();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
        adapter.Fill(dt);

            gridpatients.DataSource = dt;
            conn.Close();
            adapter.Dispose();
        }

        private void gridpatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = "";
            value = gridpatients.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            Global.currentPatient = value;
            this.Hide();
        }

        private void gridpatients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = "";
            value = gridpatients.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            Global.currentPatient = value;
            this.Hide();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
