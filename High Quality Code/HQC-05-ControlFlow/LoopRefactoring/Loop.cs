namespace LoopRefactoring
{
    using System;

    public class Loop
    {
        public static void LoopRefactor(int[] arrayToSearch, int searchedValue)
        {
            int arrLength = arrayToSearch.Length;
            int divider = 10;
            bool isFound = false;
            
            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine(arrayToSearch[i]);
                if (i % divider == 0)
                {
                    if (arrayToSearch[i] == searchedValue)
                    {
                        isFound = true;

                        // Without breaking because all elements in the array will be printed.
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
