using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public interface IEnrollmentManagerGet
    {
        Enrollment GetEnrollment(int enrollmentID);
        Enrollment[] GetEnrollments();
    }
}
