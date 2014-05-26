// Write methods that calculate the surface of sideA triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math

using System;

class CalculateSurfaceOfTriangle
{
    static double CalculateAreaWithAltitude(double sideA, double altitude)
    {
        return (sideA * altitude) / 2;
    }

    static double CalculateAreaWithThreeSides(double sideA, double sideB, double sideC)
    {
        double p = (sideA + sideB + sideC) / 2;

        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }


    static double CalculateAreaWithTwoSidesAndAngle(double sideA, double sideB, double angle)
    {
        return (sideA * sideB * Math.Sin(Math.PI * angle / 180)) / 2;
    }

    static void Main()
    {
        Console.WriteLine("The surface of the triangle by given side = 5 and altitude = 4 is: {0:F2}", CalculateAreaWithAltitude(sideA: 5, altitude: 4));
        Console.WriteLine("The surface of the triangle by given three sides a=5, b=4, c=6 is : {0:F2}",CalculateAreaWithThreeSides(sideA: 5, sideB: 4, sideC: 6));
        Console.WriteLine("The surface of the triangle by given two sides a=5, b=4 and the angle between them = 60 is: {0:F2}",CalculateAreaWithTwoSidesAndAngle(sideA: 5, sideB: 4, angle: 60));
    }   
}
