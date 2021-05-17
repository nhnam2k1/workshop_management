using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public class WorkshopManager : IWorkshopManager
    {
        private IWorkshopModel workshopModel;
        private InputValidation inputValidation;
        public static event WarningCapacityHandle HandleWarningCapacity;

        public WorkshopManager(IWorkshopModel workshopModel)
        {
            this.workshopModel = workshopModel;
            inputValidation = new InputValidation();
        }
        public void AddInBuildingWorkshop(string title, string description, int maximumCapacity, Teacher teacher, string address, string roomNr)
        {
            inputValidation.ValidateWorkshopTitle(title);
            inputValidation.ValidateAddress(address);
            inputValidation.ValidateRoom(roomNr);
            int id = ((IPersistentSerializeStorage)workshopModel).ItemsCount;
            DateTime now = DateTime.Now;
            InBuildingWorkshop inBuildingWorkshop = new InBuildingWorkshop(id, title, description, maximumCapacity, 
                                                                           now, teacher, address, roomNr);
            workshopModel.AddWorkshop(inBuildingWorkshop);
        }
        public void AddOnlineWorkshop(string title, string description, int maximumCapacity, Teacher teacher, string url)
        {
            inputValidation.ValidateWorkshopTitle(title);
            inputValidation.ValidateURL(url);
            int id = ((IPersistentSerializeStorage)workshopModel).ItemsCount;
            DateTime now = DateTime.Now;
            OnlineWorkshop onlineWorkshop = new OnlineWorkshop(id, title, description, maximumCapacity,
                                                               now, teacher, url);
            workshopModel.AddWorkshop(onlineWorkshop);
        }
        public void UpdateOnlineWorkshop(int workshopID, string title, int newCapacity, string description, string url)
        {
            OnlineWorkshop onlineWorkshop = (OnlineWorkshop)workshopModel.GetWorkshop(workshopID);
            inputValidation.ValidateWorkshopTitle(title);
            inputValidation.ValidateURL(url);
            if (onlineWorkshop.HasStarted)
            {
                throw new Exception("Cannot update the started workshop");
            }
            onlineWorkshop.Title = title;
            onlineWorkshop.MaximumCapacity = newCapacity;
            onlineWorkshop.Description = description;
            onlineWorkshop.URL = url;
        }
        public void UpdateInBuildingWorkshop(int workshopID, string title, int newCapacity, string description, string address, string room)
        {
            InBuildingWorkshop inBuildingWorkshop = (InBuildingWorkshop)workshopModel.GetWorkshop(workshopID);
            inputValidation.ValidateWorkshopTitle(title);
            inputValidation.ValidateAddress(address);
            inputValidation.ValidateRoom(room);
            if (inBuildingWorkshop.HasStarted)
            {
                throw new Exception("Cannot update the started workshop");
            }
            inBuildingWorkshop.Title = title;
            inBuildingWorkshop.MaximumCapacity = newCapacity;
            inBuildingWorkshop.Description = description;
            inBuildingWorkshop.Address = address;
            inBuildingWorkshop.Room = room;
        }
        public void AddStudentToWorkshop(int workshopID, Student student)
        {
            Workshop workshop = workshopModel.GetWorkshop(workshopID);
            workshop.AddStudent(student);
            
            if (workshop.StudentsCount >= workshop.MaximumCapacity * 0.9)
            {
                if (HandleWarningCapacity != null)
                {
                    string title = workshop.Title;
                    string message = $"{title} has almost full, please check the registration";
                    HandleWarningCapacity(message);
                }
            }
        }
        public Workshop GetWorkshop(int workshopID)
        {
            return workshopModel.GetWorkshop(workshopID);
        }
        public Workshop[] GetWorkshops()
        {
            return workshopModel.GetWorkshops();
        }
        public void RemoveWorkshop(int workshopID)
        {
            Workshop workshop = workshopModel.GetWorkshop(workshopID); 
            if (workshop.HasStarted)
            {
                throw new Exception("This workkshop has been started, cannot remove");
            }
            workshopModel.RemoveWorkshop(workshop);
        }
        public void MarkWorkshopStart(int workshopID)
        {
            Workshop workshop = workshopModel.GetWorkshop(workshopID);
            if (workshop.HasStarted)
            {
                throw new Exception("This workshop has been started already");
            }
            workshop.HasStarted = true;
        }
    }
}
