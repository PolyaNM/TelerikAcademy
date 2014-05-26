// Modify the solution of the previous problem to replace only whole words (not substrings).
// Solution with regular expressions

using System;
using System.IO;
using System.Text.RegularExpressions;


class ReplaceSubstring
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\temp.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string newLine = Regex.Replace(line, @"\b(start)\b", "finish");
                    writer.WriteLine(newLine);
                    line = reader.ReadLine();
                }
            }
        }
        File.Delete(@"..\..\test.txt");
        File.Move(@"..\..\temp.txt", @"..\..\test.txt"); 
    }
}