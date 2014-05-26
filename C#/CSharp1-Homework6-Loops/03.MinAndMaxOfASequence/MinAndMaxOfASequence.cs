//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxOfASequence
{
    static void Main()
    {
        Console.Write("Enter an integer number N = ");
        int N = int.Parse(Console.ReadLine());
        if (N < 2)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int smallestNum = int.MaxValue;
        int biggestNum = int.MinValue;
        for (int i = 0; i < N; i++)
        {
            int currentNumber;
            bool isInputValid = int.TryParse(Console.ReadLine(), out currentNumber);
            if (isInputValid == false)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            if (smallestNum > currentNumber)
            {
                smallestNum = currentNumber;
            }
            if (biggestNum < currentNumber)
            {
                biggestNum = currentNumber;
            }
        }
        Console.WriteLine(smallestNum);
        Console.WriteLine(biggestNum);
    }
}
