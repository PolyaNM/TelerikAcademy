//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class CompareNumWithoutIf
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers: ");
        decimal number1 = decimal.Parse(Console.ReadLine());
        decimal number2 = decimal.Parse(Console.ReadLine());
        decimal greaterNum = Math.Max(number1, number2);
        Console.WriteLine("The greater number is {0}", greaterNum);
    }
}
