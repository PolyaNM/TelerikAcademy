namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName, DateTime birthDate, string city = null, string hobby = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = birthDate;
            this.City = city;
            this.Hobby = hobby;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get;
            private set;
        }

        public string City
        {
            get;
            private set;
        }

        public string Hobby
        {
            get;
            private set;
        }

        public bool IsOlderThan(Student other)
        {
            DateTime firstBirthDate = this.DateOfBirth;
            DateTime secondBirthDate = other.DateOfBirth;

            bool isOlder = firstBirthDate > secondBirthDate;

            return isOlder;
        }
    }
}
