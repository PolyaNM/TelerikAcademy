// Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Enter 2 integer numbers, each on a different line");
        string isInt1 = Console.ReadLine();
        string isInt2 = Console.ReadLine();
        int firstNum, secondNum, temp;

        if (!int.TryParse(isInt1, out firstNum) || !int.TryParse(isInt2, out secondNum))
        {
            Console.WriteLine("Invalid input");
            return;
        }
        while (firstNum != 0)
        {
            temp = firstNum;
            firstNum = secondNum % firstNum;
            secondNum = temp;
        }
        System.Console.WriteLine("The greatest common divisor of the two numbers is {0}", Math.Abs(secondNum));

    }
}
