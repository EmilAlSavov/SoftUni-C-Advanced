using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jagged[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();

                string commandType = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row >= n || row < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (col >= jagged[row].Length || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (commandType == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (commandType == "Subtract")
                {
                    jagged[row][col] -= value;
                }
                }

            foreach (var arr in jagged)
            {
                Console.WriteLine(String.Join(" ", arr));
            }
        }
    }
}
