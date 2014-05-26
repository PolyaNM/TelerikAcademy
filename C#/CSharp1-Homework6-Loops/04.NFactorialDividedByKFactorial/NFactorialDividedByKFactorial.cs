//Write a program that calculates N!/K! for given N and K (1<K<N).

//N! = 1*2*3*.....*K*....*N
//K! = 1*2*3*.....*K
//This leads us to the conclusion that N!/K! = (K+1)*(K+2)*...*N

using System;
using System.Numerics;

class NFactorialDividedByKFactorial
{
    static void Main()
    {
        Console.Write("Enter an integer number N: ");
        int N = int.Parse(Console.ReadLine());
        if (N < 1)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        Console.Write("Enter an integer number K: ");
        int K = int.Parse(Console.ReadLine());
        if (K < 0 || K > N)
        {
            Console.WriteLine("Invalid input! K must be in the interval [0,N)");
        }

        if (K > 0 && K < N && N > 1)
        {
            BigInteger result = 1;
            for (int i = K + 1; i <= N; i++)
            {
                result = result * i;
            }
            Console.WriteLine("N!/K! = {0}", result);
        }
    }
}