// Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class EmailExtractor
{
    static void Main()
    {
        string text = @"Please contact us by phone (+359 222 222 222) or by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk . This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

        string[] splittedText = text.Split(' ');


        for (int i = 0; i < splittedText.Length; i++)
        {
            if (Regex.IsMatch(splittedText[i], @"[\w., \-]{2,15}@[\w]{2,15}[.]{1}[\w.]{2,6}"))
            {
                Console.WriteLine(splittedText[i]);
            }
        }           
    }
}