using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    [Serializable]
    public class Teacher : User
    {
        public Teacher(string pcn, string firstName, string lastName, string email, DateTime birthdate) :
            base(pcn, firstName, lastName, email, birthdate)
        {

        }
    }
}
