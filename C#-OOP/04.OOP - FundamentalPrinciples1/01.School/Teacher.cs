namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string name, params Discipline[] inputDisciplines)
            : base(name)
        {
            disciplines = new List<Discipline>();
            this.disciplines.AddRange(inputDisciplines);
        }

        public Discipline[] Disciplines
        {
            get
            {
                return this.disciplines.ToArray();
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            if (!this.disciplines.Contains(discipline))
            {
                throw new ArgumentException("There are no disciplines for this teacher");
            }
            this.disciplines.Remove(discipline);
        }

        public string Comments
        {
            get;
            set;
        }
    }
}
