using System;

class PrintName
{
    static void Main()
    {
        Console.WriteLine("Please enter your first name.");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is {0}", name);
    }
}

