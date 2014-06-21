namespace Bank
{
    using System;
    public abstract class Customer
    {
        private string name;
        private string lastName;
        private string address;

        //constructors
        public Customer(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public Customer(string name, string lastName, string address) : this(name, address)
        {
            this.LastName = lastName;
        }

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the customer cannot be null or empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the customer cannot be null or empty");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address cannot be null or empty.");
                }
                address = value;
            }
        }
    }
}
