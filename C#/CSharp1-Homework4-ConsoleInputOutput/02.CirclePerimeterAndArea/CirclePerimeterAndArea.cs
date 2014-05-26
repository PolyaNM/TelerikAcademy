//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Please enter the radius of the circle. ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * radius * Math.PI;
        double area = radius * radius * Math.PI;
        Console.WriteLine("The perimeter of the circle is {0:F2}", perimeter);
        Console.WriteLine("The area of the circle is {0:F2}", area);
    }
}

