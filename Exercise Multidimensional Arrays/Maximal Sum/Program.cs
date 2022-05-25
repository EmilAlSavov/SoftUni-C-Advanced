using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Dictionary<string, int> sumList = new Dictionary<string, int>();

            int rows= size[0];
            int cols= size[1];

            int[,] matrix = new int[rows, cols];

            matrix = FillMatrix(matrix);

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    int sum = matrix[i, j]
                        + matrix[i, j + 1]
                        + matrix[ i, j + 2]
                        + matrix[i + 1, j]
                        + matrix[i + 1, j + 1]
                        + matrix[i + 1, j + 2]
                        + matrix[i + 2, j]
                        + matrix[i + 2, j + 1]
                        + matrix[i + 2, j + 2];

                    sumList.Add($"{matrix[i, j]} {matrix[i, j + 1]} {matrix[i, j + 2]}\n\r{matrix[i + 1, j]} {matrix[i + 1, j + 1]} {matrix[i + 1, j + 2]}\r\n{matrix[i + 2, j]} {matrix[i + 2, j + 1]} { matrix[i + 2, j + 2]}", sum);
                }
            }
            sumList = sumList.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sumList)
            {
                Console.WriteLine($"Sum = {item.Value}");
                Console.WriteLine(item.Key);
                break;
            }
        }

        private static int[,] FillMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            return matrix;
        }
    }
}
