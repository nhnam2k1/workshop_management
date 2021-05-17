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
    public partial class ModifyWorkshopForm : Form
    {
        private Workshop workshop;
        private IWorkshopManagerUpdate workshopManagerUpdate;
        private IUserManagerGet userManagerGet;
        private IEnrollmentModel enrollmentModel;
        private IEnrollmentManagerCreate enrollmentManagerCreate;
        public ModifyWorkshopForm(ref Workshop workshop, ref IWorkshopManagerUpdate workshopManagerUpdate, 
                                  ref IUserManagerGet userManagerGet)
        {
            this.workshopManagerUpdate = workshopManagerUpdate;
            this.workshop = workshop;
            this.userManagerGet = userManagerGet;

            enrollmentModel = new EnrollmentModel();
            enrollmentManagerCreate = new EnrollmentManager(enrollmentModel);
            InitializeComponent();

            UpdateCbxWorkshopType();
            ShowWorkshopInfo();
            UpdateAvailableStudentList();
        }

        private void btnUpdateWorkshop_Click(object sender, EventArgs e)
        {
            try {
                string title = tbxTitle.Text;
                int capacity = Convert.ToInt32(tbxCapacity.Text);
                string description = tbxDescription.Text;

                if (workshop is OnlineWorkshop)
                {
                    string url = tbxURL.Text;
                    workshopManagerUpdate.UpdateOnlineWorkshop(workshop.ID, title, capacity, 
                                                               description, url);
                }
                else if (workshop is InBuildingWorkshop)
                {
                    string address = tbxAddress.Text;
                    string room = tbxRoom.Text;
                    workshopManagerUpdate.UpdateInBuildingWorkshop(workshop.ID, title, capacity, 
                                          description, address, room);
                }
                MessageBox.Show($"Successful update {workshop.ID} info");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  
        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            try {
                string pcn = lvStudentsHasNotRegistered.SelectedItems[0].Name;
                Student student = (Student)userManagerGet.GetUser(pcn);
                workshopManagerUpdate.AddStudentToWorkshop(workshop.ID, student);
                if (workshop is OnlineWorkshop)
                {
                    enrollmentManagerCreate.AddOnlineEnrollement((OnlineWorkshop)workshop, student);
                }
                else
                {
                    enrollmentManagerCreate.AddInBuildingEnrollement((InBuildingWorkshop)workshop, student);
                }
                MessageBox.Show($"Successful register student {student.PCN} to this workshop");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ModifyWorkshopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (enrollmentModel is IPersistentSerializeStorage)
                {
                    ((IPersistentSerializeStorage)enrollmentModel).SaveData();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void UpdateAvailableStudentList()
        {
            // This is why compare string is a bad idea, first time went deeping like this...
            //https://stackoverflow.com/questions/45034482/c-sharp-string-equals-returns-false-on-identical-strings
            lvStudentsHasNotRegistered.Items.Clear();
            Student[] students = userManagerGet.GetStudents();
            List<Student> registeredStudent = workshop.Students.ToList();

            foreach(Student student in students) {
                if (!registeredStudent.Contains(student))
                {
                    string name = $"{student.FirstName} {student.LastName}";
                    ListViewItem lvi = new ListViewItem(student.PCN);
                    lvi.SubItems.Add(name);
                    lvi.Name = student.PCN;
                    lvStudentsHasNotRegistered.Items.Add(lvi);
                }    
            }
        }
        private void UpdateCbxWorkshopType()
        {
            cbxWorkshopType.Items.Clear();
            foreach (WORKSHOP workshop in Enum.GetValues(typeof(WORKSHOP)))
            {
                cbxWorkshopType.Items.Add(workshop);
            }
            cbxWorkshopType.SelectedIndex = 0;
        }
        private void ShowWorkshopInfo()
        {
            cbxWorkshopType.Enabled = false;
            cbxWorkshopType.SelectedIndex = (workshop is OnlineWorkshop) ? 0 : 1;
            tbxTitle.Text = workshop.Title;
            tbxCapacity.Text = workshop.MaximumCapacity.ToString();
            tbxDescription.Text = workshop.Description;
            Teacher teacher = workshop.Teacher;
            string name = $"{teacher.FirstName} {teacher.LastName}";
            cbxTeachers.Items.Add(name);
            cbxTeachers.SelectedIndex = 0;

            if (workshop is OnlineWorkshop)
            {
                tbxURL.Enabled = true;
                tbxURL.Text = ((OnlineWorkshop)workshop).URL;
                tbxAddress.Enabled = false;
                tbxRoom.Enabled = false;
            }
            else if (workshop is InBuildingWorkshop)
            {
                tbxURL.Enabled = false;
                tbxAddress.Enabled = true;
                tbxRoom.Enabled = true;
                tbxRoom.Text = ((InBuildingWorkshop)workshop).Room;
                tbxAddress.Text = ((InBuildingWorkshop)workshop).Address;
            }
        }
    }
}
