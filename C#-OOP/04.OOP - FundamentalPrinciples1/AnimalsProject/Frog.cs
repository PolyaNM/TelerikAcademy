namespace AnimalsProject
{
    using System;
    class Frog : Animal, ISound
    {
        public Frog(string name, int age, bool isMale) : base(age, name, isMale)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Ribbit!");
        }
    }
}
