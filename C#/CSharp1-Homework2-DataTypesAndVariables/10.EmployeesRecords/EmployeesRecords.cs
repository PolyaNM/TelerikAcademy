//A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.


using System;

class EmployeesRecords
{
    static void Main()
    {
        string firstName = "Maria";
        string familyName = "Popova";
        byte age = 26;
        char gender = 'f';
        int idNumber = 563;
        ushort uniqueNumber = 1111;   // int and uint also can be used here

        Console.Write("Name of employee : ");
        Console.WriteLine(firstName + " " + familyName);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : {0}", gender);
        Console.WriteLine("ID Number: {0}", idNumber);
        Console.WriteLine("Unique Employee Number: {0}", 27560000 + uniqueNumber);
    }
}

