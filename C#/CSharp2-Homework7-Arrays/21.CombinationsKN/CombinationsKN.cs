// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
// Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class CombinationsKN
{
    // Generates variations
    static void GenerateVariations(int[] array, int index, int N, int k)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = k; i <= N; i++)
            {
                array[index] = i;
                GenerateVariations(array, index + 1, N, i+1);
            }
        }
    }

    // Prints array
    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }

    // Main method
    static void Main()
    {
        // Input
        Console.WriteLine("Ënter N = ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K = ");
        int K = int.Parse(Console.ReadLine());

        // Creates an annay with length = K
        int[] array = new int[K];
        GenerateVariations(array, 0, N, 1);
    }
}
