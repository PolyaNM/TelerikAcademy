// A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
// .NET – platform for applications from Microsoft
// CLR – managed execution environment for .NET
// namespace – hierarchical organization of classes


using System;
using System.Collections.Generic;

class Dictionary
{
    static void Main()
    {
        Console.WriteLine("Please enter how many lines the dictionary is composed of.");
        int n = int.Parse(Console.ReadLine());
        string[] dictionary = new string[n];
        Console.WriteLine("Please enter the contents of the dictionary in this format --> word – description.");
        for (int i = 0; i < n; i++)
        {
            dictionary[i] = Console.ReadLine();
        }
        Console.WriteLine("Please enter the word which description you want to find in the dictionary");
        string word = Console.ReadLine();

        for (int i = 0; i < n; i++)
        {
            int firstSpace = dictionary[i].IndexOf(' '); // we will use the first blank to determine the end of the word and the start of its description in the dictionary. The program will work only for single-words, not terms composed of 2+ words (visual studio for example)
            string foundWord = dictionary[i].Substring(0, firstSpace);
            if (foundWord == word)
            {
                Console.WriteLine("{0} means {1}", word, dictionary[i].Substring(word.Length + 3));
            }
        }

    }
}
