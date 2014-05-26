// Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearchAlgorithm
{
    static void Main()
    {

        int[] array = {1, 5, 6, 9, 11, 44, 55, 89 }; //The binary search algo can be used only on sorted arrays
        int searchedNumber = 5;

        int startSearch = 0;
        int endSearch = array.Length - 1;
        int middle;
        while (startSearch <= endSearch)
        {
            middle = (startSearch + endSearch) / 2;

            if (array[middle] == searchedNumber)
            {
                Console.WriteLine("The index of the element is: {0}.", middle);
                break;
            }

            else if (array[middle] < searchedNumber)
            {
                startSearch = middle + 1;
            }

            else if (array[middle] > searchedNumber)
            {
                endSearch = middle - 1;
            }
        }

    }
}

// OR we can simply use the Array.BinarySearch generic method. This method quickly and accurately pinpoints the location of an element in the array.
// source: http://www.dotnetperls.com/array-binarysearch

//int index = Array.BinarySearch(array, searchedNumber);
//Console.WriteLine(index);