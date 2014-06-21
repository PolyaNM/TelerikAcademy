namespace SchoolProject
{
    using System;
    class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numLectures, int numExcercises)
        {
            this.Name = name;
            this.NumberOfLectures = numLectures;
            this.NumberOfExercises = numExcercises;
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
                    throw new ArgumentException("The name can not be null or empty!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of lectures cannot be < 0!");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of excercises cannot be < 0!");
                }
                this.numberOfExercises = value;
            }
        }

        public string Comments
        {
            get;
            set;
        }
    }
}
