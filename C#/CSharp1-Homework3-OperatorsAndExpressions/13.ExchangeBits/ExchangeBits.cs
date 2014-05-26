//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter an unsigned 32-bit integer : ");
        uint inputNumber = uint.Parse(Console.ReadLine());
        uint mask = 7;  // the binary code of 7 is 0111
        int position1 = 3;
        int position2 = 24;

        // take the 3,4,5 (first sequence) bit and the 24,25,26 bit (second sequence);
        uint firstSequence = inputNumber & (mask << position1);
        uint secondSequence = inputNumber & (mask << position2);

        // set value 0 for bits 3,4,5,24,25,26 of our number
        inputNumber = inputNumber & ~(mask << position1);
        inputNumber = inputNumber & ~(mask << position2);

        // moving the 2  sequences in their new positions
        int newPosition = position2 - position1; //21
        inputNumber |= (firstSequence << newPosition);
        inputNumber |= (secondSequence >> newPosition);

        Console.WriteLine("The number after exchanging bits 3,4,5 with 24,25,26 bits is : " + inputNumber);
    }
}
