using System;
using System.Linq;

namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = FillMatrix(size);

            string[] coordinates = Console.ReadLine().Split();

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] currCoor = coordinates[i].Split(',').Select(int.Parse).ToArray();
                
                int row = currCoor[0];
                int col = currCoor[1];

                int bombPow = matrix[row, col];

                if (bombPow <= 0)
                {
                    continue;
                }

                if (col + 1 < size)
                {
                    if (matrix[row, col + 1] > 0)
                    {
                        matrix[row, col + 1] -= bombPow;
                    }
                }
                if (col - 1 >= 0)
                {
                    if (matrix[row, col - 1] > 0)
                    {
                        matrix[row, col - 1] -= bombPow;
                    }
                }
                if (row + 1 < size)
                {
                    if (matrix[row + 1 , col] > 0)
                    {
                        matrix[row + 1, col] -= bombPow;
                    }
                }
                if (row + 1 < size && col - 1 >= 0)
                {
                    if (matrix[row + 1, col - 1] > 0)
                    {
                        matrix[row + 1, col - 1] -= bombPow;
                    }
                }
                if (row + 1 < size && col + 1 < size)
                {
                    if (matrix[row + 1, col + 1] > 0)
                    {
                        matrix[row + 1, col + 1] -= bombPow;
                    }
                }
                if (row - 1 >= 0 && col - 1 >= 0)
                {
                    if (matrix[row - 1, col - 1] > 0)
                    {
                        matrix[row - 1, col - 1] -= bombPow;
                    }
                }
                if (row - 1 >= 0 && col + 1 < size)
                {
                    if (matrix[row - 1, col + 1] > 0)
                    {
                        matrix[row - 1, col + 1] -= bombPow;
                    }
                }
                if (row - 1 >= 0)
                {
                    if (matrix[row - 1, col] > 0)
                    {
                        matrix[row - 1, col] -= bombPow;
                    }
                }
                matrix[row, col] = 0;
            }

            int deadCounter = 0;
            int deadSum = 0;

            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    deadSum += item;
                    deadCounter++;
                }
            }
            Console.WriteLine($"Alive cells: {deadCounter}");
            Console.WriteLine($"Sum: {deadSum}");
            PrintMatrix(matrix);
        }

        static int[,] FillMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
