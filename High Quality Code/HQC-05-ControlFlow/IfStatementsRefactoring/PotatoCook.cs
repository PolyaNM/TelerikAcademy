namespace IfStatementsRefactoring
{
    using System;

    public class PotatoCook
    {
        public static void CheckIfPotatoCanBeCooked(Potato potato)
        {
            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("No potatoes here :)");
            }
        }

        private static void Cook(Potato potato)
        {
            // ..
        }
    }
}
