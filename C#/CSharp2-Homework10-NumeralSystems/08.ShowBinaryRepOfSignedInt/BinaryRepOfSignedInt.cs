// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryRepOfSignedInt
{
    static void Main()
    {
        Console.Write("Enter a 16-bit signed number: ");
        int number = int.Parse(Console.ReadLine());
        StringBuilder binaryNumber = new StringBuilder();

        List<int> binDigits = new List<int>();

        if (number >= 0)
        {
            while (number != 0)
            {
                binDigits.Add(number % 2);
                number /= 2;
            }

            binDigits.Reverse();

            for (int i = 0; i < binDigits.Count; i++)
            {
                binaryNumber.Append(binDigits[i]);
            }

            while (binaryNumber.Length % 16 != 0)
            {
                binaryNumber.Insert(0, '0');
            }
        }
        else // number < 0
        {
            number = Math.Abs(number) - 1;

            while (number != 0)
            {
                binDigits.Add(number % 2);
                number /= 2;
            }

            binDigits.Reverse();

            for (int i = 0; i < binDigits.Count; i++)
            {
                if (binDigits[i] == 0)
                {
                    binaryNumber.Append('1');
                }
                else
                {
                    binaryNumber.Append('0');
                }
            }

            while (binaryNumber.Length % 16 != 0)
            {
                binaryNumber.Insert(0, '1');
            }
        }
        Console.Write("The binary representation of the number is: ");
        Console.WriteLine(binaryNumber);
    }
}
