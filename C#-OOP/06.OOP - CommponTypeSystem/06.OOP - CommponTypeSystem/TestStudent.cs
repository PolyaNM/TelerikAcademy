using System;
class TestStudent
{
    static void Main()
    {
        var firstStudent = new Student("Ivan", "Penev", "Grigorov", 592387529, "Sofia", "0877374771", "ivan@abv.bg", "Business", Specialty.BusinessAdministration, Faculty.ManagementFaculty, University.UNWE);

        Console.WriteLine(firstStudent.ToString());


        var secondStudent = new Student("Ivan", "Mikov", "Mitev", 5794874, "Sofia", "0257687", "ivans@abv.bg", "Iconomics", Specialty.Marketing, Faculty.ManagementFaculty, University.UNWE);

        Console.WriteLine(firstStudent.CompareTo(secondStudent)); // Mikov is before Penev => 1

        var clonedStudent = secondStudent.Clone();
        clonedStudent.FirstName = "Dragan";
        Console.WriteLine("Cloned student with changed first name --> {0}", clonedStudent.FirstName);
        Console.WriteLine("Original of the cloned student --> {0}", firstStudent.FirstName);

    }
}