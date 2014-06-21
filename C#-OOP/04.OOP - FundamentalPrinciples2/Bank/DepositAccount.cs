namespace Bank
{
    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance , decimal interestRate) : base(customer, balance, interestRate) 
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.InterestRate = 0;
            }
        }

        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }

        public void Withdraw(decimal ammount)
        {
            this.Balance -= ammount;
        }
    }
}
