using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    [Serializable]
    public class InBuildingEnrollment : Enrollment
    {
        private int seat;
        public int Seat { get { return seat; } }
        public InBuildingEnrollment(int id, Student student, InBuildingWorkshop workshop, int seat):
            base(id, student, workshop)
        {
            this.seat = seat;
        }
    }
}
