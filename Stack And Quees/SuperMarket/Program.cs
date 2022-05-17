using System;
using System.Collections.Generic;

namespace SuperMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            Queue<string> names = new Queue<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    names.Enqueue(input);
                }
                else
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
