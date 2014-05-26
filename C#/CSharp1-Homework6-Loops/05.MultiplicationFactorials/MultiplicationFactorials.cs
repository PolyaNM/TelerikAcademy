//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

// We will use 2 for loops : 1) N! 2)K!/(K-N)! => from K-N+1 to K
using System;
using System.Numerics;

class MultiplicationFactorials
{
    static void Main()
    {
        Console.Write("Enter an integer number K: ");
        int K = int.Parse(Console.ReadLine());
        if (K < 1)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        Console.Write("Enter an integer number N: ");
        int N = int.Parse(Console.ReadLine());
        if (N < 0 || K < N)
        {
            Console.WriteLine("Invalid input! N must be in the interval [0,K)");
        }

        BigInteger factorialN = 1;    //N!
        for (int i = N; i > 1; i--)
        {
            factorialN *= i;
        }

        BigInteger factorialDivision = 1;  // K!/(K-N)!
        for (int j = K; j > K - N; j--)   // or j >= K-N+1
        {
            factorialDivision *= j;
        }

        BigInteger factorialResult = factorialDivision * factorialN;
        Console.WriteLine("N!*K! / (K-N)! = {0}",factorialResult);
    }
}
