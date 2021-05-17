using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    [Serializable]
    public class User : IObjectComparision<User>
    {
        protected string pcn;
        protected string firstName;
        protected string lastName;
        protected string email;
        protected DateTime birthdate;

        public string PCN { get { return pcn; } }
        public string FirstName { 
            get { return firstName; } 
            set {
                firstName = value;
            } 
        }
        public string LastName { 
            get { return lastName; } 
            set {
                lastName = value;
            } 
        }
        public string Email { 
            get { return email; }
            set {
                email = value;
            }
        }
        public DateTime Birthdate { 
            get { return birthdate; }
            set {
                birthdate = value;
            }
        }
        public User(string pcn, string firstName, string lastName, string email, DateTime birthdate)
        {
            this.pcn = pcn.Trim();
            this.firstName = firstName.Trim();
            this.lastName = lastName.Trim();
            this.email = email.Trim();
            this.birthdate = birthdate;
        }
        public int CompareTo(User other)
        {
            return pcn.CompareTo(other.pcn);
        }

        public bool Equals(User other)
        {
            if (other == null)
            {
                return false;
            }
            return pcn.Equals(other.pcn);
        }
    }
}
