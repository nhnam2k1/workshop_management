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
    public partial class AddWorkshopForm : Form
    {
        private IWorkshopManagerCreate workshopManagerCreate;
        private IUserManagerGet userManagerGet;
        private Teacher[] teachers;
        public AddWorkshopForm(ref IWorkshopManagerCreate workshopManagerCreate, ref IUserManagerGet userManagerGet)
        {
            this.workshopManagerCreate = workshopManagerCreate;
            this.userManagerGet = userManagerGet;
            InitializeComponent();

            UpdateCbxTeachersList();
            UpdateCbxWorkshopType();
        }

        private void btnAddWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                WORKSHOP workshop = (WORKSHOP)cbxWorkshopType.SelectedIndex;
                string title = tbxTitle.Text;
                string description = tbxDescription.Text;
                int capacity = Convert.ToInt16(tbxCapacity.Text);
                Teacher teacher = teachers[cbxTeachers.SelectedIndex];
                switch (workshop)
                {
                    case WORKSHOP.ONLINE:
                        {
                            string url = tbxURL.Text;
                            workshopManagerCreate.AddOnlineWorkshop(title, description, capacity, teacher, url);
                            break;
                        }
                    case WORKSHOP.INBUILDING:
                        {
                            string address = tbxAddress.Text;
                            string roomNr = tbxRoom.Text;
                            workshopManagerCreate.AddInBuildingWorkshop(title, description, capacity, teacher, address, roomNr);
                            break;
                        }
                }
                MessageBox.Show($"Successful creating {workshop} workshop");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateCbxWorkshopType()
        {
            cbxWorkshopType.Items.Clear();
            foreach(WORKSHOP workshop in Enum.GetValues(typeof(WORKSHOP)))
            {
                cbxWorkshopType.Items.Add(workshop);
            }
            cbxWorkshopType.SelectedIndex = 0;
        }
        private void UpdateCbxTeachersList()
        {
            cbxTeachers.Items.Clear();
            teachers = userManagerGet.GetTeachers();
            if (teachers.Length == 0)
            {
                throw new Exception("There are not any teachers in the university");
            }
            foreach(Teacher user in teachers)
            {
                string name = $"{user.FirstName} {user.LastName}";
                cbxTeachers.Items.Add(name);
            }
            cbxTeachers.SelectedIndex = 0;
        }
        private void cbxWorkshopType_SelectedIndexChanged(object sender, EventArgs e)
        {
            WORKSHOP workshop = (WORKSHOP)cbxWorkshopType.SelectedIndex;

            switch (workshop)
            {
                case WORKSHOP.ONLINE:
                    {
                        tbxURL.Enabled = true;
                        tbxAddress.Enabled = false;
                        tbxRoom.Enabled = false;
                        break;
                    }
                case WORKSHOP.INBUILDING:
                    {
                        tbxURL.Enabled = false;
                        tbxAddress.Enabled = true;
                        tbxRoom.Enabled = true;
                        break;
                    }
            }
        }
    }
}
