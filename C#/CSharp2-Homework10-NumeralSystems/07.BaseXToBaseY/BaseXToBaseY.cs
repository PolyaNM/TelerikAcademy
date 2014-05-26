// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

//First we convert the number from base S to base 10. Next we convert the number from base 10 to base D.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BaseXToBaseY
{
    static void Main()
    {
        //Input
        Console.WriteLine("This program will convert a number from one numeral system of base S to another numeral system of base D");
        Console.WriteLine("Please enter a number");
        string inputNum = Console.ReadLine();
        Console.WriteLine("Please enter the two bases S and D. S must be >=2 , D must be <= 16");
        Console.Write("Please enter base S = ");
        int baseS = int.Parse(Console.ReadLine());
        Console.Write("Please enter base D = ");
        int baseD = int.Parse(Console.ReadLine());

        int decimalNum = ConvertBaseSToBase10(inputNum, baseS);
        StringBuilder numberBaseD = ConvertBase10ToBaseD(decimalNum, baseD);

        //Output 
        Console.WriteLine("Number {0} of base {1} = number {2} of base {3}", inputNum, baseS, numberBaseD,baseD);
    }

    static int GetNumber(char charInput)
    {
        if (charInput >= 'A') return charInput - 'A' + 10; // If hex = 'B' ==> the result will be 'B' - 'A' + 10 = 1+10 = 11.
        else return charInput - '0';
    }

    static char GetChar(int remainder)
    {
        if (remainder > 9)
        {
            return (char)('A' + remainder - 10);
        }
        else return (char)('0' + remainder);
    }

    static int ConvertBaseSToBase10(string input, int baseS)
    {
        int decimalNum = 0;
        for (int i = input.Length - 1, power = 1; i >= 0; i--, power *= baseS)
        {
            decimalNum += GetNumber(input[i]) * power;
        }
        return decimalNum;
    }

    static StringBuilder ConvertBase10ToBaseD(int decimalNum, int baseD)
    {
        StringBuilder numberBaseD = new StringBuilder();
        while (decimalNum > 0)
        {
            numberBaseD.Insert(0, GetChar(decimalNum % baseD));
            decimalNum /= baseD;
        }
        return numberBaseD;
   
    }
}
