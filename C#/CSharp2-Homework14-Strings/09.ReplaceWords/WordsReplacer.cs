// We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. 

using System;
using System.Text;

class WordsReplacer
{
    static void Main()
    {
        string inputText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = new string[] { "PHP", "CLR", "Microsoft" };
        StringBuilder result = new StringBuilder();
        result.Append(inputText);

        foreach (string word in forbiddenWords)
        {
            result.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(result);
    }
}
