using System;
using System.Text;

public class Person
{
    private int? age;
    private string name;


    public Person(string name, int? age = null)
    {
        this.Name = name;
        this.Age = age;
    }

    public int? Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be a negative number");
            }
            this.age = value;
        }
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
                throw new ArgumentException("Name cannot be null or empty");
            }
            this.name = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Name: {0} , Age: {1}", this.Name, this.Age == null ? "Not specified" : this.Age.ToString());
    }
}