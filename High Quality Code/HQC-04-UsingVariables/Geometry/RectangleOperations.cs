namespace Geometry
{
    using System;

    public class RectangleOperations
    {
        public static Rectangle GetBoundingBoxAfterRotation(Rectangle rectangleToRotate, double angleToRotateWith)
        {
            double width = (Math.Abs(Math.Cos(angleToRotateWith)) * rectangleToRotate.Width) +
                (Math.Abs(Math.Sin(angleToRotateWith)) * rectangleToRotate.Height);
            double height = (Math.Abs(Math.Sin(angleToRotateWith)) * rectangleToRotate.Width) +
                (Math.Abs(Math.Cos(angleToRotateWith)) * rectangleToRotate.Height);

            return new Rectangle(width, height);
        }
    }
}
