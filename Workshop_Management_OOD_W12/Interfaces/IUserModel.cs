using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public interface IUserModel
    {
        User GetUser(string pcn);
        User[] GetUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void RemoveUser(User user);
    }
}
