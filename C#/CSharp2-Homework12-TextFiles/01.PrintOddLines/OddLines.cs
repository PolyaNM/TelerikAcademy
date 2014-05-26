// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class OddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\project.txt"))
        { 
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
        }

    }
}
