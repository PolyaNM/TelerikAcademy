//Write a program that finds the biggest of three integers using nested if statements.

using System;

class FindBiggestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter three integers, each one of them on a new line.");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("the biggest number is {0}", a);
        }
        else if (b >= c && b >= a)
        {
            Console.WriteLine("the biggest number is {0}", b);
        }
        else
        {
            Console.WriteLine("the biggest number is {0}", c);
        }

    }
}
