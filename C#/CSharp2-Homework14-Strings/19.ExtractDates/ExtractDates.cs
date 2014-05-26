// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

using System;
using System.Globalization;

class DatesExtractor
{
    static void Main()
    {
        string text = @"Крайна дата - 21.02.2014, начална дата - 21.10.2013.";
        string[] words = text.Split(new char[] { ' ', '?', '!', ';', ',', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            string wordWithoutDotInTheEnd = word;
            if (word[word.Length - 1] == '.')
            {
                wordWithoutDotInTheEnd = word.Substring(0, word.Length - 1); // removes the dot if the date is at the end of the sentence
                try
                {
                    DateTime date = DateTime.ParseExact(wordWithoutDotInTheEnd, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
                catch (Exception)
                {
                }
            }
            else
            {
                try
                {
                    DateTime date = DateTime.ParseExact(wordWithoutDotInTheEnd, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
                catch (Exception)
                {
                }
            }
        }      
    }
}
