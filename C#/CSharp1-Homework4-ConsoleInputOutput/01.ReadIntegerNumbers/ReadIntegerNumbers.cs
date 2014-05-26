// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ReadIntegerNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 integer numbers, each one on a different line.");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int sum = number1 + number2 + number3;
        Console.WriteLine("The sum of these numbers is: {0}", sum);
    }
}
