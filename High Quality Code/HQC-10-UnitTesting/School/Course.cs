namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {
        public const byte MaxStudentsCountInCourse = 29;

        private string name;

        public Course(string name, IList<Student> students = null)
        {
            this.Students = new List<Student>();
            this.Name = name;
        }

        public List<Student> Students
        {
            get;
            set;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != null && value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Name cannot be missing!");
                }
            }
        }

        public void AddStudent(Student student)
        {
            bool studentFound = this.CheckIfStudentIsFound(student);

            if (studentFound)
            {
                throw new ArgumentException("The student is already signed for this course!");
            }

            if (this.Students.Count + 1 <= MaxStudentsCountInCourse)
            {
                this.Students.Add(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The course is full. You cannot add more students!");
            }
        }

        public void RemoveStudent(Student student)
        {
            bool studentFound = this.CheckIfStudentIsFound(student);

            if (!studentFound)
            {
                throw new ArgumentException("No such student in this course, so you cannot remove him!");
            }

            this.Students.Remove(student);
        }

        private bool CheckIfStudentIsFound(Student student)
        {
            bool studentFound = false;
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].Id == student.Id)
                {
                    studentFound = true;
                }
            }

            return studentFound;
        }
    }
}