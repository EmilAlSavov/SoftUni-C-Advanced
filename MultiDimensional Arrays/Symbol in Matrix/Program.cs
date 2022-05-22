using System;

namespace Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            char symToSearch = char.Parse(Console.ReadLine());

            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    if (matrix[rows, cols] == symToSearch)
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symToSearch} does not occur in the matrix");
        }
    }
}
