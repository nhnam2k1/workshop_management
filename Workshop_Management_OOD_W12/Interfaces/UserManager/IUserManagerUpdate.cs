using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public interface IUserManagerUpdate
    {
        void UpdateUser(string pcn, string firstName, string lastName, string email);
    }
}
