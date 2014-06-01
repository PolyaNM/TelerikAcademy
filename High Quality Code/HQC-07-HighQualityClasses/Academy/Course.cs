using System.Collections.Generic;
namespace Academy
{
    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        protected Course(string name)
        {

            this.Name = name;
        }

        protected Course(string name, string teacherName) : this(name)
        {

            this.TeacherName = teacherName;
        }

        protected Course(string name, string teacherName, IList<string> students) : this(name, teacherName)
        {
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Teacher name cannot be null or empty.");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value != null)
                {
                    this.students = new List<string>(); 
                    foreach (var student in value)
                    {
                        this.students.Add(student);
                    }
                }
                else
                {
                    return this.students = null; 
                }

            }
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name = {0}", this.Name);

            if (this.TeacherName != null)
            {
                result.AppendFormat("; Teacher = {0}", this.TeacherName);
            }

            result.AppendFormat("; Students = {0}", this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
