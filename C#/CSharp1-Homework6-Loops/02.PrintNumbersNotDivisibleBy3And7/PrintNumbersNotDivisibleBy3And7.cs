// Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class PrintNumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number");
        int numberN = int.Parse(Console.ReadLine());

        if (numberN <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        for (int i = 1; i <= numberN; i++)
        {
            if (i % 21 != 0) // checking if the number is divisible by 3 and 7 at the same time => divisible by 21
            {
                Console.WriteLine(i);
            }
        }

    }
}
