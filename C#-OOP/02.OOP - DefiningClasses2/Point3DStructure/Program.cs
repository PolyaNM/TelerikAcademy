namespace Point3DStructure
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Path testing = new Path();
            testing.AddPoint();
            testing.AddPoint(new Point3D(4, 7, 8));
            testing.AddPoint(3, 2, 1);
            Console.WriteLine(testing); 
        }
    }
}
