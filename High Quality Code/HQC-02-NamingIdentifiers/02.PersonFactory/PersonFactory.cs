namespace _02.PersonFactory
{
    using System;
    public class PersonFactory
    {
        public enum Gender
        {
            Male, Female
        }
        public class Person
        {
            public Gender Sex
            { get; set; }
            public string Name
            { get; set; }
            public int Age
            { get; set; }
        }
        public static Person CreatePerson(int personAge)
        {
            Person newPerson = new Person();
            newPerson.Age = personAge;

            if (personAge % 2 == 0)
            {
                newPerson.Name = "Batkata";
                newPerson.Sex = Gender.Male;
            }
            else
            {
                newPerson.Name = "Chikita";
                newPerson.Sex = Gender.Female; ;
            }

            return newPerson;
        }

        public static void Main(string[] args)
        {
            // Test
            Person person = CreatePerson(30);
            Console.WriteLine("Name: {0} Age: {1} Sex: {2}", person.Name, person.Age, person.Sex);

            person = CreatePerson(19);
            Console.WriteLine("Name: {0} Age: {1} Sex: {2}", person.Name, person.Age, person.Sex);
        }
    }
}