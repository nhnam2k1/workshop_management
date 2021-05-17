using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public class EnrollmentManager : IEnrollmentManager
    {
        private IEnrollmentModel enrollmentModel;
        private readonly Random _random;
        public EnrollmentManager(IEnrollmentModel enrollmentModel)
        {
            this.enrollmentModel = enrollmentModel;
            _random = new Random();
        }
        public void AddInBuildingEnrollement(InBuildingWorkshop workshop, Student student)
        {
            int seat = workshop.Students.Length;
            int id = ((IPersistentSerializeStorage)enrollmentModel).ItemsCount;
            InBuildingEnrollment inBuildingEnrollment = new InBuildingEnrollment(id, student, workshop, seat);
            enrollmentModel.AddEnrollment(inBuildingEnrollment);
        }

        public void AddOnlineEnrollement(OnlineWorkshop workshop, Student student)
        {
            int length = 7;
            string loginCode = "";
            char offset = 'a';

            for (int i = 0; i < length; i++)
            {
                char c = (char)_random.Next(offset, offset + 26);
                loginCode += c;
            }
            int id = ((IPersistentSerializeStorage)enrollmentModel).ItemsCount;
            OnlineEnrollment inBuildingEnrollment = new OnlineEnrollment(id, student, workshop, loginCode);
            enrollmentModel.AddEnrollment(inBuildingEnrollment);
        }

        public Enrollment GetEnrollment(int enrollmentID)
        {
            return enrollmentModel.GetEnrollment(enrollmentID);
        }

        public Enrollment[] GetEnrollments()
        {
            return enrollmentModel.GetEnrollments();
        }
    }
}
