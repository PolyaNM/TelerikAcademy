// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Text;
 
    class SumNumbersAsArrays
    {
        private static string SumTwoArrays(byte[] firstArray, byte[] secondArray)
        {
            List<byte> maxArray = new List<byte>();
            List<byte> minArray = new List<byte>();
            // determine which array has more elements and after that add elements to min and max array
            if (firstArray.Length > secondArray.Length)
            {
                maxArray.AddRange(firstArray);
                minArray.AddRange(secondArray);
            }
            else
            {
                maxArray.AddRange(secondArray);
                minArray.AddRange(firstArray);
            }

            int minLength = minArray.Count;
            int maxLength = maxArray.Count;
            int addition = 0;
            int sum;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < minLength; i++)
            {
                sum = minArray[i] + maxArray[i] + addition;
                if (sum >= 10)
                {
                    addition = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    addition = 0;
                }
            }

            for (int j = minLength; j < maxLength; j++)
            {
                sum = maxArray[j] + addition;
                if (sum >= 10)
                {
                    addition = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    addition = 0;
                }
            }
            if (addition == 1)
            {
                result.Append(1);
            }
            char[] reversed = (result.ToString()).ToCharArray();
            result.Clear();
            for (int i = reversed.Length - 1; i >= 0; i--)
            {
                result = result.Append(reversed[i]);
            }
            return result.ToString();
        }

        //MAIN
        static void Main(string[] args)
        {
            // Input - the numbers are represented as arrays - the first element in the array is the last digit of the number
            byte[] firstArray = { 5, 4, 2 };
            Console.WriteLine("First array : " + string.Join("", firstArray));
            byte[] secondArray = { 8, 3, 8, 7, 7, 9, 1 };
            Console.WriteLine("Second array : " + string.Join("", secondArray));

            string sum = SumTwoArrays(firstArray, secondArray);
            Console.WriteLine("The sum of the two positive integers is {0}", sum);
        }
    }