using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    [Serializable]
    public class Enrollment : IObjectComparision<Enrollment>
    {
        protected int id;
        protected Student student;
        protected Workshop workshop;

        public int ID { get { return id; } }
        public Student Student { get { return student; } }
        public Workshop Workshop { get { return workshop; } } 
        public Enrollment(int id, Student student, Workshop workshop)
        {
            this.id = id;
            this.student = student;
            this.workshop = workshop;
        }
        public int CompareTo(Enrollment other)
        {
            return id.CompareTo(other.id);
        }
        public bool Equals(Enrollment other)
        {
            if (other == null)
            {
                return false;
            }
            return id.Equals(other.id);
        }
    }
}
