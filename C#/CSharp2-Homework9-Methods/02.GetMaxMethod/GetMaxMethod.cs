// Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMaxMethod
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        return firstNumber > secondNumber ? firstNumber : secondNumber;

        //Another way ... 
        //int maxNumber = 0;
        //if (firstNumber > secondNumber)
        //{
        //    maxNumber = firstNumber;
        //}
        //else
        //{
        //    maxNumber = secondNumber;
        //}
        //return maxNumber;
    }
    static void Main()
    {
        Console.WriteLine("Enter 3 integer numbers, each one on a different line.");

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest on among them is: {0}", GetMax(GetMax(firstNumber,secondNumber),thirdNumber));
    }
}
