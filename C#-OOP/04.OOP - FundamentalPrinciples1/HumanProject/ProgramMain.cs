namespace HumanProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ProgramMain
    {
        static void Main()
        {
            //Initialize an array of 10 students and sort them by grade in ascending order.
            List<Student> students = new List<Student>()
            { 
                new Student( "Maria","Popova", 8 ),
                new Student( "Aneta","Valentinova", 3 ),
                new Student( "Rui","Samov", 3 ),
                new Student( "Penka","Hristova", 6 ),
                new Student( "Ivan","Kalinov", 5 ),
                new Student( "Joro","Hristov", 8 ),
                new Student( "Boyko","Penev", 2 ),
                new Student( "Vladislav","Petkov", 1 ),
                new Student( "Magdalena","Stoykova", 10 ),
                new Student( "Iliya","Hristov", 6 )
            };

            Console.WriteLine("List of students:");
            Console.WriteLine(new string('-', 50));

            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}, grade {2}", student.FirstName, student.LastName, student.Grade);
            }

            students = students.OrderBy(student => student.Grade).ToList();

            Console.WriteLine();
            Console.WriteLine("Students sorted by grade in ascending order");
            Console.WriteLine(new string('-', 50));

            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}, grade {2}", student.FirstName, student.LastName, student.Grade);
            }


            //Initialize an array of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>()
            { 
                new Worker( "Milena","Pavlova", 8, 500 ),
                new Worker( "Anton","Valentinov", 7, 700 ),
                new Worker( "Rado","Stoev", 7, 1000 ),
                new Worker( "Petya","Hristolova", 8, 500 ),
                new Worker( "Ivo","Kotev", 9, 900 ),
                new Worker( "Joro","Mikov", 8, 700 ),
                new Worker( "Boyko","Penev", 7, 2000 ),
                new Worker( "Villy","Petkova", 8, 600 ),
                new Worker( "Magdalena","Stoykova", 10, 2500 ),
                new Worker( "Stoyko","Hristov", 6, 700 )
            };

            Console.WriteLine();
            Console.WriteLine("List of workers and their income per hour:");
            Console.WriteLine(new string('-', 50));

            foreach (var worker in workers)
            {
                Console.WriteLine("{0} {1} - {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            Console.WriteLine();
            Console.WriteLine("Workers sorted by their income per hour in descending order");
            Console.WriteLine(new string('-', 50));

            foreach (var worker in workers)
            {
                Console.WriteLine("{0} {1} - {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine();
            Console.WriteLine("Merged and sorted lists by first and last name");
            Console.WriteLine(new string('-', 50));

            var mergedLists = workers.Concat<Human>(students).ToList();
            mergedLists = mergedLists.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            foreach (var item in mergedLists)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
        }
    }
}
