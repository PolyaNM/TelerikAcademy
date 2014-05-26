//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfNNumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int sum = 0;
        int currentNum = 0;
        for (int i = 0; i < numberN; i++)
        {
            currentNum = int.Parse(Console.ReadLine());
            sum = sum + currentNum;
        }
        Console.WriteLine(sum);
    }
}
