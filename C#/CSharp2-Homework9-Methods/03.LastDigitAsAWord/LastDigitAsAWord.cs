﻿// Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

class LastDigitAsAWord
{
    static void ReturnLastDigitAsAWord(int lastDigit)
    {
        switch (lastDigit)
        {
            case (1):
                Console.WriteLine("One");
                break;
            case (2):
                Console.WriteLine("Two");
                break;
            case (3):
                Console.WriteLine("Three");
                break;
            case (4):
                Console.WriteLine("Four");
                break;
            case (5):
                Console.WriteLine("Five");
                break;
            case (6):
                Console.WriteLine("Six");
                break;
            case (7):
                Console.WriteLine("Seven");
                break;
            case (8):
                Console.WriteLine("Eight");
                break;
            case (9):
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Zero");
                break;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        int lastDigit = Math.Abs(number % 10);              // we need Math.Abs because the entered integer number could be negative.
        ReturnLastDigitAsAWord(lastDigit);
    }
}
