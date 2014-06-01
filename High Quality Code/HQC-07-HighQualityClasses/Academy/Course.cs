namespace Academy
{
    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Teacher name cannot be null or empty.");
                }

                this.name = value;
            }
        }

    }
}
