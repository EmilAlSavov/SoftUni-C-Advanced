using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_Of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = nm[0];
            int m = nm[1];

            HashSet<int> set = new HashSet<int>();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var num in set1)
            {
                if (set2.Contains(num))
                {
                    set.Add(num);
                }
            }

            Console.WriteLine(String.Join(" ", set));
        }
    }
}
