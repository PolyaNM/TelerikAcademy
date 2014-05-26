//Write a program to calculate the Nth Catalan number by given N.
//Cn = (2n)! / (n+1)!*n!, n>=0 ==> Cn = the product of the numbers in the interval [n+2; 2n] divided by n!

using System;
using System.Numerics;

class CatalianNumberN
{
    static void Main()
    {
        Console.Write("Enter a positive integer number N: ");
        string isInt = Console.ReadLine();
        int n;
        BigInteger result = 0;
        BigInteger dividend = 1;
        BigInteger divisor = 1;

        //checking the input
        if (!int.TryParse(isInt, out n))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        if (n == 0)
        {
            Console.WriteLine("The Nth Catalan number is 0");
        }
        else
        {
            for (int i = n + 2; i <= 2 * n; i++)
            {
                dividend *= i;
            }
            for (int i = 2; i <= n; i++)
            {
                divisor *= i; 			 
            }

            result = dividend / divisor;
            Console.WriteLine("The Nth Catalan number is {0}", result);
        }
    }
}
