// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class NumbersInRange
    {
        static int ReadNumber(int start, int end)
        {
                int n = int.Parse(Console.ReadLine());
                if (!(start < n && n < end)) throw new ArgumentOutOfRangeException();

                return n;
        }

        static void Main()
        {
            //Input
            Console.WriteLine("The program reads 10 integer numbers in the range [min, max]. The numbers will be in ascending orger. ");
            Console.WriteLine("Please define the range [min, max]!");

            try
            {
                Console.Write("Min = ");
                int min = int.Parse(Console.ReadLine());
                Console.Write("Max = ");
                int max = int.Parse(Console.ReadLine());
                if (min > max)
                {
                    Console.WriteLine("Invalid input! The Max value must be bigger than the Min value!");
                    return;
                }

                for (int i = 0; i < 10; i++)
                {
                    min = ReadNumber(min, max);
                } 
            }

            // if the input is not an integer number
            catch (System.FormatException) 
            {
                Console.WriteLine("Not an integer number.");
            }
            // if the input is not in the specified range
            catch (System.ArgumentOutOfRangeException) 
            {
                Console.WriteLine("The entered number is not in the specified range OR it is smaller than the previous number.");
            }
            // if the input is out of INT32 range
            catch (System.OverflowException)
            {
                Console.WriteLine("Not in the scope of integer.");
            }
            // if the input is null
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Null is not an integer number.");
            }
        }
    }