// Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;

class WordOccurrences
{
    static void Main()
    {
        string text = "The first day of the last (day) first.";
        string[] words = text.Split(new char[] { ' ', '.', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary[word] = dictionary[word] + 1;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }

        foreach (var word in dictionary)
        {
            Console.WriteLine("{0,-10} - {1} times", word.Key, word.Value);
        }
    }
}
