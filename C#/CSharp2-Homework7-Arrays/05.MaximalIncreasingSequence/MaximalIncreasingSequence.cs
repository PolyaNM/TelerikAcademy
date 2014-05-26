//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
//!! The elements in this sequence can be increasing with +1 or +2 etc. 


using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        ////Input from the console!
        //Console.WriteLine("Please enter the length of the array");
        //int arraylength = int.Parse(Console.ReadLine());
        //int[] array = new int[arraylength];
        //Console.WriteLine("Please enter the elements of the array - each one on a different line.");
        //for (int i = 0; i < arraylength; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        int[] array = {1, 2, 3, 5, 7, 8, 5, 4, 5, 6};

        int seqLength = 1;
        int bestSeqLength = 1; // the length of the maximal increasing sequence
        int index = 0; // the position/index (in the original array) of the last element of the needed sequence

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                seqLength++;
                if (seqLength > bestSeqLength)
                {
                    bestSeqLength = seqLength;
                    index = i + 1;
                }
            }
            else
            {
                seqLength = 1;
                continue;
            }
        }

        //Printing the maximal increasing sequence
        for (int j = index - bestSeqLength + 1; j <= index; j++)
        {
            Console.Write("{0} ", array[j]);
        }
        Console.WriteLine();


        //If we have 2 increasing sequences with equal number of elements - the output will be ONLY the sequence which is first (the left one).
    }
}
