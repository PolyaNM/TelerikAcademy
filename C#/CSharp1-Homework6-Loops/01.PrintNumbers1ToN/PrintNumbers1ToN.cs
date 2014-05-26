// Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbers1ToN
{
    static void Main()
    {
        Console.Write("Enter an integer number N = ");
        int N = int.Parse(Console.ReadLine());
        if (N < 1)
        {
            Console.WriteLine("Invalin Input!");
        }
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }

    }
}
