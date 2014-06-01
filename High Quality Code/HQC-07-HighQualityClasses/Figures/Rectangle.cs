namespace Figures
{
    using System;

    public class Rectangle : Figure
    {
        private double height;
        private double width;

        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative.");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative.");
                }

                this.width = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
