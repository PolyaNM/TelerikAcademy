// --------------------- CONCLUSION ---------------------
// Operations with decimal are the slowest
// Long - division is slowest, addition - fastest
// Float, Double - division and multiplication are slower

namespace ArithmeticOperationsPerfComparison
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class ArithmeticOperations
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

        public static void Add()
        {
            string intMessage = "Addition of int: ".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    int sum = 0;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        sum += 50;
                    }
                },
                intMessage);

            string longMessage = "Addition of long: ".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    long sum = 0L;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        sum += 50L;
                    }
                },
                longMessage);

            string floatMessage = "Addition of float: ".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    float sum = 0f;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        sum += 50f;
                    }
                },
                floatMessage);

            string doubleMessage = "Addition of double: ".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    double sum = 0.0;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        sum += 50.0;
                    }
                },
                doubleMessage);

            string decimalMessage = "Addition of decimal: ".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    decimal sum = 0m;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        sum += 50m;
                    }
                },
                decimalMessage);
        }

        public static void Subtract()
        {
            string intMessage = "Subtraction of int:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    int result = 1000000000;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result -= 50;
                    }
                },
                intMessage);

            string longMessage = "Subtraction of long:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    long result = 1000000000L;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result -= 50L;
                    }
                },
                longMessage);

            string floatMessage = "Subtraction of float:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    float result = 1000000000f;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result -= 50f;
                    }
                },
                floatMessage);

            string doubleMessage = "Subtraction of double:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    double result = 1000000000.0;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result -= 50.0;
                    }
                },
                doubleMessage);

            string decimalMessage = "Subtraction of decimal:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    decimal result = 1000000000m;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result -= 50m;
                    }
                },
                decimalMessage);
        }

        public static void Increment()
        {
            string intMessage = "Increment of int:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    int value = 1;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        value++;
                    }
                },
                intMessage);

            string longMessage = "Increment of long:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    long value = 1L;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        value++;
                    }
                },
                longMessage);

            string floatMessage = "Increment of float:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    float value = 1f;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        value++;
                    }
                },
                floatMessage);

            string doubleMessage = "Increment of double:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    double value = 1.0;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        value++;
                    }
                },
                doubleMessage);

            string decimalMessage = "Increment of decimal:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    decimal value = 1m;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        value++;
                    }
                },
                decimalMessage);
        }

        public static void Multiply()
        {
            string intMessage = "Multiplication of int:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    int product = 1;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        product *= 1;
                    }
                },
                intMessage);

            string longMessage = "Multiplication of long:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    long product = 1L;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        product *= 1L;
                    }
                },
                longMessage);

            string floatMessage = "Multiplication of float:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    float product = 1f;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        product *= 1f;
                    }
                },
                floatMessage);

            string doubleMessage = "Multiplication of double:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    double product = 1.0;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        product *= 1.0;
                    }
                },
                doubleMessage);

            string decimalMessage = "Multiplication of decimal:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    decimal product = 1m;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        product *= 1m;
                    }
                },
                decimalMessage);
        }

        public static void Divide()
        {
            string intMessage = "Division of int:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    int result = 1000;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result /= 1;
                    }
                },
                intMessage);

            string longMessage = "Division of long:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    long result = 1000L;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result /= 1L;
                    }
                },
                longMessage);

            string floatMessage = "Division of float:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    float result = 1000f;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result /= 1f;
                    }
                },
                floatMessage);

            string doubleMessage = "Division of double:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    double result = 1000.0;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result /= 1.0;
                    }
                },
                doubleMessage);

            string decimalMessage = "Division of decimal:".PadRight(PaddingCount);
            DisplayPerformanceTime(
                () =>
                {
                    decimal result = 1000m;
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result /= 1m;
                    }
                },
                decimalMessage);
        }

        public static void Main()
        {
            Add();
            Console.WriteLine();
            Subtract();
            Console.WriteLine();
            Increment();
            Console.WriteLine();
            Multiply();
            Console.WriteLine();
            Divide();
        }
    }
}
