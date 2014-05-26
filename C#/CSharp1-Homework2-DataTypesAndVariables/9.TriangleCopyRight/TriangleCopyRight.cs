//Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

using System;

class TriangleCopyRight
{
    static void Main()
    {
        char symbol = '\u00a9';
        int numberOfRows = 7; // change this if you want bigger/smaller triangle

        for (int i = 0; i < numberOfRows; i++)
        {
            Console.Write(new string(' ', numberOfRows - i - 1));
            Console.Write(new string(symbol, 1 + 2 * i));
            Console.WriteLine(new string(' ', i + 1));
        }
    }
}

