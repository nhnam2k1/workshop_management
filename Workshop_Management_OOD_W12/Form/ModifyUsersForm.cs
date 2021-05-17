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
    public partial class ModifyUsersForm : Form
    {
        private User user;
        private IUserManagerUpdate userManagerUpdate;
        public ModifyUsersForm(ref User user, ref IUserManagerUpdate userManagerUpdate)
        {
            this.user = user;
            this.userManagerUpdate = userManagerUpdate;

            InitializeComponent();

            UpdateCbxUserType();
            UpdateUserInfo();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = tbxFirstName.Text;
                string lastName = tbxLastName.Text;
                string email = tbxEmail.Text;

                userManagerUpdate.UpdateUser(user.PCN, firstName, lastName, email);
                MessageBox.Show("Successful update user");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateUserInfo()
        {
            tbxPCN.Text = user.PCN;
            tbxFirstName.Text = user.FirstName;
            tbxLastName.Text = user.LastName;
            tbxEmail.Text = user.Email;
            dtpBirthdate.Value = user.Birthdate;

            if (user is Student) cbxType.SelectedIndex = 0;
            else cbxType.SelectedIndex = 1;
        }
        private void UpdateCbxUserType()
        {
            cbxType.Items.Clear();
            foreach (USER user in Enum.GetValues(typeof(USER)))
            {
                cbxType.Items.Add(user);
            }
        }
    }
}
