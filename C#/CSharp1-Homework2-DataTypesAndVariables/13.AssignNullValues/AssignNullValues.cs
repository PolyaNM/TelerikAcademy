//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.


using System;

class AssignNullValues
{
    static void Main()
    {
        int var1 = 2;
        double var2 = 3;
        int? nVar1 = var1;
        double? nvar2 = var2;
        //Console.WriteLine(var1);
        //Console.WriteLine(var2);
        Console.WriteLine(nVar1.HasValue);
        var1 = nVar1.Value;
        Console.WriteLine(var1);

        nVar1 = null;
        var1 = nVar1.GetValueOrDefault();
        Console.WriteLine(var1);

    }
}
