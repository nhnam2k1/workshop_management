using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Management_OOD_W12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Default view
            pnlMain.Controls.Clear();
            UserUC userUC = new UserUC();
            pnlMain.Controls.Add(userUC);
            userUC.BringToFront();
        }

        private void btnUcUsers_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UserUC userUC = new UserUC();
            pnlMain.Controls.Add(userUC);
            userUC.BringToFront();
        }

        private void btnUcWorkshops_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            WorkshopUC workshopUC = new WorkshopUC();
            pnlMain.Controls.Add(workshopUC);
            workshopUC.BringToFront();
        }

        private void btnUcEnrollments_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            EnrollmentUC enrollmentUC = new EnrollmentUC();
            pnlMain.Controls.Add(enrollmentUC);
            enrollmentUC.BringToFront();
        }
    }
}
