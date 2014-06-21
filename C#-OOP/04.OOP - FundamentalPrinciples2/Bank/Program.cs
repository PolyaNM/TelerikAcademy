namespace Bank
{
    using System;
    class Program
    {
        static void Main()
        {
            Individual ivo = new Individual("Ivo", "Dimov", "Sofia");
            Company compy = new Company("Tech OOD", "Sofia");

            var firstMorg = new MortgageAccount(ivo, 200, 4);
            var secMorg = new MortgageAccount(compy, 300, 4);

            Console.WriteLine(firstMorg.CalculateInterestAmount(4));   // 0
            Console.WriteLine(secMorg.CalculateInterestAmount(4));     // 16/2 = 8

            var firstLoan = new LoanAccount(ivo, 200, 4);
            var secLoan = new LoanAccount(compy, 300, 4);

            Console.WriteLine(firstLoan.CalculateInterestAmount(4));   // 1 month * 4 = 4
            Console.WriteLine(secLoan.CalculateInterestAmount(4));     // 2 months * 4 = 8
        }
    }
}
