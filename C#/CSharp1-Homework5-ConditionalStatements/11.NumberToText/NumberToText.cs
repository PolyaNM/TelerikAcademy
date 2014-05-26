//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//0  "Zero"
//273  "Two hundred seventy three"
//400  "Four hundred"
//501  "Five hundred and one"
//711  "Seven hundred and eleven"


using System;

class NumberToText
{
    static void Main()
    {
        Console.WriteLine("Enter a number in the interval [0...999]: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 999 && number >= 0)
        {
            switch(number/100)
            {
                case 0:
                    break;
                case 1:
                    Console.Write("A hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;

                default: Console.WriteLine("Error!"); break;
            }
            if(number/100 != 0 && number%100 != 0)
            {
                Console.Write("and ");
            }


            switch (number / 10 % 10)
            {
                case 0:
                    break;
                case 1:
                    {
                        switch (number % 10)
                        {
                            case 0:
                                Console.WriteLine("ten ");
                                break;
                            case 1:
                                Console.WriteLine("eleven ");
                                break;
                            case 2:
                                Console.WriteLine("twelve ");
                                break;
                            case 3:
                                Console.WriteLine("thirteen ");
                                break;
                            case 4:
                                Console.WriteLine("fourteen ");
                                break;
                            case 5:
                                Console.WriteLine("fifteen ");
                                break;
                            case 6:
                                Console.WriteLine("sixteen ");
                                break;
                            case 7:
                                Console.WriteLine("seventeen ");
                                break;
                            case 8:
                                Console.WriteLine("eighteen ");
                                break;
                            case 9:
                                Console.WriteLine("nineteen ");
                                break;

                            default: Console.WriteLine("Error!"); break;
                        }
                    }
                    break;
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("fourty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;

                default: Console.Write("Error!"); break;
            }
            switch (number % 10)
            {
                case 0:
                    if (number == 0)
                    {
                        Console.Write("zero ");
                    }
                    break;
                case 1:
                    if (number / 10 % 10 == 1) break;  // break ако цифрата на десетиците е 1!!
                    Console.WriteLine("one ");
                    break;
                case 2:
                    if (number / 10 % 10 == 1) break;
                    Console.WriteLine("two ");
                    break;
                case 3:
                    if (number / 10 % 10 == 1) break;
                    Console.WriteLine("three ");
                    break;
                case 4:
                    if (number / 10 % 10 == 1) break;
                    Console.WriteLine("four");
                    break;
                case 5:
                    if (number / 10 % 10 == 1) break;
                    Console.WriteLine("five");
                    break;
                case 6:
                    if (number / 10 % 10 == 1) break;
                    Console.WriteLine("six");
                    break;
                case 7:
                    if (number / 10 % 10 == 1) break;
                    Console.WriteLine("seven ");
                    break;
                case 8:
                    if (number / 10 % 10 == 1) break;
                    Console.WriteLine("eight ");
                    break;
                case 9:
                    if (number / 10 % 10 == 1) break;
                    Console.WriteLine("nine ");
                    break;

                default: Console.WriteLine("Error!"); break;
            }
        }
        else
        {
            Console.WriteLine("The entered number is out of range!");
        }
    }
}
