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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();

        }
        private void home_Load(object sender, EventArgs e)
        {
            //Starts dashboard from scratch
            lblUSER.Text = "Welcome " + Global.globalFirstName + " "+Global.globalLastName;
            openChildForm(new dashboard());
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Global.globalLastName = "";
            this.Close();
            new formLogin().Show();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                {activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new dashboard());
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            openChildForm(new addPatient());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            if(Global.currentPatient == "")
            {
                PickAPatientFrm pickAPatient = new PickAPatientFrm();
                pickAPatient.Show();
                if(Global.currentPatient!= "")
                {
                    openChildForm(new viewPatient());
                }
            }
            else
            {
                openChildForm(new viewPatient());

            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            openChildForm(new schedule());
        }

        private void panelMaster_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTopMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            openChildForm(new billing());
        }
    }
}
