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
    public partial class calenderSquareFilled : UserControl
    {
        public static string static_day = "";
        public calenderSquareFilled()
        {
            InitializeComponent();
        }

        private void calenderSquareFilled_Load(object sender, EventArgs e)
        {

        }
        public void days(int day)
        {
               lblDay.Text = day+ "";
        }

        private void calenderSquareFilled_Click(object sender, EventArgs e)
        {
            static_day = lblDay.Text;
            //schedule.
            
            schedule.teststring = static_day;

        }
    }
}
