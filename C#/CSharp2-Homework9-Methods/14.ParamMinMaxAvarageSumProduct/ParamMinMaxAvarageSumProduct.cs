// Write methods to calculate minimum, maximum, average, sum and product of given array of integer numbers. Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class ParamMinMaxAvarageSumProduct
{
    //MINIMUM
    static int FindMinimum(params int[] array)
    {
        int minValue = array[0];
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
    static int FindMaximum(params int[] array)
    {
        int maxValue = array[0];
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
    static double FindAverage(params int[] array)
    {
        int sum = 0;
 
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
 
        return (double)sum / array.Length;
    }
 
    //SUM
    static int FindSum(params int[] array)
    {
        int sum = 0;
 
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
 
        return sum;
    }

    //PRODUCT
    static BigInteger FindProduct(params int[] array)
    {
        BigInteger product = 1;
 
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
        Console.WriteLine("The Mimimum of the sequence is: {0}", FindMinimum(20, 8000, 5, 9, 84753953, 53, 47583));
        Console.WriteLine("The Maximum of the sequence is: {0}", FindMaximum(20, 8000, 5, 9, 84753953, 53, 47583));
        Console.WriteLine("The Average of the sequence is: {0:0.00}", FindAverage(20, 8000, 5, 9, 84753953, 53, 47583));
        Console.WriteLine("The Sum of the sequence is: {0}", FindSum(20, 8000, 5, 9, 84753953, 53, 47583));
        Console.WriteLine("The Product of the sequence is: {0}", FindProduct(20, 8000, 5, 9, 84753953, 53, 47583));
    }
}
    
