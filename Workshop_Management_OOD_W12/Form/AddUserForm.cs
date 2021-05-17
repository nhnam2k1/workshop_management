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
    public partial class AddUserForm : Form
    {
        private IUserManagerCreate userManagerCreate;
        public AddUserForm(ref IUserManagerCreate userManagerCreate)
        {
            this.userManagerCreate = userManagerCreate;
            InitializeComponent();
            foreach (USER user in Enum.GetValues(typeof(USER)))
            {
                cbxType.Items.Add(user);
            }
            cbxType.SelectedIndex = 0;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                USER userType = (USER)cbxType.SelectedIndex;
                string pcn = tbxPCN.Text;
                string firstName = tbxFirstName.Text;
                string lastName = tbxLastName.Text;
                string email = tbxEmail.Text;
                DateTime birthDate = dtpBirthdate.Value;

                switch (userType)
                {
                    case USER.STUDENT:
                        {
                            userManagerCreate.CreateStudent(pcn, firstName, lastName, email, birthDate);
                            break;
                        }
                    case USER.TEACHER:
                        {
                            userManagerCreate.CreateTeacher(pcn, firstName, lastName, email, birthDate);
                            break;
                        }
                }

                MessageBox.Show($"Successful creating new {userType.ToString()}");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
