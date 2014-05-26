//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer.");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine((num1 % 2 == 0) ? "The number is even." : "The number is odd.");
    }
}
