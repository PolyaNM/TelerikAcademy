namespace AnimalsProject
{
    using System;
    using System.Linq;
    class Animal : ISound
    {
        private string name;
        private int age;
        private bool isMale;

        public Animal(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be at least 1 !");
                }
                this.age = value;
            }
        }

        public bool IsMale
        {
            get
            {
                return this.isMale;
            }
            set
            {
                this.isMale = value;
            }
        }

        public override string ToString()
        {
            return string.Format
                ("I am a {0} - My name is {1} and Im {2} years old and Im {3}"
                , this.GetType().Name, this.name, this.age, this.isMale ? "Male" : "Female");
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine(this.GetType().Name + "some sound");
        }

        public void IdentifyAnimalType()
        {
            Console.WriteLine("I am a " + GetType().Name);
        }

        public static decimal AverageAge(Animal[] arr)
        {
            return arr.Average(x => (decimal)x.age);
        }

    }
}
