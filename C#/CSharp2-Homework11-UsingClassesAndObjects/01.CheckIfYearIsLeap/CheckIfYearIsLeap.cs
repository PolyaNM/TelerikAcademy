// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

    class CheckIfYearIsLeap
    {
        static void Main()
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is NOT a leap year.", year);
            }
        }
    }
