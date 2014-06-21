using System;
class TestPerson
{
    static void Main()
    {
        var firstPerson = new Person("Maya");
        var secondPerson = new Person("Gosho", 15);
        Console.WriteLine(firstPerson.ToString());
        Console.WriteLine(secondPerson.ToString());
    }
}
