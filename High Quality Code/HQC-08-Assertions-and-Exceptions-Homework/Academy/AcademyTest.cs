namespace Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AcademyTest
    {
        public static void Main(string[] args)
        {
            try
            {

                List<Exam> peterExams = new List<Exam>()
                {
                    new SimpleMathExam(2),
                    new CSharpExam(55),
                    new CSharpExam(100),
                    new SimpleMathExam(1),
                    new CSharpExam(0),
                };

                Student peter = new Student("Peter", "Petrov", peterExams);
                double peterAverageResult = peter.CalcAverageExamResultInPercents();
                Console.WriteLine("Average results = {0:p0}", peterAverageResult);
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
                Console.WriteLine(aoorex.Message);
            }
            catch (ArgumentNullException anex)
            {
                Console.WriteLine(anex.Message);
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }
        }
    }
}
