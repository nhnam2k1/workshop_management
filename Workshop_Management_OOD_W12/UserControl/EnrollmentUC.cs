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
    public partial class EnrollmentUC : UserControl
    {
        private static List<string> messages;
        private static event EventHandler handleStaticEvents;
        private IEnrollmentManager enrollmentManager;
        private IEnrollmentModel enrollmentModel;
        private Enrollment[] enrollments;
        private EventHandler updateEnrollmentListView;
        public EnrollmentUC() 
        {
            try {
                InitializeComponent();

                enrollmentModel   = new EnrollmentModel();
                enrollmentManager = new EnrollmentManager(enrollmentModel);
                updateEnrollmentListView = new EventHandler(UpdateWarningMessage);

                if (messages == null) {
                    messages = new List<string>();
                }
                UpdateEnrollmentsListView();
                UpdateWarningMessage(true, EventArgs.Empty);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
        public static void HandleWarningMessage(string message) 
        {
            messages.Add(message);
            if (handleStaticEvents != null)
            {
                handleStaticEvents(true, EventArgs.Empty);
            }
        }
        private void UpdateEnrollmentsListView()
        {
            lvEnrollments.Items.Clear();
            enrollments = enrollmentManager.GetEnrollments();
            foreach(Enrollment enrollment in enrollments)
            {
                Student student = enrollment.Student;
                string name = $"{student.FirstName} {student.LastName}";
                string info = (enrollment is OnlineEnrollment)
                            ? ((OnlineEnrollment)enrollment).LoginCode
                            : ((InBuildingEnrollment)enrollment).Seat.ToString();

                ListViewItem lvi = new ListViewItem(enrollment.ID.ToString());
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(enrollment.Workshop.Title);
                lvi.SubItems.Add(info);
                lvi.Name = enrollment.ID.ToString();
                lvEnrollments.Items.Add(lvi);
            }
        }
        private void UpdateWarningMessage(object sender, EventArgs e)
        {
            lvWarningSystem.Items.Clear();
            foreach(string message in messages)
            {
                ListViewItem lvi = new ListViewItem(message);
                lvWarningSystem.Items.Add(lvi);
            }
        }
        private void EnrollmentUC_Enter(object sender, EventArgs e)
        {
            if (handleStaticEvents == null)
            {
                handleStaticEvents += updateEnrollmentListView;
            }
        }
        private void EnrollmentUC_Leave(object sender, EventArgs e)
        {
            if (enrollmentModel is IPersistentSerializeStorage)
            {
                ((IPersistentSerializeStorage)enrollmentModel).SaveData();
            }
            if (handleStaticEvents != null)
            {
                handleStaticEvents -= updateEnrollmentListView;
            }
        }
    }
}
