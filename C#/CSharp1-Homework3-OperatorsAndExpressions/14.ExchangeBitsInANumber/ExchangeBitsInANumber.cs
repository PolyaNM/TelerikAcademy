//Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class ExchangeBitsInANumber
{
    static void Main()
    {
        Console.Write("Enter positive integer number : n = ");
        int n = int.Parse(Console.ReadLine());                                               
        Console.Write("Enter the bit position to start with : p = ");
        int p = int.Parse(Console.ReadLine());                            
        Console.Write("Enter the bit position to exchange with : q = ");
        int q = int.Parse(Console.ReadLine());                              
        Console.Write("Enter how many bits you want to exchange : k = ");
        int k = int.Parse(Console.ReadLine());                              

        for (int i = p, j = q; i < p + k ; i++, j++)
        {

            //checking which bits in these positions are 0 and 1
            int maskP = 1 << i;
            int maskQ = 1 << j;
            int bitP = (n & maskP);
            int bitQ = (n & maskQ);

            //bits at positions {p, p+1, …, p+k-1) go to bits at positions {q, q+1, …, q+k-1}
            if (bitP == 0)
            {
                int replacer = 1 << j;
                n &= ~replacer;
            }
            else
            {
                int replacer = 1 << j;
                n |= replacer;
            }

            //bits at positions {q, q+1, …, q+k-1} go to bits at positions {p, p+1, …, p+k-1)
            if (bitQ == 0)
            {
                int replacer = 1 << i;
                n &= ~replacer;
            }
            else
            {
                int replacer = 1 << i;
                n |= replacer;
            }
        }

        Console.WriteLine("The number after bit changes is: {0}", n);
    }
}
