// You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example: string = "43 68 9 23 318"  result = 461

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfNumbersInString
{
    static int CalculateSum(string input)
    {
        //Solution
        string[] strArray = input.Split(' ');
        int sum = 0;
        for (int i = 0; i < strArray.Length; i++)
        {
            sum += int.Parse(strArray[i]);
        }
        return sum;
    }

    static void Main()
    {
        //Input
        Console.WriteLine("57 90 569 12");
        string input = "57 90 569 12";
        //Output
        Console.WriteLine("The sum of the numbers in the string is: {0}", CalculateSum(input));
    }
}
