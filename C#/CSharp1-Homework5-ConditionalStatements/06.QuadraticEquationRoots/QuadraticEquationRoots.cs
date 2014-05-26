//Write a program that enters the coefficients a, b and c of a quadratic equation ( a*x2 + b*x + c = 0 ) and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class QuadraticEquationRoots
{
    static void Main()
    {
        Console.Write("Enter coefficient a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c = ");
        double c = double.Parse(Console.ReadLine());
        double determinant = b * b - 4 * a * c;

        if (determinant > 0)
        {
            double root1 = (-b + Math.Sqrt(determinant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(determinant)) / (2 * a);
            Console.WriteLine("Two real roots : {0:F3} and {1:F3}", root1, root2);
        }
        else if ( determinant == 0 )
        {
            Console.WriteLine("One real root : " + (-b / 2 * a));
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}
