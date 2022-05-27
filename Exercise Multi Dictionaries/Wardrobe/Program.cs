using System;
using System.Collections.Generic;

namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var clothes = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()).Contains("->"))
            {
                string[] command = input.Split(" -> ");

                string color = command[0];

                string[] currentClothes = command[1].Split(",");

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                foreach (var cloth in currentClothes)
                {
                    if (!clothes[color].ContainsKey(cloth))
                    {
                        clothes[color].Add(cloth, 0);
                    }

                    clothes[color][cloth]++;
                }
            }

            string search = input;

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cl in color.Value)
                {
                    if (color.Key == search.Split()[0] && cl.Key == search.Split()[1])
                    {
                        Console.WriteLine($"* {cl.Key} - {cl.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {cl.Key} - {cl.Value}");
                }
            }
        }
    }
}
