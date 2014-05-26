// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
// http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes

using System;

class SieveOfErathosthenesAlgo
{
    static void Main()
    {
        bool[] array = new bool[10000001];

        for (int i = 2; i < Math.Sqrt(array.Length); i++)
        {
            if (array[i] == false)            // this is true because the default value for bool is always False!
            {
                for (int j = i * i; j < array.Length; j += i)
                {
                    array[j] = true;
                }
            }
        }

        //Output
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == false)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
