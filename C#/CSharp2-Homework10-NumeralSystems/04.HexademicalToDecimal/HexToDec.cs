// Write a program to convert hexadecimal numbers to their decimal representation.

/*FIRST METHOD
string hexValue = "76C";
int decValue = Convert.ToInt32(hexValue, 16);
Console.WriteLine(decValue);
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToDec
{
    static void Main()
    {
        Console.WriteLine("Enter a number in hexademical representation");
        string hex = Console.ReadLine();

        //Output 
        Console.WriteLine("The decimal representation of the hexademical number is : {0}", ConvertBinaryToDecimal(hex));
    }

    static int GetNumber(char hex)
    {
        if (hex >= 'A') return hex - 'A' + 10; // If hex = 'B' ==> the result will be 'B' - 'A' + 10 = 1+10 = 11.
        else return hex - '0';
    }

    static int ConvertBinaryToDecimal(string hex)
    {
        int decimalNum = 0;
        for (int i = hex.Length - 1, power = 1; i >= 0; i--, power *= 16)
        {
            decimalNum += GetNumber(hex[i]) * power;
        }
        return decimalNum;
    }
}
