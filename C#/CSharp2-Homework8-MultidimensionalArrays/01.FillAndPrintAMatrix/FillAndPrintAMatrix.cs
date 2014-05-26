// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class FillAndPrintAMatrix
{
    static void Main()
    {
        //Input
        Console.WriteLine("Please enter the size of the matrix (n,n), where N = ");
        int n;
        bool result = Int32.TryParse(Console.ReadLine(), out n);
        if (!result)
        {
            Console.WriteLine("Invalid input!");
        }

        int[,] intMatrix = new int[n, n];

        //A) >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        int k = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                intMatrix[row, col] = k;
                k++;
            }
        }
        //Prints the matrix
        Console.WriteLine("version A)");
        PrintMatrix(n, intMatrix);
        
        //Resets the values
        k = 1;
        Array.Clear(intMatrix, 0, intMatrix.Length);


        //B) >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    intMatrix[row, col] = k;
                    k++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    intMatrix[row, col] = k;
                    k++;
                }
            }
        }
        
        //Prints the matrix
        Console.WriteLine("version B)");
        PrintMatrix(n, intMatrix);
       
        //Resets the values
        k = 1;
        Array.Clear(intMatrix, 0, intMatrix.Length);


        //C) >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        int counter = 1;

        for (int i = 0; i < n; i++)
            for (int j = 0; j <= i; j++)
            {
                intMatrix[n - i + j - 1, j] = counter;
                counter++;
            }

        for (int i = n - 2; i >= 0; i--)
            for (int j = i; j >= 0; j--)
            {
                intMatrix[i - j, n - j - 1] = counter;
                counter++;
            }

        
        //Prints the matrix
        Console.WriteLine("version C)");
        PrintMatrix(n, intMatrix);
        
        //Resets the values
        k = 1;
        Array.Clear(intMatrix, 0, intMatrix.Length);

    }

    // Printing method
    private static void PrintMatrix (int n, int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,-3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

