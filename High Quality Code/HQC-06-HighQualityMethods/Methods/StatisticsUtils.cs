namespace Methods
{
    using System;

    public class StatisticsUtils
    {
        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Input cannot be null.");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Input array must have at least one element.");
            }

            int max = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }
    }
}
