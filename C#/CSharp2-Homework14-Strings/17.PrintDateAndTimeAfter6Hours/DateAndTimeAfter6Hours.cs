// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;

class DateAndTimeAfter6Hours
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter date and time in this format - day.month.year hour:minute:second");
            DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture.DateTimeFormat);
            dateTime = dateTime.AddHours(6.5);

            Console.WriteLine("{0} {1}", dateTime.ToString("dddd", new CultureInfo("bg-BG")), dateTime);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date format");
        }
    }
}
