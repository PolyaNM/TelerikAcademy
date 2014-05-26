// Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberOfWorkdays
{
    //official holidays
    static DateTime[] holidays = { new DateTime(2014, 1, 1), new DateTime(2014, 3, 3), new DateTime(2014, 5, 1), new DateTime(2014, 5, 6), new DateTime(2014, 5, 24), new DateTime(2014, 9, 6), new DateTime(2014, 9, 22), new DateTime(2014, 11, 1), new DateTime(2014, 1, 1), new DateTime(2014, 12, 24), new DateTime(2014, 12, 25) };

    static int CountWorkDays(DateTime startDate, DateTime endDate, int lengthOfPeriod)
    {
        int workdaysCount = 0;
        bool isHoliday = false;

        for (int i = 0; i < lengthOfPeriod; i++)
        {
            startDate.AddDays(i);
            if (startDate.DayOfWeek != DayOfWeek.Saturday || startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDate == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }
                if (isHoliday == false) // if(!isHoliday)
                {
                    workdaysCount++;
                }
            }
        }
        return workdaysCount;
    }

    static void Main()
    {
        DateTime startDate = DateTime.Today;
        Console.WriteLine("Enter a date in this fomat: DD/MM/YY");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        //DateTime endDate = new DateTime(2014, 3, 7); //- TEST
        int lengthOfPeriod = Math.Abs((startDate - endDate).Days);
        Console.WriteLine(lengthOfPeriod);
        //check if startDate is before OR after the endDate. If it is after - we`ll switch them;
        if (startDate > endDate)
        {
            startDate = endDate;
            endDate = DateTime.Today;
        }

        //output
        int workdaysCount = CountWorkDays(startDate, endDate, lengthOfPeriod);
        Console.WriteLine("The number of workdays between {0} and {1} is {2}", startDate, endDate, workdaysCount);
    }
}

/*
 * class NumberOfWorkdays
{
    // All credit for this solution goes to Umer Umar (a.k.a. flyer87)
    static int WorkingDaysUntil(DateTime endDate)
    {
        int currentYear = DateTime.Now.Year;

        List<DateTime> holidays = new List<DateTime>() {
            new DateTime(currentYear, 1, 1),
            new DateTime(currentYear, 3, 3),
            new DateTime(currentYear, 5, 1),
            new DateTime(currentYear, 5, 2),
            new DateTime(currentYear, 5, 6),
            new DateTime(currentYear, 5, 24),
            new DateTime(currentYear, 9, 22),
            new DateTime(currentYear, 12, 24),
            new DateTime(currentYear, 12, 25),
            new DateTime(currentYear, 12, 26),
            new DateTime(currentYear, 12, 31)
        };

        int workingdays = 0;
        for (DateTime date = DateTime.Today; date <= endDate; date = date.AddDays(1))
        {
            if ((date.DayOfWeek != DayOfWeek.Saturday) && (date.DayOfWeek != DayOfWeek.Sunday) && (holidays.IndexOf(date) == -1))
            {
                workingdays++;
            }
        }

        return workingdays;
    }

    static void Main()
    {
        Console.WriteLine(WorkingDaysUntil(DateTime.Parse("25.02.2014")));
    }
} */


