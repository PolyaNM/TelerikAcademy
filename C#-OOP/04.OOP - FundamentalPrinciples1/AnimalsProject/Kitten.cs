namespace AnimalsProject
{
    using System;
    class Kitten : Cat, ISound
    {
        public Kitten(string name, int age) : base(name, age, false)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kitty mrr!");
        }
    }
}
