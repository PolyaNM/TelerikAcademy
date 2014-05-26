// Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.

using System;

class SelectionSort
{
    public static int MaxOfPortion(int[] array, int index)
    {
        if (index < 0 || index > array.Length - 1) return -1;

        int max = array[index];
        int maxIndex = index;

        for (int i = index + 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        array[maxIndex] = int.MinValue;
        return max;
    }

    public static int[] SortDescending(int[] array)
    {
        int[] sorted = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            sorted[i] = MaxOfPortion(array, 0);
        }
        return sorted;
    }

    public static int[] SortAscending(int[] array)
    {
        int[] sorted = new int[array.Length];

        for (int i = array.Length - 1; i >= 0; i--)
        {
            sorted[i] = MaxOfPortion(array, 0);
        }
        return sorted;
    }

    static void Main()
    {
        int[] arrayOne = { 5, 1, 10, 3, 5, 87, 5, 7, 8, 9, 3, 4, 1, 10, 75, 15 };
        int[] arrayTwo = { 4, 1, 11, 54, 34, 9, 11, 65 };

        int[] sortedArray = SortDescending(arrayOne);
        Console.Write("Descending order: ");
        Console.WriteLine(string.Join(" ", sortedArray));

        sortedArray = SortAscending(arrayTwo);
        Console.Write("Ascending order: ");
        Console.WriteLine(string.Join(" ", sortedArray));
    }
}
