using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(input);

            while (songs.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string song = command.Replace("Add ", string.Empty);

                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
