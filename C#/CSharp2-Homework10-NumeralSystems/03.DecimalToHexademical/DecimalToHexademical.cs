// Write a program to convert decimal numbers to their hexadecimal representation. // Works only for positive integers

/* FIRST METHOD:
int decValue = 763;
string hexValue = decValue.ToString("X");
Console.WriteLine(hexValue);
*/

using System;
using System.Collections.Generic;

class DecimalToHexademical
{
    static char GetNumber(int remainder)
    {
        if (remainder > 9)  
        {
            return (char)('A' + remainder - 10);
        }
            else return (char)('0' + remainder);
    }

    static List<char> TurnDecimalToHex(int decimalNum)
    {
        List<char> hex = new List<char>();
        while (decimalNum > 0)
        {
            hex.Add(GetNumber(decimalNum % 16));
            decimalNum = decimalNum / 16;
        }
        hex.Reverse();
        return hex;
    }

    static void Main()
    {
        // Input
        Console.WriteLine("Please enter a decimal number!");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(string.Join("", TurnDecimalToHex(number)));
    }

}

