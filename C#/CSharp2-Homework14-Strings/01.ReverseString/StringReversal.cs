// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".

using System;
using System.Text; //StringBuilder

class StringReversal
{
    static void Main()
    {
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();

        //First Method
        StringBuilder reversedInput = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedInput.Append(input[i]);
        }
        Console.WriteLine("First method - The reversed string is: {0}", reversedInput);

        //SecondMethod
        char[] inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
        Console.WriteLine("Second method - The reversed string is: {0}", string.Join("", inputArray)); // we can't use the syntax Console.WriteLine("Second method - The reversed string is: {0}", inputArray); because it will print only the TYPE of the array. HOWEVER we can just use Console.WriteLine(inputArray). This will print the content of the array, not just its type.
        Console.WriteLine(inputArray);

        //Something useful Console.WriteLine(inputArray, 0, 5); - prints from index[0] with length 5. If the length(in our case 5) is > than the length of the array it will throw an exception.
    }
}