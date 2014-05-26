// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class BinaryToHexademical
    {
        static StringBuilder BinToHex(string bin)
        {
            StringBuilder hex = new StringBuilder();

            string hexNumbers = "0123456789ABCDEF";
            string[] binRepOfHex = { "0000", "0001", "0010", "0011", "0100", "0101", "0110",
                                              "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            int remainder = bin.Length % 4;
            //adding zeroes if necessary
            if (remainder != 0)
            {
                bin = bin.PadLeft(((bin.Length / 4) + 1) * 4, '0');
            }

            for (int i = 0; i < bin.Length; i += 4)
            {
                //first we generate a substring with length = 4 == > 4 bits ("0001" for example)
                string fourDigits = bin.Substring(i, 4);
                //second we find the index(position) of this substring in our array.
                int index = Array.IndexOf(binRepOfHex, fourDigits);
                hex.Append(hexNumbers[index]);
            }
            return hex;
        }

        static void Main()
        {
            //Input
            Console.WriteLine("Please enter a binary number.");
            string binary = Console.ReadLine();
            //checking the input
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] != '0' && binary[i] != '1')
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }

            //Printing the result
            Console.WriteLine("Its hexademical representation is: ");
            Console.WriteLine(BinToHex(binary));
        }
    }



// If hex is a string, fourDigits is a string (for example "0001") - we can use the following code to convert the binary number to its hex represent.
// hex+= string.Format("{0:X}", Convert.ToByte(fourDigits, 2));