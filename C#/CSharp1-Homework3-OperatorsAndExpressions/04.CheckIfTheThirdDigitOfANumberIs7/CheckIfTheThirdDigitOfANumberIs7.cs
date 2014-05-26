//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class CheckIfTheThirdDigitOfANumberIs7
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer");
        int inputNumber = int.Parse(Console.ReadLine());
        bool thirdDigit = (inputNumber / 100) % 10 == 7;
        Console.WriteLine("The third digit (right-to-left) of the number is 7? " + thirdDigit);
    }
}

