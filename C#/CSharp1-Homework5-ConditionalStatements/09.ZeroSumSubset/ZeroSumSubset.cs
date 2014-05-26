// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

class ZeroSumSubset
{
    static void Main()
    {
        Console.WriteLine("Enter five integers to see if the sum of some subset is 0.");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i <= 1; i++)
        {
            for (int j = 0; j <= 1; j++)
            {
                for (int k = 0; k <= 1; k++)
                {
                    for (int l = 0; l <= 1; l++)
                    {
                        for (int m = 0; m <= 1; m++)
                        {
                            if ((i != 0) || (j != 0) || (k != 0) || (l != 0) || (m != 0))
                            {
                                sum = i * a + j * b + k * c + l * d + m * e;

                                if (sum == 0)
                                {
                                    if (i != 0)
                                    {
                                        Console.Write(a + "; ");
                                    }
                                    if (j != 0)
                                    {
                                        Console.Write(b + "; ");
                                    }
                                    if (k != 0)
                                    {
                                        Console.Write(c + "; ");
                                    }
                                    if (l != 0)
                                    {
                                        Console.Write(d + "; ");
                                    }
                                    if (m != 0)
                                    {
                                        Console.Write(e + "; ");
                                    }

                                    Console.WriteLine("Sum = 0");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}