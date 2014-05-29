namespace ProjectGSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private const decimal DefaultPrice = 300m;
        private const string DefaultOwner = "Owner";

        private static readonly GSM Iphone4S = new GSM("Iphone 4S", "Apple", 1300.00m, "Globul",
                                                    new Battery("Apple", 200, 200, Type.LiIon),
                                                    new Display(70, 16000000));

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery; 
        private Display display;
        private List<Call> callHistory;

        public GSM(string model, string manufacturer) : this(model, manufacturer, DefaultPrice, DefaultOwner, new Battery(), new Display())
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Call>();
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Model can NOT be null or empty!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Manufacturer can NOT be null or empty!");
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new Exception("Price can NOT be a negative number!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Owner can NOT be null or empty!");
                }

                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            private set
            {
                this.battery = value;
            } 
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            private set
            {
                this.display = value;
            } 
        }

        public static GSM IPhone4S
        {
            get
            {
                return Iphone4S;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("GSM Specifications:");
            sb.AppendLine(new string('-', 40));
            sb.AppendFormat("Model: {0}", this.Model);
            sb.AppendLine();
            sb.AppendFormat("Manufacturer - {0}", this.Manufacturer);
            sb.AppendLine();
            sb.AppendFormat("Price - {0}", this.Price);
            sb.AppendLine();
            sb.AppendFormat("Owner - {0}", this.Owner);
            sb.AppendLine();
            sb.Append(this.Battery.ToString());
            sb.AppendLine();
            sb.Append(this.Display.ToString());
            sb.AppendLine();
            sb.AppendLine(new string('-', 40));

            return sb.ToString();
        }

        public void AddCall(string currPhoneNumber, uint currDuaration)
        {
            this.callHistory.Add(new Call(currPhoneNumber, currDuaration));
        }

        public void DeleteCall(int position)
        {
            if ((this.callHistory.Count <= position - 1) || (position - 1 < 0))
            {
                throw new Exception("Such call history log does not exist!");
            }

            this.callHistory.RemoveAt(position - 1);
        }

        public void ShowCallHistory()
        {
            Console.WriteLine("Current call history:");
            int indexer = 1; // this way the user can choose which call to delete

            foreach (var call in this.callHistory)
            {
                Console.Write(indexer++);
                Console.Write(": ");
                Console.WriteLine(call.ToString());
            }
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal TotalCallPrice(decimal pricePerMin)
        {
            decimal total = 0;

            foreach (var call in this.callHistory)
            {
                if (call.Duration < 60)
                {
                    total += pricePerMin;
                }
                else
                {
                    total += ((decimal)call.Duration / 60) * pricePerMin;
                }
            }

            return total;
        }
    }
}
