namespace Methods
{
    using System;

    public class MethodsDemo
    {
        public static void Main()
        {
            Console.WriteLine(GeometryUtils.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(TranslatorUtils.ConvertDigitToText(5));

            Console.WriteLine(StatisticsUtils.FindMax(5, -1, 3, 2, 14, 2, 3));

            PrinterUtils.PrintAsNumber(1.3, 2);
            PrinterUtils.PrintAsPercent(0.75, 2);
            PrinterUtils.PrintAligned(2.30, 10);

            double distanceBetweenTwoPoints = GeometryUtils.CalcDistance(3, -1, 3, 2.5);
            bool isHorizontal = GeometryUtils.IsLineHorizontal(3, 3);
            bool isVertical = GeometryUtils.IsLineVertical(-1, 2.5);
            Console.WriteLine(distanceBetweenTwoPoints);
            Console.WriteLine("Horizontal? " + isHorizontal);
            Console.WriteLine("Vertical? " + isVertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1990, 10, 21), "[N/A]", "Football player");

            Student stella = new Student("Stella", "Markova", new DateTime(1988, 10, 27), "Vidin", "gamer");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, 
                stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
