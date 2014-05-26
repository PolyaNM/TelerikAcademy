// Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        StreamReader read = new StreamReader("../../text.txt");
        StreamWriter write = new StreamWriter("../../temp.txt");

        using (read)
        {
            using (write)
            {
                string line = read.ReadLine();
                while (line != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*(\s|\S)\b", "");
                    write.WriteLine(line);
                    line = read.ReadLine();
                }
            }
        }

        File.Delete(@"..\..\text.txt");
        File.Move(@"..\..\temp.txt", @"..\..\text.txt"); 
    }
}
