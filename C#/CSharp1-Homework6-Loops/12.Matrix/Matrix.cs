

using System;

class Matrix
{
    static void Main()
    {
        {
            Console.WriteLine("Enter a positive integer number in the interval (0;20)");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= (row + n - 1); col++)
                {
                    Console.Write("{0,2} ", col);
                }
                Console.WriteLine();
            }
        }
    }
}
