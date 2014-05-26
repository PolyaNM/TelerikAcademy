//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.


using System;
using System.Numerics;

class SumOfNFibonacciMembers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number");
        string isInt = Console.ReadLine();
        int n;

        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger sum = 1; 
        BigInteger currentNum = 0;


        if (!int.TryParse(isInt, out n))  // проверяваме дали въведеното число е integer
        {
            Console.WriteLine("Invalid input");
            return;
        }

        for (int i = 0; i < n - 2; i++)
        {
            currentNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = currentNum;
            sum += currentNum;
        }

        Console.WriteLine("The sum of the first {0} Fibonacci numbers is {1}", n, sum);
    }
}
