// Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class FindASequenceOfGivenSum
{
    static void Main()
    {

        ////Input
        //Console.Write("Please enter the length of the array ");
        //int arraylength = int.Parse(Console.ReadLine());
        //int[] array = new int[arraylength];
        //Console.WriteLine("Please enter the elements of the array - each one on a different line.");
        //for (int i = 0; i < arraylength; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //Console.Write("Please enter the sum S = ");

        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 12 };
        int sum = 11;
        int currentSum = int.MinValue;

        //Solution
        for (int i = 0; i < array.Length - 1; i++)
        {
            currentSum = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum > sum)
                {
                    break;
                }
                else if (currentSum == sum)
	            {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write("{0} ", array[k]);
                    }
                    Console.WriteLine();
                    return;                 // if we want to find ALL sequences with sum = 11, we will have to use "break" instead of return.
	            }             
            }
        }

        // If we can't find a sequence 
        Console.WriteLine("There is no such sequence with sum = {0} in the array", sum);
    }
}

// For this task we assume that the sequence must be with more than 1 element. Otherwise first we will have to check if some element in the array = the needed sum.
