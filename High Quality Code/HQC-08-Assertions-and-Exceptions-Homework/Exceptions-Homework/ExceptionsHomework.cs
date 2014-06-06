using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int length)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("Array cannot be null.");
        }

        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException("Start index cannot be negative.");
        }

        if (startIndex > arr.Length)
        {
            throw new ArgumentOutOfRangeException("Start index cannot be bigger than the length of the array.");
        }

        if (length < 0)
        {
            throw new ArgumentOutOfRangeException("The length cannot be negative.");
        }

        if (length == 0)
        {
            return new T[0];
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + length; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int length)
    {
        if (str == null)
        {
            throw new ArgumentNullException("String cannot be null.");
        }

        if (length < 0)
        {
            throw new ArgumentOutOfRangeException("Length cannot be negative.");
        }

        if (length > str.Length)
        {
            throw new ArgumentOutOfRangeException("Length cannot be bigger than the length of the string.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - length; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        if (number < 2)
        {
            throw new ArgumentOutOfRangeException("Only integer numbers greater than 1 can be primes.");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        try
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));

            bool isPrime = CheckPrime(23);
            if (isPrime)
            {
                Console.WriteLine("23 is prime.");
            }
            else
            {
                Console.WriteLine("23 is not prime");
            }

            isPrime = CheckPrime(33);
            if (isPrime)
            {
                Console.WriteLine("33 is prime.");
            }
            else
            {
                Console.WriteLine("33 is not prime");
            }
        }
        catch (ArgumentOutOfRangeException aoorex)
        {
            Console.WriteLine(aoorex.Message);
        }
        catch (ArgumentNullException anex)
        {
            Console.WriteLine(anex.Message);
        }
    }
}
