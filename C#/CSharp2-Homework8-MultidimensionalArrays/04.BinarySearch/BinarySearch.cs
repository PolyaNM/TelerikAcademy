// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinarySearch
{
    static void Main()
    {
        //Input
        Console.Write("Enter the length of the array n = ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        Console.WriteLine("Enter the elements of the array. They must be integer numbers. ");
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter an integer number k = ");
        int k = int.Parse(Console.ReadLine());

        //Solution
        int number = 0;
        Array.Sort(array); //sorts the array in ascending order
        if (array[0] > k)
        {
            Console.WriteLine("There is no element in this array that is <= k.");
        }
        else
        {
            int numIndex = Array.BinarySearch(array, k);
            if (numIndex >= 0)
            {
                number = array[numIndex];
            }
            else
            {
                number = array[~numIndex - 1];
            }
            Console.WriteLine("The largest number in the array which is ≤ K is " + number);
        }

    }
}
