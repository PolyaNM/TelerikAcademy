// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

class Palindromes
{
    static void Main()
    {
        string text = @"ABBA is the word , exe something, blabla ivi.";
        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


        foreach (string word in words)
        {
            bool isPalindrome = true;
            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}
