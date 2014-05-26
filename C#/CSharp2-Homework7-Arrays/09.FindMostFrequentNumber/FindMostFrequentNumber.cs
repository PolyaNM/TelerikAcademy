// Write a program that finds the most frequent number in an array.
// Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

//The program will work ONLY with integer numbers. Otherwise - we should use double, not int.

using System;

class FindMostFrequentNumber
{
    static void Main()
    {
        //Input
        //Console.WriteLine("Please enter the length of the array");
        //int arraylength = int.Parse(Console.ReadLine());
        //int[] array = new int[arraylength];
        //Console.WriteLine("Please enter the elements of the array - each one on a different line.");
        //for (int i = 0; i < arraylength; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };


        int maxCounter = 1;
        int number = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            int counter = 1;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    counter++;
                }
                else continue;
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                number = array[i];
            }
        }

        Console.WriteLine("The most frequent number in the array is {0} ({1} times)", number, maxCounter);

    }
}
