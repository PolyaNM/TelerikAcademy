namespace Academy
{
    using System;

    public class ExamResult
    {
        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new ArgumentOutOfRangeException("Grade cannot be less than zero.");
            }

            if (minGrade < 0)
            {
                throw new ArgumentOutOfRangeException("Min grade cannot be negative.");
            }

            if (maxGrade < 0)
            {
                throw new ArgumentOutOfRangeException("Max grade cannot be negative.");
            }

            if (maxGrade < minGrade)
            {
                throw new ArgumentOutOfRangeException("Max grade cannot be less than min grade.");
            }

            if (grade < minGrade || grade > maxGrade)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Grade must be between {0} and {1}.", minGrade, maxGrade));
            }

            if (string.IsNullOrWhiteSpace(comments))
            {
                throw new ArgumentException("Comments cannot be null or empty.");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get;
            private set;
        }

        public int MinGrade
        {
            get;
            private set;
        }

        public int MaxGrade
        {
            get;
            private set;
        }

        public string Comments
        {
            get;
            private set;
        }
    }
}