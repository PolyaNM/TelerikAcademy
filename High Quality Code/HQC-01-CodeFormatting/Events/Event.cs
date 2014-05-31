namespace Events
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private String title;
        private String location;

        public Event(DateTime date, String title, String location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        // Properties for fields date, title, location
        public DateTime Date
        {
            get
            {
                return this.date;
            }

            private set
            {
                this.date = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                this.title = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }

            private set
            {
                this.location = value;
            }
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.Date.CompareTo(other.Date);
            int byTitle = this.Title.CompareTo(other.Title);
            int byLocation = this.Location.CompareTo(other.Location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            result.Append(" | " + title);
            if (String.IsNullOrEmpty(location))
            {
                result.Append(" | " + location);
            }

            return result.ToString();
        }
    }

}