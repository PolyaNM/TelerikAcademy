
namespace StudentsByGroupName
{
    using System;
    using System.Linq;
    public class Tester
    {
        static Student[] students;

        private static void GroupByGroupNameWithLinq()
        {
            //Linq
            Console.WriteLine("Group with LINQ : ");
            Console.WriteLine(new string('-', 40));

            var orderedStudentsLinq = from st in students
                                      orderby st.GroupName
                                      select st;

            foreach (var student in orderedStudentsLinq)
            {
                Console.WriteLine(student);
            }
        }

        private static void GroupByGroupNameWithExtension()
        {
            //Extension method
            Console.WriteLine("Extension Methods : ");
            Console.WriteLine(new string('-', 40));

            var orderedStudentsExt = students.OrderByGroupName();

            foreach (var student in orderedStudentsExt)
            {
                Console.WriteLine(student);
            }
        }

        static void Main()
        {
            students = new Student[]
            {
                new Student("Maria Apostolova", "Ond"),
                new Student("Simon Stavrev", "Tes"),
                new Student("Penka Naumova", "Ond"),
                new Student("Ivet Lalova", "Fifa"),
                new Student("Zapryan Stoev", "Ond"),
                new Student("Margarita Petrova", "Tes")
            };

            GroupByGroupNameWithLinq();
            Console.WriteLine();
            GroupByGroupNameWithExtension();
        }

    }
}
