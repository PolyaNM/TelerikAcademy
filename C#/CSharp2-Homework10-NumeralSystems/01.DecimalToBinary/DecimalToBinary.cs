// Write a program to convert decimal numbers to their binary representation.


//The program works only for positive numbers!
using System;
using System.Collections.Generic;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        // Input
        Console.WriteLine("Please enter a decimal number");
        int number = int.Parse(Console.ReadLine());

        StringBuilder binary = new StringBuilder();
        // Solution
        while (number > 0)
        {
            binary.Insert(0, number % 2); // inserts "0" or "1" at position 0 in StringBuilder binary. 
            number = number / 2;
        }

        //Output - printing 
        Console.WriteLine(string.Join(" ", binary));
    }
}
