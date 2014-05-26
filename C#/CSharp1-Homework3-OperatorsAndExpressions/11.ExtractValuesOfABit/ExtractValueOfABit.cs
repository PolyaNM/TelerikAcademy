//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

    class ExtractValueOfABit
    {
        static void Main()
        {
            Console.Write("Enter an integer number : ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Bit position : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("The value of the bit at position {0} is : ", b);
            Console.WriteLine(0 == (i & (1 << b)) ? 0 : 1);
        }
    }
