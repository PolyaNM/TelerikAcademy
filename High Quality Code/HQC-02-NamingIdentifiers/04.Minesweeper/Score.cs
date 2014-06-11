namespace _04.Minesweeper
{
    public class Score
    {
        private string name;
        private int points;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }

        public Score()
        {
        }

        public Score(string name, int score)
        {
            this.Name = name;
            this.Points = score;
        }
    }
}
