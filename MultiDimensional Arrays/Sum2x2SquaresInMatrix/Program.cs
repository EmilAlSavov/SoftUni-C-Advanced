using System;
using System.Linq;

namespace Sum2x2SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            (int rows, int cols) = (dimentions[0], dimentions[1]);

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] currCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currCol[j];
                }
            }

            long maxNum = long.MinValue;
            string maxNumSquare = string.Empty;
            for (int i = 0; i < rows - 1; i++)
            {
                long sum = 0;
                for (int j = 0; j < cols - 1; j++)
                {
                    sum = matrix[i, j] +
                        matrix[i, j + 1] +
                        matrix[i + 1, j] +
                        matrix[i + 1, j + 1];

                    if (sum > maxNum)
                    {
                        maxNum = sum;

                        maxNumSquare = matrix[i, j] + " " +
                        matrix[i, j + 1] + "\n\r" +
                        matrix[i + 1, j] + " " +
                        matrix[i + 1, j + 1];
                    }
                }
            }

            Console.WriteLine(maxNumSquare);
            Console.WriteLine(maxNum);
        }
    }
}
