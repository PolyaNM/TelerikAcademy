/* Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
 * 
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseDigitsAverageLinearEquation
    {

        static void PrintMenu()
        {
            Console.WriteLine("---------------Choose a task number---------------");
            Console.WriteLine("1.Reverse the digits of a number");
            Console.WriteLine("2.Calculates the average of a sequence of integers");
            Console.WriteLine("3.Solves a linear equation a * x + b = 0");
            Console.WriteLine("--------------------------------------------------");  
        }
        static void ReadInputData()
        {
            //checking if the task number is in the interval [1,3]
            int task = int.Parse(Console.ReadLine());
            if (task > 3 || task < 1)
            {
                Console.WriteLine("Invalid Input!");
            }

            //TASK 1: (reverse digits)
            else if (task == 1)
            {
                Console.WriteLine("Enter a non-negative decimal number.");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Invalid input. You entered a negative number!");
                }
                else
                {
                    int reversed = ReverseDigits(number); /////////////METHODDDDDD
                    Console.WriteLine("The reversed number is: {0}", reversed);
                }
                
            }

            //TASK 2: (calculate average of a sequence of integers)
            else if (task == 2)
            {
                Console.WriteLine("Enter how many integer numbers will be in the sequence");
                int seqLength = int.Parse(Console.ReadLine());
                if (seqLength <= 0)
                {
                    Console.WriteLine("Invalid input. The sequence MUST have at least one element!");
                }
                else
                {
                    Console.WriteLine("Enter the elements of the sequence");
                    int[] sequence = new int[seqLength];
                    for (int i = 0; i < seqLength; i++)
                    {
                        Console.Write("Element {0} --> ", i);
                        sequence[i] = int.Parse(Console.ReadLine());
                    }
                    //Solution
                    double average = CalculateAverage(sequence);
                    Console.WriteLine("The average of the sequence is: {0:0.00}", average);
                }
            }

            // TASK 3: (Solves a linear equation a * x + b = 0)
            else if (task == 3)
            {
                //input
                Console.WriteLine("Enter the coefficients of the eqiation -- a * x + b = 0");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                if (a == 0.0)
                {
                    Console.WriteLine("Invalid input. The coefficient \"a\" can't be zero.");
                    return;
                }
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());

                //solution
                double result = SolveEquation(a, b);
                Console.WriteLine("The result of the equation is  x = {0}", result);
            }
        }

        static int ReverseDigits(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                reversed = (reversed * 10) + (number % 10);
                number /= 10;
            }
            return reversed;
        }

        static double CalculateAverage(int[] sequence)
        {
            int seqLength = sequence.Length;
            int sum = 0;
            foreach (int element in sequence)
            {
                sum += element;
            }

            return (double)sum / seqLength; // cast to double
        }

        static double SolveEquation(double a, double b)
        {
            double result = - b / a;
            return result;
        }

        static void Main()
        {
            PrintMenu();
            ReadInputData();
        }
    }
