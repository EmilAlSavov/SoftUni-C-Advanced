using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_In_Dic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> dic = new Dictionary<double, int>();

            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                double currValue = input[i];

                if (!dic.ContainsKey(currValue))
                {
                    dic.Add(currValue, 0);
                }

                dic[currValue]++;
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
