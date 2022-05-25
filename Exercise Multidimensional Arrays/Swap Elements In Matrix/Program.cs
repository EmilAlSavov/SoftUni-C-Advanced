using System;
using System.Linq;

namespace Swap_Elements_In_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = new string[rows, cols];

            matrix = FillMatrix(matrix);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();

                if (!ValidateCommand(command, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                string el1 = matrix[row1, col1];
                string el2 = matrix[row2, col2];

                matrix[row1, col1] = el2;
                matrix[row2, col2] = el1;

                PrintMatrix(matrix);
            }
        }

        private static bool ValidateCommand(string[] command, int rows, int cols)
        {
            if (command[0] != "swap" || command.Length != 5)
            {
                return false;
            }
            int row1 = int.Parse(command[1]);
            int col1 = int.Parse(command[2]);
            int row2 = int.Parse(command[3]);
            int col2 = int.Parse(command[4]);

            if (row1 < 0 || row1 >= rows
                || col1 < 0 || col1 >= cols
                || row2 < 0 || row2 >= rows
                || col2 < 0 || col2 >= cols)
            {
                return false;
            }
            return true;
        }

        private static string[,] FillMatrix(string[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            return matrix;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength (1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
