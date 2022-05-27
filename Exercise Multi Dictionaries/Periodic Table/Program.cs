using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<String> set = new HashSet<String>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < input.Length; j++)
                {
                    set.Add(input[j]);
                }
            }

            set = set.OrderBy(x => x).ToHashSet();

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
