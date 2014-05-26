// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
// Text: We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. Result - 9

using System;
using System.Text.RegularExpressions;// necessary if we want to use Regex class

class SubstringInText
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";
        int count = Regex.Matches(text, substring, RegexOptions.IgnoreCase).Count;
        Console.WriteLine("The given substring appears {0} times in the text.", count);
    }
}
