// Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsFromTextFile
{
    static void Main(string[] args)
    {
        try
        {
            string filePath = @"..\..\text.txt";
            string wordsPath = @"..\..\words.txt";


            List<string> words = new List<string>();
            using (StreamReader reader = new StreamReader(wordsPath))
            {
                string word = reader.ReadLine();
                while (word != null)
                {
                    words.Add(word);
                    word = reader.ReadLine();
                }
            }

            string wordPattern = string.Join("|", words.ToArray());
            string pattern = string.Format(@"\b({0})\b", wordPattern);
            Regex regRemove = new Regex(pattern, RegexOptions.Compiled);

            using (StreamWriter write = new StreamWriter(@"..\..\temp.txt"))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string newLine = regRemove.Replace(line, string.Empty);
                        write.WriteLine(newLine);
                        line = reader.ReadLine();
                    }
                }
            }

            File.Delete(filePath);
            File.Move(@"..\..\temp.txt", filePath);
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