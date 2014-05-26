// Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();

            try
            {
                uint number = uint.Parse(input);
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("The square root of {0} is {1}.", number, squareRoot);
            }

            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine("Exception: {0}", ex.Message);
            }

            catch (FormatException ex)
            {
                Console.Error.WriteLine("Exception: {0}", ex.Message);
            }

            catch (OverflowException ex)
            {
                Console.Error.WriteLine("Exception: {0}", ex.Message);
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
