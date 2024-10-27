using System;

namespace MathLibrary
{
    public class MatrixOperations
    {
        public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int size = matrix1.GetLength(0);
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
        {
            int size = matrix1.GetLength(0);
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int size = matrix1.GetLength(0);
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < size; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }
    }
}
