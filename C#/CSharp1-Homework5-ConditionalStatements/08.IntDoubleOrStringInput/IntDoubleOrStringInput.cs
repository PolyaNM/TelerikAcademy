//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.


using System;

class IntDoubleOrStringInput
{
    static void Main()
    {
        //First method - First we input the type of the data (int, string or double) and after that we input the data by using the switch statement.

        Console.WriteLine("Please enter the type of data you want to input : int, double or string ");
        string dataType = Console.ReadLine();
        Console.WriteLine("Please enter the data :");


        switch (dataType)
        {
            case "int":
                int i = int.Parse(Console.ReadLine());
                i = i + 1;
                Console.WriteLine(i); break;
            case "double":
                double d = double.Parse(Console.ReadLine());
                d = d + 1;
                Console.WriteLine(d); break;
            case "string":
                string s = Console.ReadLine();
                Console.WriteLine(s + "*"); break;
            default: ; break;
        }

        //Second method - no switch statement! The console reads an input and decides if it is an int, double or string variable(Try.Parse)

        /*
        Console.Write("Enter a variable: ");
        string input = Console.ReadLine();
        int inputInt; //or long
        bool isInt;
        double InputDouble;
        bool isDouble;


        if (isInt = Int32.TryParse(input, out inputInt))
        {
            inputInt++;
            Console.WriteLine(inputInt);
        }
        else if (isDouble = double.TryParse(input, out InputDouble))
        {
            InputDouble++;
            Console.WriteLine(InputDouble);
        }
        else
        {
            Console.WriteLine(input + "*");
        }  
        */
         
    }
}
