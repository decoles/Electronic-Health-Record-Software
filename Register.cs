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
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
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
            if (txtId.Text == "" || txtpswd.Text == "" || txtpwdredo.Text == "" || txtFirName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else if(txtpswd.Text == txtpwdredo.Text)
            {
                conn.Open();
                string register = "INSERT INTO Staff  (Username, Password, FirstName, LastName)";
                string values = "VALUES ('" + txtId.Text + "','" + txtpswd.Text + "','" + txtFirName.Text + "','" + txtLastName.Text + "')";
                string together = register + values;
                //if(txtId.Text == )
                cmd = new SQLiteCommand(together, conn);
       
                int a = cmd.ExecuteNonQuery();
                if(a > 0) //Checks if value is created should be greater than one when created.
                {
                    MessageBox.Show("Account Created!");
                }
                conn.Close();
                new formLogin().Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Passwords Do not Match");
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

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
