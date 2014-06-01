namespace Methods
{
    using System;

    public class PrinterUtils
    {
        public static void PrintAsNumber(double number, int precision)
        {
            string format = "{0:F" + precision + "}";
            Console.WriteLine(format, number);
        }

        public static void PrintAsPercent(double number, int precision)
        {
            string format = "{0:P" + precision + "}";
            Console.WriteLine(format, number);
        }

        public static void PrintAligned(object value, int alignment)
        {
            string format = "{0," + alignment + "}";
            Console.WriteLine(format, value);
        }
    }
}
