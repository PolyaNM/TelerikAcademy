// Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

    public class CompareElementWithNeighbours
    {
        static void Main()
        {
            Console.WriteLine("Our array : 2, 5, 6, 2, 9, 6");
            int[] array = { 2, 5, 6, 2, 9, 6 };
            // input
            Console.Write("Enter the position of the element that we'll compare. The positions start from 0 (zero). ");
            int position = int.Parse(Console.ReadLine());
            //checks if the input is valid.
            if (position >= array.Length || position < 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            //output
            if (CompareWithNeightbours(array, position))
            {
                Console.WriteLine("The element at position {0} is bigger than its neightbour(s).", position); 
            }
            else
            {
                Console.WriteLine("The element at position {0} is NOT bigger than its neightbour(s).", position);
            }
            
        }

        public static bool CompareWithNeightbours(int[] array, int position)
        {
            int arrayLength = array.Length;
            // checks for the first element in the array - only one neighbour
            if (position == 0)
            {
                if (array[position] > array[position + 1]) 
                {
                    return true;
                }
                else return false;
            }
            // checks for the last element in the array - only one neighbour
            else if (position == arrayLength - 1) 
            {
                if (array[position] > array[position - 1])
                {
                    return true;
                }
                else return false;
            }
            // when the elemet has two neighbours
            else 
            {
                if (array[position] > array[position - 1] & array[position] > array[position + 1])
                {
                    return true;
                }
                else return false;
            }
        }
    }
