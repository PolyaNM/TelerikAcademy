// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 

// NB! All diagonals must be included - from top left to bottom right AND from top right to bottom left.

using System;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        ////Input
        //Console.WriteLine("Enter the number of rows in the matrix.");
        //int rows = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the number of columns in the matrix.");
        //int columns = int.Parse(Console.ReadLine());

        //int[,] matrix = new int[rows, columns];

        ////reading the elements of the matrix
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < columns; j++)
        //    {
        //        Console.Write("Matrix[{0}, {1}] = ", i, j);
        //        matrix[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}

        string[,] matrix = new string[,] { { "ma", "li", "ro", "hi" }, { "ma", "ha", "hi", "zz" }, { "ma", "li", "ro", "zz" } };

        //Solution
        int currentSeq = 1;
        int maxSeq = 1;
        string maxElement = "";
        int direction = 0; 
 
        //1.HORIZONTAL (left to right)
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                if (matrix[rows, cols] == matrix[rows, cols + 1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }
 
                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                    maxElement = matrix[rows, cols];
                    direction = 1;
                }
            }
            currentSeq = 1;
        }
 
        //2.VERTICAL (top to bottom)
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                if (matrix[rows, cols] == matrix[rows + 1, cols])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }
 
                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                    maxElement = matrix[rows, cols];
                    direction = 2;
                }
            }
            currentSeq = 1;
        }
 
        //3. DIAGONAL (top right to bottom left)
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols > 0; rows++, cols--)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols - 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }
 
                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                        direction = 4;
                    }
                }
                currentSeq = 1;
            }
        }

        //4.DIAGONALS (top left to bottom right)
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols < matrix.GetLength(1) - 1; rows++, cols++)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols + 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }
 
                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                        direction = 3;
                    }
                }
                currentSeq = 1;
            }
        }

        Console.WriteLine("The longest sequence of equal strings in the matrix is: ");

        switch (direction)
        {
            case 1:
                Console.WriteLine("{0} - {1} times horizontally.", maxElement, maxSeq);
                break;
            case 2:
                Console.WriteLine("{0} - {1} times vertically.", maxElement, maxSeq);
                break;
            case 3:
                Console.WriteLine("{0} - {1} times diagonally (from top right to bottom left).", maxElement, maxSeq);
                break;
            case 4:
                Console.WriteLine("{0} - {1} times diagonally (from top left to bottom right).", maxElement, maxSeq);
                break;
            default:  break;
        }
    }
}
