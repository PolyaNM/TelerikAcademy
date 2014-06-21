
namespace StudentsByGroupName
{
    using System;
    public class Student
    {
        private string name;
        private string groupName;

        public Student(string studName, string studGroupName)
        {
            this.Name = studName;
            this.GroupName = studGroupName;
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
                    throw new ArgumentException("The neme of the student can't be null or empty!");
                }
                this.name = value;
            }
        }

        public string GroupName
        {
            get
            {
                return this.groupName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The group name of the student can't be null or empty!");
                }
                this.groupName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student {0} is in group {1}", this.Name, this.GroupName);
        }
    }
}
