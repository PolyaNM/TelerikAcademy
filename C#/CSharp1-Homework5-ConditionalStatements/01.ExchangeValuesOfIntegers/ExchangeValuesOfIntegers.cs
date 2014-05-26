//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class ExchangeValuesOfIntegers
{
    static void Main()
    {
        Console.Write("Enter first integer number a : ");
        long firstNum = long.Parse(Console.ReadLine());
        Console.Write("Enter second integer number b : ");
        long secondNum = long.Parse(Console.ReadLine());
        if (firstNum > secondNum)
        {
            secondNum = firstNum + secondNum;
            firstNum = secondNum - firstNum;
            secondNum = secondNum - firstNum;
        }
        Console.WriteLine("a = {0}",firstNum);
        Console.WriteLine("b = {0}", secondNum);
    }
}
