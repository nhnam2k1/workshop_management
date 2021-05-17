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
    public partial class WorkshopUC : UserControl
    {
        private IWorkshopManager workshopManager;
        private IUserModel userModel;
        private IWorkshopModel workshopModel;
        private IUserManagerGet userManagerGet;
        private IPrintWorkshop printWorkshop;
        private WarningCapacityHandle warningToEnrollmentUC;
        private Workshop[] workshops;

        public WorkshopUC()
        {
            try {
                InitializeComponent();
                warningToEnrollmentUC = new WarningCapacityHandle(EnrollmentUC.HandleWarningMessage);
                workshopModel = new WorkshopModel();
                workshopManager = new WorkshopManager(workshopModel);
                userModel = new UserModel();
                userManagerGet = new UserManager(userModel);
                printWorkshop = new GeneratingTextFile();

                RefreshAllWorkshopList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkshopManagerCreate workshopManagerCreate = workshopManager;
                AddWorkshopForm addWorkshopForm = new AddWorkshopForm(ref workshopManagerCreate, ref userManagerGet);
                addWorkshopForm.ShowDialog();
                RefreshAllWorkshopList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdateWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkshopManagerUpdate workshopManagerUpdate = workshopManager;
                int workshopID = Convert.ToInt16(lvWorkshops.SelectedItems[0].Name);
                Workshop workshop = workshopManager.GetWorkshop(workshopID);
                ModifyWorkshopForm modifyWorkshopForm = new ModifyWorkshopForm(ref workshop, 
                                                     ref workshopManagerUpdate, ref userManagerGet);
                modifyWorkshopForm.ShowDialog();
                RefreshAllWorkshopList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRemoveWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                int workshopID = Convert.ToInt16(lvWorkshops.Name);
                workshopManager.RemoveWorkshop(workshopID);
                MessageBox.Show($"Workshop {workshopID} has been removed successfully");
                RefreshAllWorkshopList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnMarkStarted_Click(object sender, EventArgs e)
        {
            try
            {
                int workshopID = Convert.ToInt32(lvWorkshops.SelectedItems[0].Name);
                workshopManager.MarkWorkshopStart(workshopID);
                MessageBox.Show($"Workshop {workshopID} has been started from now");
                RefreshAllWorkshopList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGeneratingFile_Click(object sender, EventArgs e)
        {
            try
            {
                printWorkshop.PrintData(workshops);
                MessageBox.Show("Successful printing the file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbxSearchWorkshop_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Workshop> filterWorkshops = new List<Workshop>();
                string pattern = tbxSearchWorkshop.Text;
                foreach(Workshop workshop in workshops)
                {
                    if (workshop.Title.Contains(pattern))
                    {
                        filterWorkshops.Add(workshop);
                    }
                }
                UpdateWorkshopList(filterWorkshops.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void WorkshopUC_Enter(object sender, EventArgs e)
        {
            try
            {
                WorkshopManager.HandleWarningCapacity += warningToEnrollmentUC;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void WorkshopUC_Leave(object sender, EventArgs e)
        {
            try
            {
                if (userModel is IPersistentSerializeStorage)
                {
                    ((IPersistentSerializeStorage)userModel).SaveData();
                }
                if (workshopModel is IPersistentSerializeStorage)
                {
                    ((IPersistentSerializeStorage)workshopModel).SaveData();
                }
                WorkshopManager.HandleWarningCapacity -= warningToEnrollmentUC;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RefreshAllWorkshopList()
        {
            workshops = workshopManager.GetWorkshops();
            UpdateWorkshopList(workshops);
        }
        private void UpdateWorkshopList(Workshop[] workshops)
        {
            lvWorkshops.Items.Clear();
            foreach(Workshop workshop in workshops)
            {
                Teacher teacher = workshop.Teacher;
                string teacherName = $"{teacher.FirstName} {teacher.LastName}";
                ListViewItem lvi = new ListViewItem(workshop.ID.ToString());
                lvi.SubItems.Add(workshop.Title);
                lvi.SubItems.Add(workshop.CreatedDate.ToString());
                lvi.SubItems.Add(workshop.MaximumCapacity.ToString());
                lvi.SubItems.Add(teacherName);
                lvi.SubItems.Add(workshop.StudentsCount.ToString());
                lvi.SubItems.Add(workshop.HasStarted ? "V" : " ");
                lvi.SubItems.Add(workshop.Description);
                lvi.Name = workshop.ID.ToString();
                lvWorkshops.Items.Add(lvi);
            }
        }
    }
}
