namespace Point3DStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        public List<Point3D> path = new List<Point3D>();

        public List<Point3D> Paths
        {
            get
            {
                return this.path;
            }
            private set
            {
                this.path = value;
            }
        }

        public void AddPoint()
        {
            this.Paths.Add(Point3D.SertCoord);
        }

        public void AddPoint(Point3D point)
        {
            this.Paths.Add(point);
        }

        public void AddPoint(int x, int y, int z)
        {
            this.Paths.Add(new Point3D(x, y, z));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;

            foreach (Point3D point in this.Paths)
            {
                sb.AppendFormat("Point {0} - ", index);
                sb.AppendFormat("{0} , {1} , {2} \r\n", point.X, point.Y, point.Z);
                index++;
            }

            return sb.ToString();
        }
    }
}
