//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.


using System;

class DivisibleBy5And7Simultaneously
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer.");
        int num1 = int.Parse(Console.ReadLine());
        if ((num1 % 7 == 0) && (num1 % 5 == 0)) // or if (num1 % 35 == 0)
        {
            Console.WriteLine("The given integer can be divided without remainder by 7 and 5 in the same time.");
        }
        else
        {
            Console.WriteLine("The given integer can't be divided without remainder by 7 and 5 in the same time.");
        }
    }
}

