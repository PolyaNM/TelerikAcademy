// http://en.wikipedia.org/wiki/Euclidean_distance
namespace Point3DStructure
{
    using System;

    public static class DistanceBetweenTwoPoints
    {
        public static double CalcDistanceBetweenTwoPoints(Point3D first, Point3D second)
        {
            double distance = 0;
            distance = Math.Sqrt(
                ((second.X - first.X) * (second.X - first.X)) +
                ((second.Y - first.Y) * (second.Y - first.Y)) +
                ((second.Z - first.Z) * (second.Z - first.Z)));
            return distance;
        }
    }
}
