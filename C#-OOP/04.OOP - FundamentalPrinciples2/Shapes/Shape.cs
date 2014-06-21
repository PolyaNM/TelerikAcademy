namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Width cannot be <= 0!");
                }
                this.width = value;
            }
        }

        public virtual double Height // virtual because we'll override the property in class Circle
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Height cannot <= 0!");
                }
                this.height = value;
            }
        }
        public abstract double CalculateSurface();
    }
}
