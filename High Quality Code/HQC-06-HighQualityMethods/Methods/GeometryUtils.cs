namespace Methods
{
    using System;

    public class GeometryUtils
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides must be positive.");
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentException("Triangle cannot be formed with the given sides.");
            }

            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static bool IsLineHorizontal(double x1, double x2)
        {
            bool isHorizontal = x1 == x2;

            return isHorizontal;
        }

        public static bool IsLineVertical(double y1, double y2)
        {
            bool isVertical = y1 == y2;

            return isVertical;
        }
    }
}
