namespace Students
{
    using System;
    using System.Linq;
    struct Student
    {
        public string FirstName
        {
            get;
            private set;
        }
        public string LastName
        {
            get;
            private set;
        }
        public byte Age
        {
            get;
            private set;
        }

        public Student(string firstName, string lastname, byte age)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Age = age;
        }
    }
    class TestStudent
    {
        static void Main()
        {
            Student[] students = new Student[] {new Student("Maria","Ignatova",18) ,
                                                new Student("Ivo", "Argirov" , 22),
                                                new Student("Ivo", "Milushev" , 21),
                                                new Student("Iva" ,"Stoykova" , 23),
                                                new Student ("Miroslav","Tsankov" , 30),
                                                new Student("Nayden" ,"Sitov" , 23)};

            //task 3 - Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            var names =
                from name in students
                where name.FirstName.CompareTo(name.LastName) == -1
                select name;

            Console.WriteLine("Students whose first name is before their last name alphabetically: ");
            Console.WriteLine();

            foreach (var n in names)
            {
                Console.WriteLine(n.FirstName + " " + n.LastName);
            }
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();

            //tast 4 - Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            var ages =
                from age in students
                where age.Age >= 18 && age.Age <= 24
                select age;

            Console.WriteLine("The students between 18 and 24 years are: ");
            Console.WriteLine();

            foreach (var a in ages)
            {
                Console.WriteLine("{0} {1} - {2} years old.", a.FirstName, a.LastName, a.Age);
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine();

            //task 5 - Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.
            Console.WriteLine("Students sorted by first and last name (Lambda) : ");
            var sortedStudentsDescending =
                students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            foreach (var item in sortedStudentsDescending)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();

            Console.WriteLine("Students sorted by first and last name (Linq) : ");
            var sortedStudentsDescendingLINQ =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var item in sortedStudentsDescendingLINQ)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine();
        }
    }
}
