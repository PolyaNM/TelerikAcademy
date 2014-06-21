// Write a program to return the string with maximum length from an array of strings. Use LINQ.

namespace MaxLengthString
{
    using System;
    using System.Linq;
    class MaxLengthStr
    {
        private static string maxLengthString;

        public static void Main()
        {
            var stringArray = new[] { "4853948", "4235", "7", "ssssss", "bb", "moncho", "blablablablabla", "iamthelongeststring" };

            maxLengthString = string.Empty;

            var result = from str in stringArray
                         where CompareToMax(str)
                         select str;

            Console.WriteLine(result.Last());
        }

        public static bool CompareToMax(string str)
        {
            if (str.Length >= maxLengthString.Length)
            {
                maxLengthString = str;
                return true;
            }
            return false;
        }
    }
}
