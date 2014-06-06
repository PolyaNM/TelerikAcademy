namespace MathOperationsPerfComparison
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class MathOperations
    {
        public const int IterationsCount = 1000000;
        public const int PaddingCount = 30;

        public static void DisplayPerformanceTime(Action action, string message)
        {
            Console.Write(message);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed + System.Environment.NewLine);
        }

        private static void DisplaySquareRootPerformance()
        {

            string floatMessage = "Square root of float:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    float result = 0f;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = (float)Math.Sqrt(8.5);
                    }
                },
                floatMessage);

            string doubleMessage = "Square root of double:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    double result = 0;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = Math.Sqrt(8.5);
                    }
                },
                doubleMessage);

            string decimalMessage = "Square root of double:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    decimal result = 0m;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = (decimal)Math.Sqrt(8.5);
                    }
                },
                decimalMessage);
        }

        private static void DisplayNaturalLogarithmPerformance()
        {
            string floatMessage = "Natural logarithm of float:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    float result = 0f;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = (float)Math.Log(8.5, Math.E);
                    }
                },
                floatMessage);

            string doubleMessage = "Natural logarithm of double:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    double result = 0;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = Math.Log(8.5, Math.E);
                    }
                },
                doubleMessage);

            string decimalMessage = "Natural logarithm of decimal:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    decimal result = 0m;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = (decimal)Math.Log(8.5, Math.E);
                    }
                },
                decimalMessage);
        }

        private static void DisplaySinusPerformance()
        {
            string floatMessage = "Sinus of float:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    float result = 0f;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = (float)Math.Sin(8.5);
                    }
                },
                floatMessage);

            string doubleMessage = "Sinus of double:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    double result = 0;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = Math.Sin(8.5);
                    }
                },
                doubleMessage);

            string decimalMessage = "Sinus of decimal:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    decimal result = 0m;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = (decimal)Math.Sin(8.5);
                    }
                },
                decimalMessage);
        }

        static void Main(string[] args)
        {
            DisplaySquareRootPerformance();
            Console.WriteLine();
            DisplayNaturalLogarithmPerformance();
            Console.WriteLine();
            DisplaySinusPerformance();
            Console.WriteLine("All operations take parameter of type DOUBLE and return result of type DOUBLE ==> casting is necessary for using these opperations with FLOAT and DECIMAL. That`s why the results from float and decimal operations must be ignored.");
        }
    }
}
