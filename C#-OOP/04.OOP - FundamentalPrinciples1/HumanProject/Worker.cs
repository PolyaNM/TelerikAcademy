namespace HumanProject
{
    using System;
    public class Worker : Human
    {
        private double workHoursPerDay;
        private double weekSalary;

        public Worker(string firstName, string lastName, double workHoursPerDay, double weekSalary)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours per day cannot be a negative number");
                }
                this.workHoursPerDay = value;
            }
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary cannot be a negative number");
                }
                this.weekSalary = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.weekSalary / this.workHoursPerDay;
        }
    }
}
