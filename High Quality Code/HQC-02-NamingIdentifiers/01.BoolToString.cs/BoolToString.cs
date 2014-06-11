namespace _01.BoolToString.cs
{
    using System;
    class BoolToString
    {
        /// <summary>
        /// Used for printing bool values to the console.
        /// </summary>
        class Printer
        {
            public void PrintBool(bool boolToBePrinted)
            {
                string boolToString = boolToBePrinted.ToString();
                Console.WriteLine(boolToString);
            }
        }

        public static void Main()
        {
            Printer printer = new Printer();
            printer.PrintBool(true);
        }
    }
}
