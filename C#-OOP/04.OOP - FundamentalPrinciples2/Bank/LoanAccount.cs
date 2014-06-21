namespace Bank
{
    using System;
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
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
            if (this.Customer is Individual && months <= 3)
            {
                months = 0;
            }
            else if (this.Customer is Individual && months > 3)
            {
                months -= 3;
            }
            else if (this.Customer is Company && months <= 2 )
            {
                months = 0;
            }
            else if (this.Customer is Company && months > 2)
            {
                months -= 2;
            }
            return months * this.InterestRate;
        }
    }
}
