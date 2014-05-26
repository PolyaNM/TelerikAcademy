// Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\file.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");
            using (writer)
            {
                int lineNum = 1;
                string line = reader.ReadLine();
                while (line!= null)
                {
                    writer.WriteLine("{0}. {1}", lineNum, line);
                    line = reader.ReadLine();
                    lineNum++;
                }
            }
        }
    }
}
