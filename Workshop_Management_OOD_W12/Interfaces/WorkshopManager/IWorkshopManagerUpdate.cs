using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public interface IWorkshopManagerUpdate
    {
        void AddStudentToWorkshop(int workshopID, Student student);
        void MarkWorkshopStart(int workshopID);
        void UpdateOnlineWorkshop(int workshopID, string title, int newCapacity, string description, string url);
        void UpdateInBuildingWorkshop(int workshopID, string title, int newCapacity, string description, string address, string room);
    }
}
