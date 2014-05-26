// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class LineByLineComparison
{
    static void Main()
    {
        int sameLines = 0;
        int differentLines = 0;
        StreamReader firstReader = new StreamReader(@"..\..\text1.txt", Encoding.GetEncoding("windows-1251"));
        StreamReader secondReader = new StreamReader(@"..\..\text2.txt", Encoding.GetEncoding("windows-1251"));

        using (firstReader)
        {
            using (secondReader)
            {
                string lineFirst = firstReader.ReadLine();
                string lineSecond = secondReader.ReadLine();
                while (lineFirst != null && lineSecond != null)
                {
                    if (lineFirst == lineSecond)
                    {
                        sameLines++;
                    }
                    else differentLines++;
                    lineFirst = firstReader.ReadLine();
                    lineSecond = secondReader.ReadLine();
                }
            }
        }
        Console.WriteLine("After comparing the two files there are {0} lines that are the same and {1} lines that are different!", sameLines, differentLines);

    }
}
