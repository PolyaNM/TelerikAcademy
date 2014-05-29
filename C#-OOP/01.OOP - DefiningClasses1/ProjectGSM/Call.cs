namespace ProjectGSM
{
    using System;
    using System.Text;

    public class Call
    {
        private DateTime dateTime;
        private string phoneNumber;
        private uint duration;

        public Call(string phonenumber, uint duaration)
        {
            this.DateTime = DateTime.Now;
            this.PhoneNumber = phonenumber;
            this.Duration = duaration;
        }

        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }

            private set
            {
                this.dateTime = DateTime.Now;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Phonenumber can not be null or empty!");
                }

                this.phoneNumber = value;
            }
        }

        public uint Duration
        {
            get
            {
                return this.duration;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Duaration can not be a negative number!");
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringCreator = new StringBuilder();
            stringCreator.AppendFormat("{0} : Duaration - {1} , made on {2}", this.phoneNumber, this.duration, this.dateTime);
            stringCreator.AppendLine();
            return stringCreator.ToString();
        }
    }
}
