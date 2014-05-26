// Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\temp.txt"))
            {
                string line = reader.ReadLine();// reads the first (odd) line
                while ((line = reader.ReadLine()) != null) // reads the even lines
                {
                    writer.WriteLine(line); // prints the even lines
                    line = reader.ReadLine(); //reads the odd lines
                }
            }
        }

        File.Delete(@"..\..\test.txt");
        File.Move(@"..\..\temp.txt", @"..\..\test.txt"); // 
    }
}
