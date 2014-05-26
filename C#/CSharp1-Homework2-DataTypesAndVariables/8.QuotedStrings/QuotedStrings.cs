/*Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties.
Do the above in two different ways: with and without using quoted strings.*/


using System;

class QuotedStrings
{
    static void Main()
    {
        string var1 = "The \"use\" of quotations causes difficulties.";
        string var2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(var1);
        Console.WriteLine(var2);
    }
}

