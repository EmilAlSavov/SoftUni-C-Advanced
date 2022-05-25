using System;
using System.Linq;

namespace Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i,j] = input[j];
                }
            }

            int sum1 = DiagonalOneSum(matrix);
            int sum2 = DiagonalTwoSum(matrix);

            int result = Compare(sum1, sum2);

            Console.WriteLine(result);
        }

        static int DiagonalOneSum(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i,i];
            }

            return sum;
        }

        static int DiagonalTwoSum(int[,] matrix)
        {
            int sum = 0;

            int row = matrix.GetLength(0) - 1;

            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                sum += matrix[row, col];

                row--;
            }

            return sum;
        }

        static int Compare(int sum1, int sum2)
        {
            if (sum1 > sum2)
            {
                return sum1 - sum2;
            } 
            else if (sum1 < sum2)
            {
                return sum2 - sum1;
            }
            else
            {
                return 0;
            }
        }
    }
}
