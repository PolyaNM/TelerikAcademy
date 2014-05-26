// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.
// http://msdn.microsoft.com/en-us/library/dwhawy9k.aspx

using System;

    class NumberFormat
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            // Decimal
            Console.WriteLine("{0,15}", number);
            // Hexadecimal
            Console.WriteLine("{0,15:X}", number);
            // Percentage
            Console.WriteLine("{0,15:P}", number);
            // Scientific notation
            Console.WriteLine("{0,15:E}", number); 
        }
    }
