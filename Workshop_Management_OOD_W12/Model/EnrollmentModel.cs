using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Workshop_Management_OOD_W12
{
    class EnrollmentModel : IEnrollmentModel, IPersistentSerializeStorage
    {
        static private List<Enrollment> enrollments;
        static private bool hasBeenLoaded = false;
        private string filepath = "enrollments.bin";

        public EnrollmentModel()
        {
            try {
                if (enrollments == null && !hasBeenLoaded)
                {
                    enrollments = new List<Enrollment>();
                }
                if (!hasBeenLoaded) {
                    LoadData();
                    hasBeenLoaded = true;
                }
            }
            catch(Exception ex)
            {
                enrollments = new List<Enrollment>();
                hasBeenLoaded = true;
            }
        }

        public int ItemsCount => enrollments.Count;

        public Enrollment GetEnrollment(int enrollmentID)
        {
            foreach(Enrollment enrollment in enrollments)
            {
                if (enrollment.ID == enrollmentID)
                {
                    return enrollment;
                }
            }
            throw new Exception("Cannot find enrollment have similar ID");
        }
        public Enrollment[] GetEnrollments()
        {
            return enrollments.ToArray();
        }
        public void AddEnrollment(Enrollment enrollment)
        {
            enrollments.Add(enrollment);
            enrollments.Sort();
        }
        public void UpdateEnrollment(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }
        public void DeleteEnrollment(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }
        public void LoadData()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Read);
                enrollments = (List<Enrollment>)bf.Deserialize(fs);
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (fs != null) {
                    fs.Close();
                }
            }
        }
        public void SaveData() {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                bf.Serialize(fs, enrollments);
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
