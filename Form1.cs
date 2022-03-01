using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (txtId.Text == "" && txtPin.Text == "")
            {
                MessageBox.Show("Please enter ID and Pin");
            }
            else if (txtId.Text == "")
            {
                MessageBox.Show("Please enter ID");
            }
            else
            {
                MessageBox.Show("Please enter PIN");
            }
        }
    }
}
