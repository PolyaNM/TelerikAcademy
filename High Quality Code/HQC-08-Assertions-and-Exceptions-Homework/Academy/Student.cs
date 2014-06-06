namespace Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("First name cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Last name cannot be null or empty.");
            }

            if (exams == null)
            {
                throw new ArgumentNullException("List of exams cannot be null.");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public IList<Exam> Exams
        {
            get;
            set;
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new ArgumentException("Wow! Error happened!!!");
            }

            if (this.Exams.Count == 0)
            {
                Console.WriteLine("The student has no exams!");
                return null;
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                // Cannot calculate average on missing exams
                throw new Exception();
            }

            if (this.Exams.Count == 0)
            {
                // No exams --> return -1;
                return -1;
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}