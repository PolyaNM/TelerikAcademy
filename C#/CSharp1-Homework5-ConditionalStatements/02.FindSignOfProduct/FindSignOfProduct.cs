//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

class FindSignOfProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers, each of them on a new line");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product of the numbers is 0");
        }
        else if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) ||
            (a > 0 && b > 0 && c < 0))
        {
            Console.WriteLine("The product of the numbers is negative");
        }
        else Console.WriteLine("The product of the numbers is positive");
    }
}