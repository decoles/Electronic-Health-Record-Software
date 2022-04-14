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


namespace MedicalSoftware
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if no data in the text box
            if (txtId.Text == "" && txtPin.Text == "")
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
                home homefrm = new home();
                homefrm.Show();

            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            //cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\David\source\repos\490\MedicalSoftware\medDB.mdf;Integrated Security=True");
            //cn.Open();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register regsterFrm = new Register();
            regsterFrm.Show();
            //this.Close();
        }
    }
}
