using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public interface IUserManagerGet
    {
        User GetUser(string pcn);
        User[] GetUsers();
        Teacher[] GetTeachers();
        Student[] GetStudents();
    }
}
