namespace AnimalsProject
{
    using System;
    class Dog : Animal, ISound
    {
        public Dog(string name, int age, bool isMale) : base(age, name, isMale)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
