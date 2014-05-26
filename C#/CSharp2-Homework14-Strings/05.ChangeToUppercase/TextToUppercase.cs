// You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

using System;

class TextToUppercase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine("Before : {0}", text);
        string firstTag = "<upcase>";
        string secondTag = "</upcase>";
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < text.Length - 8; i++)
        {
            if (text.Substring(i, firstTag.Length) == firstTag) // if the substring is <upcase>
            {
                startIndex = i + firstTag.Length;
                i = startIndex;
            }
            if (text.Substring(i, secondTag.Length) == secondTag) //if the substring is </upcase>
            {
                endIndex = i;
                int lengthSubstring = endIndex - startIndex;
                string strUppercase = text.Substring(startIndex, lengthSubstring).ToUpper();
                text = text.Remove(startIndex, lengthSubstring);
                text = text.Insert(startIndex, strUppercase);

                text = text.Remove(startIndex - 8, firstTag.Length);
                text = text.Remove(endIndex - 8, secondTag.Length);
            }
        }
        Console.WriteLine("After : {0}", text);
    }
}

