// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

using System;

class BracketsCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter an expression!");
        string input = Console.ReadLine();
        int leftBracketCounter = 0;
        char leftBracket = '(';
        int rightBracketCounter = 0;
        char rightBracket = '(';

        //The brackets are put correctly if rightBracketCounter == leftBracketCounter 
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == leftBracket)
            {
                leftBracketCounter++;
            }
            else if (input[i] == rightBracket)
	        {
                rightBracketCounter++;
	        }
        }

        //output
        if (leftBracketCounter == rightBracketCounter && leftBracketCounter != 0)
        {
            Console.WriteLine("The brackets are put correctly.");
        }
        else if (leftBracketCounter == rightBracketCounter && leftBracketCounter == 0)
        {
            Console.WriteLine("There are no brackets in the expression.");
        }
        else
        {
            Console.WriteLine("The brackets are NOT put correctly.");
        }
    }
}
