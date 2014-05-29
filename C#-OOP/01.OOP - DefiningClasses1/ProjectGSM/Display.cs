namespace ProjectGSM
{
    using System;
    using System.Text;

    public class Display
    {
        // default parameters
        private const int DefaultSize = 15;
        private const int DefaultNumberOfColors = 20000000;

        private int size;
        private int numberOfColors;

        public Display()
            : this(DefaultSize, DefaultNumberOfColors)
        {
        }

        public Display(int size, int numberOfColors)
        {
            this.NumberOfColors = numberOfColors;
            this.Size = size;
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Size must be > 0");
                }

                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Number of colors must be > 0");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Display Specifications : Size - {0}, Number of Colors - {1}",
                this.Size,
                this.NumberOfColors);
            return sb.ToString();
        }
    }
}
