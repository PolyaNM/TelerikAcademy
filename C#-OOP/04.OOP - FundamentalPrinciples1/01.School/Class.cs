namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    class Class : ICommentable
    {
        private List<Teacher> teachers;
        private string textID;

        public Class(string textId, params Teacher[] teachers)
        {
            this.TextID = textId;
            this.teachers = new List<Teacher>(teachers);
        }

        public string TextID
        {
            get
            {
                return this.textID;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Text Identifier for the class cannot be null or empty!");
                }
                this.textID = value;
            }
        }

        public Teacher[] Teachers
        {
            get
            {
                return this.teachers.ToArray();
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (!this.teachers.Contains(teacher))
            {
                throw new ArgumentException("No such teacher in this class found");
            }
            this.teachers.Remove(teacher);
        }

        public string Comments
        {
            get;
            set;
        }
    }
}
