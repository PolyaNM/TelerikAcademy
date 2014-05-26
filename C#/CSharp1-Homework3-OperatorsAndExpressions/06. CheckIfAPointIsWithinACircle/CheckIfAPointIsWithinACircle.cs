//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int radius = 5;
        if ((x * x) + (y * y) > (radius * radius))
        {
            Console.WriteLine("The given point is NOT within the circle.");
        }
        else
        {
            Console.WriteLine("The given point is within the circle.");
        }

    }
}
