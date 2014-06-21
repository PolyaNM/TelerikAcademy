namespace MatrixClass
{
    using System;

    public class MatrixMain
    {
        static void Main()
        {
            Matrix<int> test1 = new Matrix<int>(2, 2);
            if (test1)
            {
                Console.WriteLine("fail"); // all are zeroes
            }

            test1[0, 0] = 7;
            test1[0, 1] = 8;
            test1[1, 0] = 9;
            test1[1, 1] = 10;

            if (test1)
            {
                Console.WriteLine("failz"); // at least one if not zero
            }

            Matrix<int> test2 = new Matrix<int>(2, 2);
            test2[0, 0] = 2;
            test2[0, 1] = 3;
            test2[1, 0] = 4;
            test2[1, 1] = 5;

            Console.WriteLine(test1 + test2);
            Console.WriteLine(test1 - test2);
            Console.WriteLine(test1 * test2);
        }
    }
}
