using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public interface IWorkshopModel
    {
        Workshop GetWorkshop(int workshopID);
        Workshop[] GetWorkshops();
        void AddWorkshop(Workshop workshop);
        void UpdateWorkshop(Workshop workshop);
        void RemoveWorkshop(Workshop workshop);
    }
}
