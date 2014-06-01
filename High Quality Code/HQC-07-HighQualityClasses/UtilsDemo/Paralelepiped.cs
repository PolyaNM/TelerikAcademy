namespace UtilsDemo
{
    using System;

    public class Paralelepiped
    {
        public double Width
        {
            get;
            private set;
        }

        public double Height
        {
            get;
            private set;
        }

        public double Depth
        {
            get;
            private set;
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
