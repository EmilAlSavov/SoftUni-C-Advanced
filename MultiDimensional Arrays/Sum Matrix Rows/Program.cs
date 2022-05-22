using System;
using System.Linq;

namespace Sum_Matrix_Rows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            (int rows, int cols) = (dimensions[0], dimensions[1]);

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] currColon = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int y = 0; y < currColon.Length; y++)
                {
                    matrix[i, y] = currColon[y];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                int sum = 0;

                for (int y = 0; y < rows; y++)
                {
                    sum += matrix[y, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
