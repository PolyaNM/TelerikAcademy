// Write a program to calculate n! for each n in the range [1..100]. 

// To solve this task (with reference to the C# book) we can use either the method from task 8 OR class System.Numerics.BigInteger. First - solution with Biginteger.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

    class NFactorial100
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Factorial(i));
            }
        }
        static BigInteger Factorial(BigInteger number)
        {
            BigInteger productN = 1;
            for (int i = 1; i <= number; i++)
            {
                productN *= i;
            }
            return productN;
        }
    }
