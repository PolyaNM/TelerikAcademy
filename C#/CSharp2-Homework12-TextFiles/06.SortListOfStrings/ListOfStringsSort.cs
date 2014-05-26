// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ListOfStringsSort
{
    static void Main()
    {
        string filePath = @"..\..\Strings.txt";
        string outputPath = @"..\..\SortedStrings.txt";
        
        List<string> listStrings = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                listStrings.Add(line);
                line = reader.ReadLine();
            }
        }
        //sorts the list of strings
        listStrings.Sort();

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            for (int i = 0; i < listStrings.Count; i++)
            {
                writer.WriteLine(listStrings[i]);
            }
        }
    }
}
