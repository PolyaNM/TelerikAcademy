//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSortAlgorithm
{
    static void Main()
    {
        // Input
        Console.WriteLine("Enter the length of the array.");
        int length = int.Parse(Console.ReadLine());
        string[] unsorted = new string[length];
        Console.WriteLine("Enter the elements of the array.");
        for (int i  = 0; i < length; i++)
        {
            unsorted[i] = Console.ReadLine();
        }

        // Prints the unsorted array
        Console.Write("The original unsorted array is: ");
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();

        // Sorts the array
        QuickSort(unsorted, 0, unsorted.Length - 1);

        // Prints the sorted array
        Console.Write("The new sorted array is: ");
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();
    }

    public static void QuickSort(string[] elements, int left, int right)
    {
        int i = left, j = right;
        string middle = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(middle) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(middle) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swaps the positions  of the elements
                string temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;
                i++;
                j--;
            }
        }

        // Recursion
        if (left < j)
        {
            QuickSort(elements, left, j);
        }

        if (i < right)
        {
            QuickSort(elements, i, right);
        }
    }
}
