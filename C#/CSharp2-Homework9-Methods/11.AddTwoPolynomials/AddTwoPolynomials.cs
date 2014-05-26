// Write a method that adds, substracts and multiplies two polynomials. Represent them as arrays of their coefficients. 	x2 + 5 = 1x2 + 0x + 5  --> 501
// Task 11 + 12

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddSubstractMultiplyTwoPolynomials
{
    //SUM METHOD
    static void SumOfPolinomials(int[] firstPol, int[] secondPol, int[] result)
    {
        int minLenght = 0;
        int smallerPolinomial = 0;

        if (firstPol.Length > secondPol.Length)
        {
            minLenght = secondPol.Length;
            smallerPolinomial = 2;
        }
        else
        {
            minLenght = firstPol.Length;
            smallerPolinomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPol[i] + secondPol[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolinomial == 1)
            {
                result[i] = secondPol[i];
            }
            else
            {
                result[i] = firstPol[i];
            }
        }
    }

    //SUBSTRACTION METHOD
    static void SubstractionOfPolinomials(int[] firstPol, int[] secondPol, int[] result)
    {
        int minLenght = 0;
        int smallerPolinomial = 0;

        if (firstPol.Length > secondPol.Length)
        {
            minLenght = secondPol.Length;
            smallerPolinomial = 2;
        }
        else
        {
            minLenght = firstPol.Length;
            smallerPolinomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPol[i] - secondPol[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolinomial == 1)
            {
                result[i] = secondPol[i];
            }
            else
            {
                result[i] = firstPol[i];
            }
        }
    }

    //MULTIPLICATION METHOD
    static void MultiplyPolinomials(int[] firstPol, int[] secondPol, int[] result)
    {
        //declare zeros at result polinom
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < firstPol.Length; i++)
        {
            for (int j = 0; j < secondPol.Length; j++)
            {
                int position = i + j;
                result[position] += (firstPol[i] * secondPol[j]);
            }
        }
    }


    //PRINT POLINOMIAL
    static void PrintPolinomial(int[] polinomial)
    {
        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            if (polinomial[i] != 0 && i != 0) 
            {
                if (polinomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polinomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polinomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polinomial[i]);
            }
        }
        Console.WriteLine();
    }


    static void Main()
    {
        //INPUT-the polinomials will be represented as arrays of their coefficients. After that we will print the two polinomials, not just the coeff.
        int[] firstPol = { 2, -3 }; // - 3*x + 2
        Console.WriteLine("First Polinomial:");
        PrintPolinomial(firstPol);

        int[] secondPol = { 11, 4, 1 };
        Console.WriteLine("Second Polinomial:");
        PrintPolinomial(secondPol);

        //determine the max length of the result
        int maxLenght = 0;
        if (firstPol.Length > secondPol.Length)
        {
            maxLenght = firstPol.Length;
        }
        else
        {
            maxLenght = secondPol.Length;
        }

        int[] result = new int[maxLenght];
        Console.WriteLine();

        //SUM
        SumOfPolinomials(firstPol, secondPol, result);
        Console.WriteLine("Sum:");
        PrintPolinomial(result);

        //SUBSTRACTION
        SubstractionOfPolinomials(firstPol, secondPol, result);
        Console.WriteLine("Substraction:");
        PrintPolinomial(result);

        //MULTIPLICATION
        int[] multiply = new int[firstPol.Length + secondPol.Length];
        MultiplyPolinomials(firstPol, secondPol, multiply);
        Console.WriteLine("Multiplication:");
        PrintPolinomial(multiply);
    }
}
