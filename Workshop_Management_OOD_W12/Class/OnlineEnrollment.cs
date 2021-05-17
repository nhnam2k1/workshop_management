using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    [Serializable]
    public class OnlineEnrollment : Enrollment
    {
        private string loginCode;
        public string LoginCode { get { return loginCode; } }
        public OnlineEnrollment(int id, Student student, OnlineWorkshop workshop, string loginCode) :
            base(id, student, workshop)
        {
            this.loginCode = loginCode;
        }
    }
}
