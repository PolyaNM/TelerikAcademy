//Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 
//Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. 
//Does your program work for N = 50 000?

using System;

class ZerosAtTheEndInNFactorial
{
    static void Main()
    {
        Console.Write("Enter an integer number N = ");
        int n = int.Parse(Console.ReadLine());
        int five = 5;
        int counter = 0;
        int divider = 1;

        //The number of the zeroes at the end of N! = n/5 + n/25 + n/125 + ...

        while (divider > 0)
        {
            counter += n / five;
            divider = n / five;
            five = five * 5;
        }
        Console.WriteLine("There are {0} zeros in N", counter);      
    }
}
