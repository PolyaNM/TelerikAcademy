//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class DivisibleBy5
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integer numbers.");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        // First method - with loops (it is slower when the numbers are bigger)    
        /*int counter = 0;
        int i = 0;
        firstNumber = Math.Min(firstNumber, secondNumber);
        secondNumber = Math.Max(firstNumber, secondNumber);

        for (i = firstNumber; i <= secondNumber; i++)
        { 
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);*/

        //Second method

        int numbersInInterval = (Math.Abs(firstNumber - secondNumber)) + 1;
        int numbersDivisibleBy5;
        if (numbersInInterval % 5 == 0)
        {
            numbersDivisibleBy5 = numbersInInterval / 5;
        }
        else
        {
            numbersDivisibleBy5 = (numbersInInterval / 5) + 1;
        }
        Console.WriteLine(numbersDivisibleBy5);
    }
}