namespace Bank
{
    using System;
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer AccCustomer, decimal AccBalance, decimal AccInterestRate)
        {
            this.Customer = AccCustomer;
            this.Balance = AccBalance;
            this.InterestRate = AccInterestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Customer cannot be null");
                }
                else
                {
                    this.customer = value;
                }
            }
        }

        public decimal Balance 
        { 
            get 
            { 
                return this.balance; 
            } 
            set 
            { 
                this.balance = value; 
            } 
        }
        public decimal InterestRate 
            { 
                get 
                { 
                    return this.interestRate; 
                } 
                set 
                { 
                    this.interestRate = value; 
                } 
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("The period cannot be a negative number!");
            }
            else
            {
                return months * this.InterestRate;
            }
            
        }
    }
}
