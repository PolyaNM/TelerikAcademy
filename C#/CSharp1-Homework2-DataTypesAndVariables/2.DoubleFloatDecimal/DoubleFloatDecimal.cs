//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class DoubleFloatDecimal
{
    static void Main()
    {
        double number1 = 34.567839023;
        float number2 = 12.345f;
        double number3 = 8923.1234857;              
        decimal number4 = 3456.091124875956542151256683467m;
        Console.WriteLine("double " + number1);
        Console.WriteLine("float " + number2);
        Console.WriteLine("double " + number3);
        Console.WriteLine("decimal " + number4);
    }
}

