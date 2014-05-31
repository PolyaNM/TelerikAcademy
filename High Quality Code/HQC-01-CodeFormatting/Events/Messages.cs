﻿namespace Events
{
    using System;
    using System.Text;
    public static class Messages
    {
        private static StringBuilder Output = new StringBuilder();
        public static string OutputString
        {
            get
            {
                return Output.ToString();
            }
        }

        public static void EventAdded()
        {
            Output.Append("Event added" + Environment.NewLine);
        }
        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }

            else
            {
                Output.AppendFormat("{0} events deleted{1}", x, Environment.NewLine);
            }
        }
        public static void NoEventsFound()
        {
            Output.Append("No events found" + Environment.NewLine);
        }
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + Environment.NewLine);
            }
        }
    }
}
