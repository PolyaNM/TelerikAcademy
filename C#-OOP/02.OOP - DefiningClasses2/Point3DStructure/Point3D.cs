namespace Point3DStructure
{
    public struct Point3D
    {
        private static readonly Point3D startCoord = new Point3D(0, 0, 0);

        public Point3D(double coordX, double coordY, double coordZ)
            : this()
        {
            this.X = coordX;
            this.Y = coordY;
            this.Z = coordZ;
        }

        public static Point3D SertCoord
        {
            get
            {
                return startCoord;
            }
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}
