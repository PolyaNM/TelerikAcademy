// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text;

class ConsecutiveLetters
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        //string input = "NnnnnnnNNNNnnnnNNNNNNnnAAaaARrrAAaaAAACCccmmMMmcCCooOOonn".ToLower();
        StringBuilder str = new StringBuilder(input);

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
                str.Remove(i, 1);
                i--;
            }
        }
        Console.WriteLine("Text after replacing the consecutive identical letters : " + str);
    }
}
