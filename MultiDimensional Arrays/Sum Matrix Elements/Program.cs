using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            (int rows, int cols) = (dimentions[0], dimentions[1]);

            int[,] matrix = new int[rows, cols];

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                int[] currRol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currRol[j];
                    sum += currRol[j];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
