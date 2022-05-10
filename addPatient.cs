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
    public partial class addPatient : Form
    {
        public addPatient()
        {
            InitializeComponent();
        }

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

        private void addPatient_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            txtPatientId.Text = random.Next(00000, 99999).ToString();
        }
    }
}
