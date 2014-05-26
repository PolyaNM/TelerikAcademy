//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.


using System;

class FindKElementsWithMaxSum
{
    static void Main()
    {
        //Input
        Console.Write("Please enter N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter K = ");
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        if (K > N)
        {
            Console.WriteLine("Invalid input! N must be bigger than K!");
            return;
        }

        Console.WriteLine("Please enter the elements of the array");
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }


       //// First Method - if we assume that we are looking for any K elements in the array, not a sequence of K elements. First we sort the array in ascending order and then we find the sum of the last K elements.
       // Array.Sort(array);
       // int sum = 0;

       // Console.WriteLine("The following {0} elements in the array have maximal sum.", K);
       // for (int j = N - K; j < N; j++)
       // {
       //     sum += array[j];
       //     Console.WriteLine("{0} ",array[j]);
       // }
       // Console.WriteLine("Their sum is {0}", sum);



        //Second Method - if we assume that we are looking for a SEQUENCE of K elements.

        int sum = 0;
        int bestSum = 0;
        int positionOfFirstElement = 0;
        for (int i = 0; i < N; i++)
        {
            if (N < K + i)    // to check if there are K-1 number of elements after the element at position i.
            {
                break;
            }
            for (int j = i; j < K + i; j++)
            {
                sum += array[j];
            }
            if (sum > bestSum)
            {
                bestSum = sum;
                positionOfFirstElement = i;
                sum = 0;
            }
        }

        //Output
        Console.Write("The sequence with {0} elements and maximal sum is: ", K);
        for (int k = positionOfFirstElement; k < positionOfFirstElement + K; k++)
        {
            Console.Write("{0} ", array[k]);
        }
        Console.WriteLine();
    }
}
