//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Side a : ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Side b : ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Height : ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Trapezoid's area : ");
        Console.WriteLine("{0:f2}", (height * (sideA + sideB) / 2));

    }
}
