//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class FindTheThirdBitOfANumber
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int mask = 8; // 1000
        Console.WriteLine(((inputNumber & mask) == 0) ? "The third bit is 0" : "The third bit is 1" );
    }
}
