// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexademicalToBinary
{
    static void Main()
    {
        //Input
        Console.WriteLine("Please enter a hexadecimal number. ");
        string hexNum = Console.ReadLine().ToUpper(); // .ToUppper() will quarantee us a correct input if the entered hex num is "d" for example.
       
        //Output
        Console.WriteLine("The Binary representation of the given number is: \n{0}", TurnHexToBinary(hexNum));
    }

    static StringBuilder TurnHexToBinary(string hexNum)
    {
        StringBuilder binaryRep = new StringBuilder();
        for (int i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[i])
            {
                case '0':
                    binaryRep.Append("0000");
                    break;
                case '1':
                    binaryRep.Append("0001");
                    break;
                case '2':
                    binaryRep.Append("0010");
                    break;
                case '3':
                    binaryRep.Append("0011");
                    break;
                case '4':
                    binaryRep.Append("0100");
                    break;
                case '5':
                    binaryRep.Append("0101");
                    break;
                case '6':
                    binaryRep.Append("0110");
                    break;
                case '7':
                    binaryRep.Append("0111");
                    break;
                case '8':
                    binaryRep.Append("1000");
                    break;
                case '9':
                    binaryRep.Append("1001");
                    break;
                case 'A':
                    binaryRep.Append("1010");
                    break;
                case 'B':
                    binaryRep.Append("1011");
                    break;
                case 'C':
                    binaryRep.Append("1100");
                    break;
                case 'D':
                    binaryRep.Append("1101");
                    break;
                case 'E':
                    binaryRep.Append("1110");
                    break;
                case 'F':
                    binaryRep.Append("1111");
                    break;
                default:
                    binaryRep.Append("");
                    break;
            }
        }
        return binaryRep;
    }
}