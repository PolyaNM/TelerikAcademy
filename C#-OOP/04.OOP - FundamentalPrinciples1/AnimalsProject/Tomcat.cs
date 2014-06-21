namespace AnimalsProject
{
    using System;
    class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age) : base(name, age, true)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat mrr!");
        }
    }
}
