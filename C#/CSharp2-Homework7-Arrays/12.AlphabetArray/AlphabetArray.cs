// Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

using System;

class AlphabetArray
{
    static void Main()
    {
        // The array will hold both small and capital letters. If we want to use only cappital letters, the length of the array will be 26.
        int[] array = new int[52];  

        //For small letters                                               
        for (int s = 0; s < array.Length / 2; s++)
        {
            array[s] = (char)(s + 97);                                          
        }

        //For capital letters
        for (int c = array.Length / 2, m = 0; c < array.Length; c++, m++)
        {
            array[c] = (char)(m + 65); 
        }

        Console.Write("Please enter a word in capital letters - ");   
        string word = Console.ReadLine();

        // The indexes will start from 0, i.e. a = 0, b = 1...  A = 26, B = 27....
        Console.WriteLine("The indexes of the letters are: ");                      
        for (int indexWord = 0; indexWord < word.Length; indexWord++)
        {
            for (int indexArray = 0; indexArray < array.Length; indexArray++)
            {
                if (word[indexWord] == array[indexArray])
                {
                    Console.WriteLine("Letter {0} - Index {1}", word[indexWord], indexArray);
                    break;
                }
            }
        }
    }
}
