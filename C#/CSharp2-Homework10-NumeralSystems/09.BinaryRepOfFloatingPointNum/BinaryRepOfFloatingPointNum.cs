// * Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryRepOfFloatingPointNum
{
    static void Main()
    {
        Console.WriteLine("Please enter a 32-bit signed floating-point number");
        float number = float.Parse(Console.ReadLine());
        int sign = 0;

        //determine the sign of the number
        if (number < 0) 
        { 
            sign = 1; number = -1 * number; 
        }
        Console.WriteLine("Sign = {0}", sign);


        //determine the exponent of the number
        int exponent = 0;
        int i = 0;
        Console.Write("Exponent = ");


        for (i = 0; i <= number; i++) 
        {
            exponent = (int)Math.Pow(2, i);
            if (exponent >= number) break;
        }
        exponent = (i - 1) + 127;  

        //binary representation of the exponent
        for (int j = 7; j >= 0; j--)   
        {
            int multiple = (int)Math.Pow(2, j);
            int digit = (int)(exponent / multiple);
            exponent = exponent % multiple;
            Console.Write(digit);
        }
        Console.WriteLine();

        //determine the mantissa of the number
        Console.Write("Mantissa = ");

        double mantissa = (double)number / Math.Pow(2, i - 1);
        mantissa = mantissa - 1;

        for (i = 1; i < 24; i++)
        {
            double multiple = Math.Pow(2, -i);
            if (mantissa - multiple >= 0)
            {
                Console.Write(1);
                mantissa = mantissa - multiple;
            }
            else
            {
                Console.Write(0);
            }
        }
        Console.WriteLine();
    }
}
