// Write a program that generates and prints to the console 10 random values in the range [100, 200].

//http://msdn.microsoft.com/en-us/library/system.random(v=vs.110).aspx

using System;

class GenerateRandomValues
{
    static void Main()
    {
        Random randomNumber = new Random();
        for (int i = 0; i < 10; i++)
        {
            int number = randomNumber.Next(100, 201);
            Console.WriteLine("{0}", number);
        }
    }
}
