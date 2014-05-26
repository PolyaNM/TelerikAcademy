// Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    string newLine = line.Replace("start", "finish");
                    writer.WriteLine(newLine);
                    line = reader.ReadLine();
                }
            }
        }

        File.Delete(@"..\..\test.txt");
        File.Move(@"..\..\temp.txt", @"..\..\test.txt"); 
    }
}
