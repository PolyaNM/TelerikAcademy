//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
using System.Globalization;

class BankAccount
{
    static void Main()
    {
        string firstName, secondName, lastName, bankName;
        decimal moneyBalance;
        string iBAN, bicCode;
        ulong creditCard1, creditCard2, creditCard3;

        firstName = "Maria";
        secondName = "Ivanova";
        lastName = "Popova";
        bankName = "DSK";
        moneyBalance = 500.50m;

        //change the default currency (лв.) to dollars($)
        CultureInfo us = CultureInfo.GetCultureInfo("en-US");
        string balance = string.Format(us,"{0:C}",moneyBalance);

        iBAN = "BG80 BNBG 9661 1020 3456 78";
        bicCode = "STSA9300";

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("BANK ACCOUNT".PadLeft(25));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Name of holder: {0} {1} {2}", firstName, secondName, lastName);
        Console.WriteLine("Balance: {0}", balance);

        Console.WriteLine("Bank: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iBAN);
        Console.WriteLine("BIC: {0}", bicCode);
    }
}

