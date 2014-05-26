// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class WordsInAlphabeticOrder
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(); // or Split(' ') 
        Array.Sort(words);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }      
    }
}
