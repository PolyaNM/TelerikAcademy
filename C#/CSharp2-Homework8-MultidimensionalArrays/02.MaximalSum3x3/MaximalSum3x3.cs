// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum3x3
{
    
    static void Main()
    {
        //Input
        Console.WriteLine("Enter the number of rows in the matrix.");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns in the matrix.");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows,columns];

        //reading the elements of the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Matrix[{0}, {1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //Solution
        int currentSum = 0;
        int maxSum = int.MinValue;
        int startRow = -1;
        int startCol = -1;

        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < columns - 2; j++)
            {
                for (int iRow = i; iRow < i + 3; iRow++)
                {
                    for (int jCol = j; jCol < j + 3; jCol++)
                    {
                        currentSum += matrix[iRow, jCol];
                    }
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startRow = i;
                    startCol = j;
                }

                currentSum = 0;
            }
        }

        //Output
        Console.WriteLine("The square 3 x 3 that has maximal sum of its elements is:");
        for (int squareRow = startRow; squareRow < startRow + 3; squareRow++)
        {
            for (int squareCol = startCol; squareCol < startCol + 3; squareCol++)
            {
                Console.Write("{0, -4}", matrix[squareRow, squareCol]);
            }
            Console.WriteLine();
        }
    }
}
