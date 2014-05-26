// Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

class CheckIfAGivenBitIs1
{
    static void Main()
    {
        Console.Write("Enter an integer number : ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.Write("Bit position : ");
        int bitPosition = int.Parse(Console.ReadLine());
        bool isBitOne = 0 != (inputNumber & (1 << bitPosition));
        Console.WriteLine("Is the bit at position {0} (counting from 0) of the given integer 1? {1}", bitPosition, isBitOne);
    }
}
