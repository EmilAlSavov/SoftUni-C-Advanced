    using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> peaple = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string name = input[0];
                int age = int.Parse(input[1]);

                peaple.Add(name, age);

            }
            string upOrDown = Console.ReadLine();
            int ageToSplit = int.Parse(Console.ReadLine());

            if (upOrDown == "younger")
            {
                peaple = peaple.Where(x => x.Value <= ageToSplit).ToDictionary(x => x.Key, x => x.Value);
            }
            else
            {
                peaple = peaple.Where(x => x.Value >= ageToSplit).ToDictionary(x => x.Key, x => x.Value);
            }

            foreach (var person in peaple)
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }
        }
    }
}
