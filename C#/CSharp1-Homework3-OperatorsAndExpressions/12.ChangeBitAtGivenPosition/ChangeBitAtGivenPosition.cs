// We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
// Example: n = 5 (00000101), p=3, v=1  13 (00001101) 
// Example: n = 5 (00000101), p=2, v=0  1 (00000001)


using System;

class ChangeBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value (0 or 1): ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            value = ~(1 << bitPosition);
            value = value & inputNumber;
            Console.WriteLine("The modified number is {0}", value);
        }
        else
        {
            value = 1 << bitPosition;
            value = value | inputNumber;
            Console.WriteLine("The modified number is {0}", value);
        }
    }
}
