// Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a number in binary representation");
        string binary = Console.ReadLine();
        //Checking the input
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] != '0' && binary[i] != '1')
            {
                Console.WriteLine("Invalid Input!");
                return;
            }
        }

        //Output 
        Console.WriteLine("The decimal representation of the binary number is : {0}", ConvertBinaryToDecimal(binary));
    }

    static int ConvertBinaryToDecimal(string binary)
    { 
        int decimalNum = 0;
        for (int i = binary.Length - 1, power = 1; i >= 0; i--, power *= 2)
        {
            decimalNum += (binary[i] - '0') * power; // binary[i] - '0' == binary[i] - 48. In our case - 0 or 1;
        }
        return decimalNum;
    }
}
