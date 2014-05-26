// Write a program that concatenates two text files into another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class TextFilesConcatenation
{
    static void Main()
    {
        StreamReader readFile1 = new StreamReader(@"..\..\file1.txt");
        using (readFile1)
        {
            StreamReader readFile2 = new StreamReader(@"..\..\file2.txt");
            using (readFile2)
            {
                StreamWriter writeFile3 = new StreamWriter(@"..\..\final.txt");
                using (writeFile3)
                {
                    string line = readFile1.ReadLine();
                    while (line != null)
                    {
                        writeFile3.WriteLine(line);
                        line = readFile1.ReadLine();
                    }
                    line = readFile2.ReadLine();
                    while (line != null)
                    {
                        writeFile3.WriteLine(line);
                        line = readFile2.ReadLine();
                    }
                }
            }
        }
    }
}
