//Write a program that safely compares floating-point numbers with precision of 0.000001. 

using System;

class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first value: ");
        decimal firstValue = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter second value: ");
        decimal secondValue = decimal.Parse(Console.ReadLine());
        decimal substraction = firstValue - secondValue;
        bool comparedValue = (Math.Abs(substraction) < 0.000001m);
        if (comparedValue == true)
        {
            Console.WriteLine("Values are equal with precision of 0.000001.");
        }
        else
        {
            if (firstValue - secondValue > 0)
            {
                Console.WriteLine("{0} is bigger than {1}", firstValue, secondValue);
            }
            else
            {
                Console.WriteLine("{0} is smaller than {1}", firstValue, secondValue);
            }
            Console.WriteLine("Values are not equal.");
        }
    }
}

