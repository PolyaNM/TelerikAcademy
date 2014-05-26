//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …


using System;
using System.Numerics;

class First100Fibonacci
{
    static void Main()
    {
        BigInteger firstFibonacci = 0;          // we can also use decimal !
        BigInteger secondFibonacci = 1;
        BigInteger nFibonacci = firstFibonacci + secondFibonacci;
        Console.WriteLine(firstFibonacci);
        Console.WriteLine(secondFibonacci);
        Console.WriteLine(nFibonacci);
        for (int i = 4; i <= 100; i++)
        {
            firstFibonacci = secondFibonacci;
            secondFibonacci = nFibonacci;
            nFibonacci = firstFibonacci + secondFibonacci;
            Console.WriteLine(nFibonacci);
        }
    }
}


