namespace SchoolProject
{
    using System;
    public class Student : Person, ICommentable
    {
        private int classNumber;

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public string Comments
        {
            get;
            set;
        }
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Class number cannot be < 1");
                }
                this.classNumber = value;
            }
        }

    }
}
