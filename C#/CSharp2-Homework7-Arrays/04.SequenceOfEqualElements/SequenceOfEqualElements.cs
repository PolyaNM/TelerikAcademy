//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.


using System;

class SequenceOfEqualElements
{
    static void Main()
    {
        ////IF WE WANT THE INPUT TO BE FROM THE CONSOLE (USING CONSOLE.READLINE)

        //Console.WriteLine("Enter the elements of an array. The elements must be integer numbers separated ONLY with a comma and an interval! Example: 2, 3, 4");
        //string inputArray = Console.ReadLine();
        //char[] delimiter = new char[] { ',', ' ' };
        //string[] stringArray = inputArray.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        //int[] array = new int[stringArray.Length];
        //for (int i = 0; i < stringArray.Length; i++)
        //{
        //    array[i] = int.Parse(stringArray[i]);
        //}


        int[] array = { 2, 3, 3, 3, 3, 3, 4, 4, 5, 5, 5, 5, 5, 5, 6 };

        int bestLength = 1; // the length of the maximal sequence of equal elements
        int length = 1;
        int index = 0; // the position/index (in the original array) of the last element of the needed sequence

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                length++;
                if (length > bestLength)
                {
                    bestLength = length;
                    index = i + 1; 
                }
            }
            else
            {
                length = 1;
                continue;
            }
        }

        //Printing the maximal sequence of equal elements
        for (int j = index - bestLength + 1; j <= index; j++)
        {
            Console.Write("{0} ", array[j]);
        }
        Console.WriteLine();
    }
}