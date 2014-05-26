// Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;

class SumOfSequence
{
    static void Main()
    {
        Console.Write("Enter an integer number N = ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer number X = ");
        int X = int.Parse(Console.ReadLine());

        if (N < 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        double sum = 1;
        double factorialN = 1;
        double powerOfX = 1;

        for (int i = 1; i <= N; i++)
        {
            factorialN *= i;
            powerOfX *= X;
            sum += (factorialN / powerOfX);
        }

        Console.WriteLine(sum);
    }
}
