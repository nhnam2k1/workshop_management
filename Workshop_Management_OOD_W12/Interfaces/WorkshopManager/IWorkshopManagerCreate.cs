using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public interface IWorkshopManagerCreate
    {
        void AddOnlineWorkshop(string title, string description, int maximumCapacity, Teacher teacher, string url);
        void AddInBuildingWorkshop(string title, string description, int maximumCapacity, Teacher teacher, string address, string roomNr);
    }
}
