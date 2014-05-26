//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumOfSequence
{
    static void Main()
    {
        // First method
        int sign = 1;
        double sum = 1;
        int n = 1000;
        for (double i = 2; i <= n; i++)
        {
            sum = sum + sign / i;
            sign *= -1;
        }
        Console.WriteLine("The sum is: {0:F3}", sum);

        //Second method
        /*
        double counter = 2;
        double sum = 1;
        int sign = 1;
        while (1 / counter >= 0.001)
        {
            sum = sum + (1 / counter) * sign;
            sign *= -1;
            counter++;
        }
        Console.WriteLine("sum = {0:0.000}", sum);
        */
    }
}