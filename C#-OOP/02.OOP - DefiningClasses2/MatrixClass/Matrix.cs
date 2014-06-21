namespace MatrixClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Columns
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.matrix.GetLength(0) || col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index out of range !");
                }

                return this.matrix[row, col];
            }

            set
            {
                if (row < 0 || row >= this.matrix.GetLength(0) || col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index out of range !");
                }

                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    sb.Append(this.matrix[i, j] + " ");
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1 == null || m2 == null)
            {
                throw new ArgumentNullException("Matrix {0} is null !", m1 == null ? "1" : "2");
            }

            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {
                throw new ArgumentException("Matreces must have same number of rows and columns if we want to sum them!");
            }

            Matrix<T> result = new Matrix<T>(m1.Rows, m1.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1 == null || m2 == null)
            {
                throw new ArgumentNullException("Matrix {0} is null !", m1 == null ? "1" : "2");
            }

            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {
                throw new ArgumentException("Matreces must have same number of rows and columns if we want to substract them!");
            }

            Matrix<T> result = new Matrix<T>(m1.Rows, m1.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1 == null || matrix2 == null)
            {
                throw new ArgumentNullException("Matrix {0} is null !", matrix1 == null ? "1" : "2");
            }

            if (matrix1.Rows != matrix2.Columns)
            {
                throw new ArgumentException("Matrix 1 rows and Matrix 2 columns must be the same number !");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix2.Columns);

            for (int row = 0; row < matrix1.Rows; row++)
            {
                for (int col = 0; col < matrix2.Columns; col++)
                {
                    dynamic temp = 0;

                    for (int currentnumbers = 0; currentnumbers < matrix1.Columns; currentnumbers++)
                    {
                        temp += (dynamic)matrix1[row, currentnumbers] * (dynamic)matrix2[currentnumbers, col];
                    }

                    result[row, col] = temp;
                }
            }

            return result;
        }

        // if at least one element is not 0 this should return true
        public static bool operator true(Matrix<T> currentMatrix)
        {
            for (int row = 0; row < currentMatrix.Rows; row++)
            {
                for (int col = 0; col < currentMatrix.Columns; col++)
                {
                    if (currentMatrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> currmatrix)
        {
            for (int row = 0; row < currmatrix.Rows; row++)
            {
                for (int col = 0; col < currmatrix.Columns; col++)
                {
                    if (currmatrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
