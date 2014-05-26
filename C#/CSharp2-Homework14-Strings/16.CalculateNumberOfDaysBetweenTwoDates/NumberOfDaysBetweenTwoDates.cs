// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

using System;
using System.Globalization;

    class NumberOfDaysBetweenTwoDates
    {
        static void Main()
        {
            try
            {
                string format = "dd.MM.yyyy";
                Console.WriteLine("Please enter two dates in this format : dd.MM.yyyy");
                DateTime FirstDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture.DateTimeFormat);
                DateTime SecondDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture.DateTimeFormat);

                int days = Math.Abs((SecondDate - FirstDate).Days);
                Console.WriteLine("{0}", days);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }
    }
