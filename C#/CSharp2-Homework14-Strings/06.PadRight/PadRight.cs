// Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

using System;

class PadRight
{
    static void Main()
    {
        Console.WriteLine("Please enter a string");
        string str = Console.ReadLine();
        if (str.Length > 20)
        {
            Console.WriteLine(str.Substring(0, 20));  
        }
        else
        {
            Console.WriteLine(str.PadRight(20, '*'));
        }
    }
}
