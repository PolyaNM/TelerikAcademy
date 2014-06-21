namespace Bank
{
    using System;
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) { }

        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("The period cannot be a negative number!");
            }
            if (this.Customer is Individual)
            {
                months -= 6;
            }
            else if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    months /= 2;
                }
                else
                {
                    months -= 6;
                }
            }
            if (months < 0)
            {
                return 0m;
            }
            return months * this.InterestRate;
        }

    }
}
