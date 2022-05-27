using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dic = new Dictionary<char, int>();

            foreach (char ch in input)
            {
                if (!dic.ContainsKey(ch))
                {
                    dic.Add(ch, 0);
                }
                dic[ch]++;
            }

            dic = dic.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var ch in dic)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
