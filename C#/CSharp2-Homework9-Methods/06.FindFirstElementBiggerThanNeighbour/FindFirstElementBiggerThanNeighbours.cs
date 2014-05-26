//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
using System;

public class Neighbors
{
    static int FindIndexOfFirstBiggerElement(int[] array)
    {
        //first we assume that there is no such element that is bigger than its neighbours ==> index = -1
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {         
            //here we use the method from the previous task.
            bool checkNumber = CompareElementWithNeighbours.CompareWithNeightbours(array, i);
            // if the element at position "i" is bigger than it`s neighbours, than we break the cycle and the index = i;
            if (checkNumber)
            {
                index = i;
                break;
            }
        }
        return index;
    }
    static void Main()
    {
        int[] array = { 2, 5, 6, 2, 9, 6 };
        //int[] array = { 2, 2, 2, 2, 2, 2 }; 

        //Printing the result - either the position of the element or -1 if there is no such element that fits the description.
        Console.WriteLine(FindIndexOfFirstBiggerElement(array));
    }
}
