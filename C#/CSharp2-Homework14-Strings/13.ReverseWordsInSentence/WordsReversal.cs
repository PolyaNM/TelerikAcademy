// Write a program that reverses the words in given sentence.
// Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections.Generic;
using System.Text;

class WordsReversal
{
    static void Main()
    {
        Console.WriteLine("Please enter a sentence.");
        string sentence = Console.ReadLine(); //C# is not C++, not PHP and not Delphi!

        List<char> listLetters = new List<char>(); // here we'll keep all letters/numbers/symbols that can be viewed as part of a word
        for (char i = 'A'; i <= 'Z'; i++)
        {
            listLetters.Add(i);
        }
        for (char i = 'a'; i <= 'z'; i++) 
        {
            listLetters.Add(i);
        } 
        for (char i = '0'; i <= '9'; i++)
        {
            listLetters.Add(i);
        }
        // additional symbols that are viewed as part of the word - #, +, -, etc.
        listLetters.Add('#'); listLetters.Add('+'); listLetters.Add('-'); listLetters.Add('@'); listLetters.Add('$'); listLetters.Add('~'); 
        listLetters.Add('%'); listLetters.Add('&'); listLetters.Add('&'); listLetters.Add('*'); listLetters.Add('^'); 
        
        char[] punctoationMarks = new char[] { '.', ',', '!', '?', '(', ')', ':', ';', '"', ' ' };   

        string[] onlyWords = sentence.Split(punctoationMarks , StringSplitOptions.RemoveEmptyEntries);
        string[] onlySigns = sentence.Split(listLetters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(onlyWords);

        StringBuilder reversedWords = new StringBuilder();

        for (int i = 0; i < onlySigns.Length; i++)
        {
            reversedWords.Append(onlyWords[i]);
            reversedWords.Append(onlySigns[i]);
        }

        Console.WriteLine("The sentence after reversing the words is : \n{0}",reversedWords.ToString());
    }
}
