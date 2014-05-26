// Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class ReverseDigitsOfANumber
{
    static void Main()
    {
        //First Method - we can use it for numbers such as 242.23 or 0.774. First we turn the number into an array of chars, then we reverse the array by using Array.Reverse() method and print the result.
        /*
        Console.WriteLine("Enter your number:");
        string number = Console.ReadLine();
        char[] array = new char[number.Length];
         
        for (int i = 0; i < number.Length; i++)
            {
             array[i] = number[i];
            }
        Array.Reverse(array);
        Console.WriteLine(String.Join("", array));
        */


        //Second method - works only for integer numbers
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ReversedNumber(number));
    }

    static int ReversedNumber(int number)
    {
        int result = 0;
        while (number > 0)
        {
            result = result * 10 + number % 10;
            number = number / 10;
        }
        return result;
    }
}