// Write a program that extracts from given XML file all the text without the tags. 
// http://www.codeproject.com/Articles/9099/The-30-Minute-Regex-Tutorial - solution with reg.expressions

using System;
using System.IO;
using System.Text.RegularExpressions;

class TextExtraction
{
     static void Main()
    {
        StreamReader input = new StreamReader(@"..\..\xml.txt");
        StreamWriter output = new StreamWriter(@"..\..\output.txt");

        using (input)
        {
            using (output)
            {
                string fileContent = input.ReadToEnd();
                string content = Regex.Replace(fileContent, "<(.*?)>", " ").Trim(); // + trim
                output.WriteLine(content);
            }
        }
    }
}
