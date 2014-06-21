﻿namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    class School
    {
        private List<Class> classes;

        public School()
        {
            this.classes = new List<Class>();
        }

        public Class[] Classes
        {
            get
            {
                return this.classes.ToArray();
            }
        }

        public void AddClass(Class c)
        {
            this.classes.Add(c);
        }

        public void RemoveClass(Class c)
        {
            if (!this.classes.Contains(c))
            {
                throw new ArgumentException("No such class found in the school");
            }
            this.classes.Remove(c);
        }
    }
}
