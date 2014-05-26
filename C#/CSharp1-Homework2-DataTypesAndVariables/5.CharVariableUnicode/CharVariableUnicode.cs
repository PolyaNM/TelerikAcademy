//Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class CharVariableUnicode
{
    static void Main()
    {
        char var = '\u0048';
        Console.WriteLine(var);

        //char var1 = (char)72;
        //Console.WriteLine(var1);
    }
}

