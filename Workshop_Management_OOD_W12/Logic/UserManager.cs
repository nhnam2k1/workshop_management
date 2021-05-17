using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    public class UserManager : IUserManager
    {
        private IUserModel userModel;
        private InputValidation inputValidation;
        public UserManager(IUserModel userModel)
        {
            this.userModel = userModel;
            inputValidation = new InputValidation();
        }
        public void CreateStudent(string pcn, string firstName, string lastName, string email, DateTime birthdate)
        {
            inputValidation.ValidatePCN(pcn);
            inputValidation.ValidateName(firstName);
            inputValidation.ValidateName(lastName);
            inputValidation.ValidateEmail(email);
            inputValidation.ValidateBirthdate(birthdate);

            Student student = new Student(pcn, firstName, lastName, email, birthdate);
            userModel.AddUser(student);
        }

        public void CreateTeacher(string pcn, string firstName, string lastName, string email, DateTime birthdate)
        {
            inputValidation.ValidatePCN(pcn);
            inputValidation.ValidateName(firstName);
            inputValidation.ValidateName(lastName);
            inputValidation.ValidateEmail(email);
            inputValidation.ValidateBirthdate(birthdate);

            Teacher teacher = new Teacher(pcn, firstName, lastName, email, birthdate);
            userModel.AddUser(teacher);
        }

        public Student[] GetStudents()
        {
            List<Student> students = new List<Student>();
            User[] users = userModel.GetUsers();

            foreach(User user in users)
            {
                if (user is Student)
                {
                    students.Add((Student)user);
                }
            }
            return students.ToArray();
        }

        public Teacher[] GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            User[] users = userModel.GetUsers();

            foreach (User user in users)
            {
                if (user is Teacher)
                {
                    teachers.Add((Teacher)user);
                }
            }
            return teachers.ToArray();
        }

        public User GetUser(string pcn)
        {
            inputValidation.ValidatePCN(pcn);
            return userModel.GetUser(pcn);
        }

        public User[] GetUsers()
        {
            return userModel.GetUsers();
        }

        public void RemoveUser(string pcn)
        {
            inputValidation.ValidatePCN(pcn);
            User user = userModel.GetUser(pcn);
            userModel.RemoveUser(user);
        }

        public void UpdateUser(string pcn, string firstName, string lastName, string email)
        {
            inputValidation.ValidateName(firstName);
            inputValidation.ValidateName(lastName);
            inputValidation.ValidateEmail(email);

            User user = userModel.GetUser(pcn);
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = email;
        }
    }
}
