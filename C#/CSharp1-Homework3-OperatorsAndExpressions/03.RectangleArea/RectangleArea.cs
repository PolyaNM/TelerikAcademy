//Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        double dWidth, dHeight, dArea;
        Console.WriteLine("Enter the height and width of the rectangle: ");
        dHeight = double.Parse(Console.ReadLine());
        dWidth = double.Parse(Console.ReadLine());
        dArea = dHeight * dWidth;
        Console.WriteLine("The area of the rectangle is: {0}", dArea);
    }
}
