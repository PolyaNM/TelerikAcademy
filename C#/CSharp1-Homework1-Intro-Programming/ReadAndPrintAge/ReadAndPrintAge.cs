using System;

// Write a program that reads your age from the console and prints your age after 10 years.

class ReadAndPrintAge
{
    static void Main()
    {
        Console.WriteLine("When is your birthday? Use this format --> dd/mm/yy");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        int yearsOld = DateTime.Now.Year - birthday.Year;
        int period = 10;
        int ageAfterTenYears = yearsOld + period;
        Console.WriteLine("You are {0} years old now. After 10 years you will be {1} years old.", yearsOld, ageAfterTenYears);
    }
}

