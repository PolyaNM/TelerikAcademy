using System;

class TestBitArray
{
    static void Main()
    {
        BitArray test = new BitArray();

        test[12] = 1;
        test[35] = 1;
        test[5] = 1;
        test[55] = 1;
        Console.WriteLine(test);

        test[63] = 1;
        Console.WriteLine(test);
    }
}
