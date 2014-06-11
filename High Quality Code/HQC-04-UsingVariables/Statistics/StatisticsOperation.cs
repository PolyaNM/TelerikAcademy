namespace Statistics
{
    using System;

    public class StatisticsOperation
    {
        public void PrintStatistics(double[] inputArray, int countOfElements)
        {
            double minElement = this.FindMinElement(inputArray, countOfElements);
            double maxElement = this.FindMaxElement(inputArray, countOfElements);
            double averageOfElements = this.FindAverageOfElements(inputArray, countOfElements);

            this.PrintInformation(minElement, maxElement, averageOfElements);
        }

        private double FindMinElement(double[] inputArray, int countOfElements)
        {
            double minElement = inputArray[0];

            for (int i = 1; i < countOfElements; i++)
            {
                if (minElement > inputArray[i])
                {
                    minElement = inputArray[i];
                }
            }

            return minElement;
        }

        private double FindMaxElement(double[] inputArray, int countOfElements)
        {
            double maxElement = inputArray[0];

            for (int i = 1; i < countOfElements; i++)
            {
                if (maxElement < inputArray[i])
                {
                    maxElement = inputArray[i];
                }
            }

            return maxElement;
        }

        private double FindAverageOfElements(double[] inputArray, int countOfElements)
        {
            double sumOfAllElements = 0;

            for (int i = 0; i < countOfElements; i++)
            {
                sumOfAllElements += inputArray[i];
            }

            double averageOfElements = sumOfAllElements / countOfElements;
            return averageOfElements;
        }

        private void PrintInformation(double minElement, double maxElement, double averageOfElements)
        {
            Console.Write("Min element is: ");
            Console.WriteLine(minElement);

            Console.Write("Max element is: ");
            Console.WriteLine(maxElement);

            Console.Write("Average of elements is: ");
            Console.WriteLine(averageOfElements);
        }
    }
}
