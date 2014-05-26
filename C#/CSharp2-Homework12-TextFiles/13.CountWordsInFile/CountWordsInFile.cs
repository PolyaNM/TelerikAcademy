// Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic; // for Dictionary
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

class CountWordsInFile
{
    static void Main()
    {

        try
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            StreamReader readerWords = new StreamReader(@"..\..\words.txt");
            StreamReader readerText = new StreamReader(@"..\..\test.txt");
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");

            using (readerWords)
            {
                string line = readerWords.ReadLine();
                while (line != null)
                {                       
                    dictionary.Add(line, 0);
                    line = readerWords.ReadLine();
                }
            }

            using (readerText)
            {
                string line = readerText.ReadLine();
                while (line != null)
                {
                    List<string> wordList = new List<string>(dictionary.Keys);

                    foreach (string word in wordList)
                    {
                        string regex = String.Format(@"\b{0}\b", word);
                        MatchCollection matches = Regex.Matches(line, regex);
                        dictionary[word] += matches.Count;
                    }
                    line = readerText.ReadLine();
                }
            }

            using (writer)
            {
                foreach (var wordCount in dictionary.OrderByDescending(key => key.Value)) // we have to add using System.Linq; in order to sort it in descending order
                {
                    writer.Write(wordCount.Key);
                    writer.Write(" - ");
                    writer.WriteLine(wordCount.Value);
                }
            }
        }

        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
