using System;

//Create console application that prints your first and last name.

class PrintFirstLastName
{
    static void Main()
    {
        Console.Write("Your first name is: ");
        string firstName = Console.ReadLine();
        Console.Write("Your last name is: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Your name is {0} {1}.", firstName, lastName);
    }
}

