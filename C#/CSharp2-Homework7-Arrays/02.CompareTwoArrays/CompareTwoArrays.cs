// Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the elements of two arrays on two different lines. The elements must be integer numbers, separated by an interval");
        Console.WriteLine("Enter the elements of the first array");
        string inputArrayOne = Console.ReadLine();
        Console.WriteLine("Enter the elements of the second array");
        string inputArrayTwo = Console.ReadLine();

        // Transforming the input string into a string array
        string[] inputOne = inputArrayOne.Split(' '); //the intervals between the elements are used as separators.

        string[] inputTwo = inputArrayTwo.Split(' ');

        //Parsing
        int[] array1 = new int[inputOne.Length];
        for (int i = 0; i < inputOne.Length; i++)
        {
            array1[i] = int.Parse(inputOne[i]);
        }
        int[] array2 = new int[inputTwo.Length];
        for (int i = 0; i < inputTwo.Length; i++)
        {
            array2[i] = int.Parse(inputTwo[i]);
        }

        //Comparing array1 and array2
        int counter = 0;
        if (array1.Length != array2.Length)
        {
            Console.WriteLine("The two arrays are not equal"); 
        }
        else if (array1.Length == array2.Length)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    counter++;
                }
            }
            if (counter == array1.Length)
            {
                Console.WriteLine("The two arrays are equal!");
            }
            else
	        {
                Console.WriteLine("The two arrays are NOT equal!");
	        }
        }    
    }
}