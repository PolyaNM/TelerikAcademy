namespace AnimalsProject
{
    using System;
    class ProgramMain
    {
        static void Main()
        {
            Frog[] frogs =
            {
                new Frog("Frog1", 3, true),
                new Frog("Frog2", 8, false),
                new Frog("Frog3", 1, true),
                new Frog("Frog4", 2, false)
            };
            Dog[] dogs =
            {
                new Dog("Dog1", 4, true),
                new Dog("Dog2", 2, true),
                new Dog("Dog3", 6, false),
                new Dog("Dog4", 3, true)
            };
            Cat[] cats =
            {
                new Kitten("Kitten1", 3),
                new Tomcat("Tomcat1", 5),
                new Kitten("Kitten2", 2),
                new Tomcat("Tomcat2", 1)
            };

            //identify the type of the animal
            dogs[2].IdentifyAnimalType();
            cats[1].IdentifyAnimalType();
            cats[2].IdentifyAnimalType();

            //calculate average age
            Console.WriteLine("Average age of dogs " + Animal.AverageAge(dogs));
            Console.WriteLine("Average age of frogs " + Animal.AverageAge(frogs));
            Console.WriteLine("Average age of cats " + Animal.AverageAge(cats));

            //produce sound
            dogs[1].ProduceSound();
            cats[0].ProduceSound();
        }
    }
}
