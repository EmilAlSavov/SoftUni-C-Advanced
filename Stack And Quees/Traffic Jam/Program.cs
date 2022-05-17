using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPerLight = int.Parse(Console.ReadLine());
            int counter = 0;

            Queue<string> queue = new Queue<string>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    for (int i = 0; i < numPerLight; i++)
                    {
                        if (queue.Count == 0)
                        {
                            continue;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
