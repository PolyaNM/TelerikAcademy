//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        //input
        Console.WriteLine("Please enter the elements of the first char array");
        string inputArrayOne = Console.ReadLine();
        Console.WriteLine("Please enter the elements of the second char array.");
        string inputArrayTwo = Console.ReadLine();

        // copy the input string to a unicode character array.
        char[] array1 = inputArrayOne.ToCharArray();
        char[] array2 = inputArrayTwo.ToCharArray();

        int minArrayLength = Math.Min(array1.Length, array2.Length); 
        bool equalArrays = true;

        for (int i = 0; i < minArrayLength; i++)
        {
            if (array1[i] == array2[i])
            {
                continue;
            }
            else
            {
                equalArrays = false;
                if (array1[i] > array2[i])
                {
                    Console.WriteLine("The second char array is lexicologically before the first one.");
                }
                else
                {
                    Console.WriteLine("The first char array is lexicologically before the second one.");
                }
                break;
            }
        }

        //if the first "minArrayLength" number of elements of the two arrays are the same, we compare the lengths of the two arrays.
        if (equalArrays == true)
        {
            if (array1.Length > array2.Length)
            {
                Console.WriteLine("The second char array is lexicologically before the first one.");
            }
            else if (array1.Length < array2.Length)
            {
                Console.WriteLine("The first char array is lexicologically before the second one.");
            }
            else
            {
                Console.WriteLine("The two arrays are equal, there is no difference!");
            }
        }     
    }
}
