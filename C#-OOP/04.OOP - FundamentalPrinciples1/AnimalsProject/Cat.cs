namespace AnimalsProject
{
    using System;
    class Cat : Animal, ISound
    {
        public Cat(string name, int age, bool isMale) : base(age, name, isMale)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
