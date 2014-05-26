//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

/*x = [ -b +/- sqrt(discriminant) ] / 2a     ; Discriminant = b*b - 4*a*c
We have to find the value of (b*b - 4*a*c). 

When it is greater than Zero, we will get two Real Solutions.
When it is equal to zero, we will get one Real Solution.
When it is less than Zero, we will get two Imaginary Solutions.*/

using System;

class QuadraticEquation 
{
    static void Main()
    {
        Console.Write("Enter coefficient a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c = ");
        double c = double.Parse(Console.ReadLine());
        double discriminant = (b * b) - (4 * a * c);
        double root1;
        double root2;

        if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Two real roots:");
            Console.WriteLine(root1);
            Console.WriteLine(root2);
        }
        else if (discriminant == 0)
        {
            root1 = root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("One real root:");
            Console.WriteLine(root1);
        }
        else
        {
            Console.WriteLine("No real roots.");
        }

    }
}
