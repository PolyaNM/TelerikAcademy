// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortAnArrayOfStrings
{
    static void SortArrayByLength(string[] array)
    {
        string temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i].Length > array[j].Length)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
    static void Main()
    {       
        string[] array = { "aaa", "mm", "goooo", "st", "mmmmmmmm", "rrr" };
        SortArrayByLength(array);

        //Output
        Console.WriteLine(string.Join(" ", array));
    }
}
