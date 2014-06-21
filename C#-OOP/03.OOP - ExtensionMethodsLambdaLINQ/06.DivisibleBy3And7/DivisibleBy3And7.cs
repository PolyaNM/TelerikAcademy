namespace DivisibleBy3And7
{
    using System;
    using System.Linq;
    class DivisibleBy3And7
    {
        static void Main()
        {
            int[] numbers = new int[] { 7, 21, 15, 77, 210, 42, 567, 375, 231, 189 };

            Console.WriteLine("Lambda : ");
            Console.WriteLine();
            var divisableBy3and7Lambda = numbers.Where(x => x % 21 == 0);

            foreach (var item in divisableBy3and7Lambda)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("LINQ : ");
            Console.WriteLine();
            var divisableBy3and7LINQ = from num in numbers
                                        where num % 21 == 0
                                        select num;

            foreach (var item in divisableBy3and7LINQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
