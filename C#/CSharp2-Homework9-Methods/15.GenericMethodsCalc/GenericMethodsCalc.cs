// * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;


class GenericMethodsCalc
{
    //MINIMUM
    static T FindMinimum<T>(params T[] array)
    {
        dynamic minValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }
        return minValue;
    }

    //MAXIMUM
    static T FindMaximum<T>(params T[] array)
    {
        dynamic maxValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }
        return maxValue;
    }

    //AVERAGE
    static T FindAverage<T>(params T[] array)
    {
        dynamic sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }

        return sum / array.Length;
    }

    //SUM
    static T FindSum<T>(params T[] array)
    {
        dynamic sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }

        return sum;
    }

    //PRODUCT 
    static T FindProduct<T>(params T[] array)
    {
        dynamic product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product = product * array[i];
        }

        return product;
    }

    static void Main()
    {
        Console.WriteLine("20, 8000, 5, 9, 84753953, 53, 47583");
        Console.WriteLine();

        Console.WriteLine("The Mimimum of the sequence is: {0}", FindMinimum(20, 8000, 5, 9, 6, 53, 3.5));
        Console.WriteLine("The Maximum of the sequence is: {0}", FindMaximum(20, 8000, 5, 9, 6, 53, 3.5));
        Console.WriteLine("The Average of the sequence is: {0:0.00}", FindAverage(20, 8000, 5, 9, 6, 53, 3.5));
        Console.WriteLine("The Sum of the sequence is: {0}", FindSum(20, 8000, 5, 9, 6, 53, 3.5));
        Console.WriteLine("The Product of the sequence is: {0}", FindProduct(20, 8000, 5, 9, 6, 53, 3.5));
    }
}
