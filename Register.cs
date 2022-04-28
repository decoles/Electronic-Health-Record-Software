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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
        //string query = "SELECT * from Staff";
        SQLiteCommand cmd = new SQLiteCommand();
        //DataTable dt = new DataTable();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        //adapter.Fill(dt);
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            formLogin formLogin = new formLogin();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" && txtpswd.Text == "" && txtpwdredo.Text == "" && txtFirName.Text == "" && txtLastName.Text == "")
            {
                MessageBox.Show("Please fill in Username and Password fields");
            }
            else if(txtpswd.Text == txtpwdredo.Text)
            {
                conn.Open();
                string register = "INSERT INTO Staff VALUES ('" + txtId.Text + "','" + txtpswd.Text + "')";
                cmd = new SQLiteCommand(register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Account Created!");
            }
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirName.Clear();
            txtLastName.Clear();
            txtId.Clear();
            txtpswd.Clear();
            txtpwdredo.Clear();
        }
    }
}
