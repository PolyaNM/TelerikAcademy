namespace Shapes
{
    using System;
    public class TestMain
    {
        static void Main()
        {
            Shape[] shapes = new Shape[] {
            new Triangle(3,8),
            new Rectangle(4,5),
            new Circle(7),
        };

            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetType().Name + " surface : " + item.CalculateSurface());
            }
        }
    }
}
