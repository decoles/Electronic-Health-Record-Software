using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace MedicalSoftware
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\primaryDB.db");
        SQLiteCommand cmd = new SQLiteCommand();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if no data in the text box
            if (txtId.Text == "") //&& txtpwd.Text == ""
            {
                MessageBox.Show("Please enter ID and Pin");
            }
            else if (txtId.Text == "")
            {
                MessageBox.Show("Please enter ID");
            }
            else if (txtId.Text == "")
            {
                MessageBox.Show("Please enter PIN");
            }
            else
            {
                //ON LOGIN GET LAST NAME AND USERNAME AS THAT WILL BE UNIQUE
                Global.globalUsername = txtId.Text;
                MessageBox.Show(Global.globalUsername);
                home homefrm = new home();
                homefrm.Show();
                this.Hide();
            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
