// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
// Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class VariationsKN
{
    // Generates variations
    static void GenerateVariations(int[] array, int index, int N)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                array[index] = i;
                GenerateVariations(array, index + 1, N);
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
        GenerateVariations(array, 0, N);
    }
}
