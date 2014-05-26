// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSortAlgo
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

        
        int[] array = { 2, 3, -5, 7, -145, 19, 0, 4, 1, 5, 2 };

        //Printing the original array
        Console.WriteLine(string.Join(" ", array));

        //Solution
        for (int i = 0; i < array.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            //Exchanging the positions of the two elements in the array
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }

        //Output
        Console.WriteLine("\r\nAfter sorting the elements in ascending order:");
        Console.WriteLine(string.Join(" ", array));
    }
}
