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
    public partial class UserUC : UserControl
    {
        private IUserModel userModel;
        private IUserManager userManager;
        private User[] users;
        public UserUC()
        {
            try
            {
                InitializeComponent();
                userModel = new UserModel();
                userManager = new UserManager(userModel);
                users = userManager.GetUsers();
                UpdateUserToList(users);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddUserForm_Click(object sender, EventArgs e)
        {
            try
            {
                IUserManagerCreate userManagerCreate = userManager;
                AddUserForm addUserForm = new AddUserForm(ref userManagerCreate);
                addUserForm.ShowDialog();
                users = userManager.GetUsers();
                UpdateUserToList(users);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateUserForm_Click(object sender, EventArgs e)
        {
            try
            {
                IUserManagerUpdate userManagerUpdate = userManager;
                string pcn = lvUsers.SelectedItems[0].Name;
                User user = userManager.GetUser(pcn);
                ModifyUsersForm modifyUsersForm = new ModifyUsersForm(ref user, ref userManagerUpdate);
                modifyUsersForm.ShowDialog();
                users = userManager.GetUsers();
                UpdateUserToList(users);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbxSearchUser_TextChanged(object sender, EventArgs e)
        {
            List<User> filterUsers = new List<User>();
            string pattern = tbxSearchUser.Text;

            foreach(User user in users)
            {
                string name = $"{user.FirstName} {user.LastName}";
                if (name.Contains(pattern))
                {
                    filterUsers.Add(user);
                }
            }
            UpdateUserToList(filterUsers.ToArray());
        }

        private void UserUC_Enter(object sender, EventArgs e)
        {
            //if (userModel is IPersistentSerializeStorage)
            //{
            //    ((IPersistentSerializeStorage)userModel).LoadData();
            //}
        }
        private void UserUC_Leave(object sender, EventArgs e)
        {
            if (userModel is IPersistentSerializeStorage)
            {

                ((IPersistentSerializeStorage)userModel).SaveData();
            }
        }
        private void UpdateUserToList(User[] users)
        {
            lvUsers.Items.Clear();

            foreach(User user in users)
            {
                ListViewItem lvi = new ListViewItem(user.PCN);
                lvi.SubItems.Add(user.FirstName);
                lvi.SubItems.Add(user.LastName);
                lvi.SubItems.Add(user.Email);
                lvi.SubItems.Add(user.Birthdate.ToShortDateString());
                lvi.SubItems.Add((user is Teacher) ? "V" : " ");
                lvi.Name = user.PCN;
                lvUsers.Items.Add(lvi);
            }
            UpdateStatusInfo();
        }
        private void UpdateStatusInfo()
        {
            lblTotalUsers.Text = users.Length.ToString();
            lblTotalStudents.Text = userManager.GetStudents().Length.ToString();
            lblTotalTeachers.Text = userManager.GetTeachers().Length.ToString();
        }
    }
}
