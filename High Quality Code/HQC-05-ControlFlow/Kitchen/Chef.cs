namespace Kitchen
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Carrot GetCarrot()
        {
            // ..
            return new Carrot();
        }
        
        private Potato GetPotato()
        {
            // ..
            return new Potato();
        }

        private void Cut(Vegetable vegetable)
        {
            // ..
            vegetable.Cut();
        }

        private void Peel(Vegetable vegetable)
        {
            // ..
            vegetable.Peel();
        }

        private Bowl GetBowl()
        {
            // ..
            return new Bowl();
        }
    }
}
