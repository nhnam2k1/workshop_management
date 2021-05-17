using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Management_OOD_W12
{
    [Serializable]
    public class Workshop : IObjectComparision<Workshop>
    {
        protected int id;
        protected string title;
        protected string description;
        protected int maximumCapacity;
        protected Teacher teacher;
        protected DateTime createdDate;
        protected List<Student> students;
        protected bool hasStarted;
        public int ID { get { return id; } }
        public string Title { 
            get { return title; }
            set { title = value; }
        }
        public string Description { 
            get { return description; }
            set { description = value; }
        }
        public bool HasStarted { 
            get { return hasStarted; } 
            set { if (!hasStarted) hasStarted = value; } 
        }
        public int StudentsCount { get { return students.Count; } }
        public int MaximumCapacity { 
            get { return maximumCapacity; } 
            set { 
                if (value < students.Count)
                {
                    throw new Exception("The registered students has exceeded the new maximum capacity");
                }
                maximumCapacity = value; 
            }
        }
        public Teacher Teacher { get { return teacher; } }
        public DateTime CreatedDate { get { return createdDate; } }
        public Student[] Students { get { return students.ToArray(); } }
        public Workshop(int id, string title, string description, int maximumCapacity, DateTime createdDate, Teacher teacher)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.maximumCapacity = maximumCapacity;
            this.teacher = teacher;
            this.createdDate = createdDate;
            this.hasStarted = false;
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            if (students.Contains(student))
            {
                throw new Exception("This student has already registered for this workkshop");
            }
            if (hasStarted)
            {
                throw new Exception("Cannot add student since this workshop has been started");
            }
            if (students.Count == maximumCapacity)
            {
                throw new Exception("Cannot register students, has been reached capacity before");
            }
            students.Add(student);
        }
        public virtual string GetInfo()
        {
            string teacherName = $"{teacher.FirstName} {teacher.LastName}";
            string info = $"(Title: {title}, Description: {description}, Teacher : {teacherName}, Capacity : {maximumCapacity})";
            return info;
        }
        public int CompareTo(Workshop other)
        {
            return id.CompareTo(other.id);
        }

        public bool Equals(Workshop other)
        {
            if (other == null)
            {
                return false;
            }
            return id.Equals(other.id);
        }
    }
}
