//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

using System;

    class CountRepeatingValuesInArray
    {
        static int counter;
        static void CountRepeatingValues(double numberToCheck, double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (numberToCheck == array[i])
                {
                    counter++;
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Please, enter a number.");

            string input = Console.ReadLine();

            double number;
            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            double[] array = { 4, 6, 4.3, 12, 9, 8, 4.3, 6, 4.3 };  
      
            CountRepeatingValues(number, array);
            Console.WriteLine("Number {0} appears {1} times in the given array.", number, counter);
        }
    }
