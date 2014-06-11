namespace IfStatementsRefactoring
{
    using System;

    public class CellVisit
    {
        public const int MinX = 0;
        public const int MaxX = 10;

        public const int MinY = 1;
        public const int MaxY = 9;

        public static void CheckIfCellCanBeVisited(int x, int y, bool canVisitCell)
        {
            bool isInRangeX = MaxX >= x && x >= MinX;
            bool isInRangeY = MaxY >= y && y >= MinY;

            if (canVisitCell && isInRangeX && isInRangeY)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            // ..
        }
    }
}
