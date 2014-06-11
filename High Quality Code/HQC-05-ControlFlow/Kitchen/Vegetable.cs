namespace Kitchen
{
    public abstract class Vegetable
    {
        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        public bool IsRotten { get; set; }

        public void Cut()
        {
            // ..
            this.IsCut = true;
        }

        public void Peel()
        {
            // ..
            this.IsPeeled = true;
        }
    }
}
