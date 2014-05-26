//Write a program that finds the greatest of given 5 variables.

using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five variables, each one on a new line.");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double num4 = double.Parse(Console.ReadLine());
        double num5 = double.Parse(Console.ReadLine());
        double max1 = Math.Max(num1, num2);
        double max2 = Math.Max(num3, num4);
        max2 = Math.Max(max2, num5);
        max2 = Math.Max(max2, max1);
        Console.WriteLine("The biggest number is : " + max2);
    }
}
