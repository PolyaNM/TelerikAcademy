using System;

//Create a console application that calculates and prints the square of the number 12345.

class SquareOfNumber
{
    static void Main()
    {
        int number = 12345;
        double squareOfNum = Math.Pow(number, 2);
        Console.WriteLine(squareOfNum);
    }
}