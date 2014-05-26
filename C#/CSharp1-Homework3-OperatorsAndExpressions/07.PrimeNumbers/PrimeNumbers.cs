//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter a positive integer between 0 and 100: ");
        int inputNumber = int.Parse(Console.ReadLine());
        //if the number is 100, we need to check if it is devisible by prime numbers between 2 and square root of 100, i.e. 10. 
        int maxDivider = (int)Math.Sqrt(inputNumber);
        int divider = 2;
        bool prime = true;

        while (prime && (divider <= maxDivider))
        {
            if (inputNumber % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine("Prime? {0}", prime);
    }
}
