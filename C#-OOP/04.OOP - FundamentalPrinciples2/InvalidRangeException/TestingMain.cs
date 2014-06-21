namespace InvalidRangeException
{
    using System;
    using System.Globalization;
    class TestingMain
    {
        static void Main()
        {
            int startPoint = 1;
            int endPoint = 100;

            int inputPoint;
            Console.WriteLine("Enter a point between 1 and 100(integer number)");

            try
            {
                inputPoint = int.Parse(Console.ReadLine());
                if ((inputPoint < startPoint) || (inputPoint > endPoint))
                {
                    throw new InvalidRangeException<int>("The entered point is NOT within the specified range!", startPoint, endPoint);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }


            //DATE TIME
            DateTime startDate = new DateTime(1987, 11, 14);
            DateTime endDate = DateTime.Now;

            DateTime dateTime;
            CultureInfo provider = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter a date between 11/14/1987 and Now.(Format : 06/18/2013 : month/day/year )");

            try
            {
                dateTime = DateTime.ParseExact(Console.ReadLine(), "d", provider);
                if ((dateTime < startDate) || (dateTime > endDate))
                {
                    throw new InvalidRangeException<DateTime>("The date is not within the specified range!", startDate, endDate);
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
