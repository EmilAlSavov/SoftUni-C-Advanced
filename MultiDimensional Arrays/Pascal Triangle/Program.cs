using System;

namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            jagged[0] = new int[1] {1};

            for (int row = 1; row < n; row++)
            {
                jagged[row] = new int[jagged[row - 1].Length + 1];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    if (col - 1 < 0 || col + 1 > jagged[row - 1].Length)
                    {
                        jagged[row][col] = 1;
                    }
                    else
                    {
                        jagged[row][col] = jagged[row - 1][col - 1] + jagged[row - 1][col];
                    }
                }
            }

            foreach (var arr in jagged)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
