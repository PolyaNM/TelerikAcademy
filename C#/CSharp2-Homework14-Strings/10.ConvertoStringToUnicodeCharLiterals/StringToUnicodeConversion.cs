// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input: Hi! Output:\u0048\u0069\u0021


using System;

class StringToUnicodeConversion
{
    static void Main()
    {
        Console.WriteLine("Enter a string.");
        string input = Console.ReadLine();

        foreach (var symbol in input)
        {
            Console.Write("\\u{0:X4}", (int)symbol);
        }
        Console.WriteLine();
    }
}


