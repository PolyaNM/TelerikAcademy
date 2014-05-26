//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

//The rectangle can be defined by two points : top left (-1,1) and bottom right (5,-1)

using System;

class PointWithinACircleOutOfARectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates x and y of a point, each on a new line.");
        double pointX = double.Parse(Console.ReadLine());  //the coordinates may be real numbers
        double pointY = double.Parse(Console.ReadLine());
        int radius = 3;
        bool isInTheCircle = false;
        if ((pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= radius * radius)
        {
            isInTheCircle = true;
        }

        // The rectangle's coordinates
        int rectTopLeftX = -1;
        int rectTopLeftY = 1;
        int rectBotRightX = 5;
        int rectBotRightY = -1;
        // If the point is out of the rectangle
        bool isOutOfTheRect = false;
        if ((rectTopLeftX > pointX) || (rectTopLeftY < pointY) || (rectBotRightX < pointX) || (rectBotRightY > pointY))
        {
            isOutOfTheRect = true;
        }
        Console.WriteLine(isInTheCircle && isOutOfTheRect ? "The point is within the circle and out of the rectangle" : "The point is NOT within the circle and out of the rectangle");
    }
}
