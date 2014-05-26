//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class PrintCardsNames
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            switch (i)
            {
                case 2:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("two of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 3:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("three of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 4:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("four of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 5:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("five of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 6:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("six of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 7:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("seven of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 8:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("eight of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 9:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("nine of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 10:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("ten of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 11:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("Ace of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 12:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("Jack of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 13:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("Queen of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                case 14:
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("King of ");
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("spades");
                                break;
                            case 1:
                                Console.WriteLine("hearts");
                                break;
                            case 2:
                                Console.WriteLine("diamonds");
                                break;
                            case 3:
                                Console.WriteLine("clubs");
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                    }
                    break;
                default:
                    Console.Write("");
                    break;
            }
        }
    }
}
