using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> house = new Dictionary<string, int>();
            Stack<int> whiteTile = new Stack<int>();
            Queue<int> greyTile = new Queue<int>();

            int[] whiteTalesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] greyTalesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Insert(ref whiteTile, ref greyTile, whiteTalesInput, greyTalesInput);

            while (true)
            {
                if (whiteTile.Count == 0 || greyTile.Count == 0)
                {
                    break;
                }
                int currWhiteTile = whiteTile.Pop();
                int currGreyTile = greyTile.Dequeue();

                if (currGreyTile == currWhiteTile)
                {
                    int newTile = currWhiteTile + currGreyTile;
                    house = Insert(house, newTile);
                }
                else
                {
                    whiteTile.Push(currWhiteTile / 2);
                    greyTile.Enqueue(currGreyTile);
                }
            }
            if (whiteTile.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTile)}");
            }

            if (greyTile.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTile)}");
            }

            house = house.OrderByDescending(x => x.Value).ThenBy(y => y.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in house)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static void Insert(ref Stack<int> whiteTile,ref Queue<int> greyTile
            , int[] whiteTalesInput,  int[] greyTalesInput)
        {

            foreach (var item in whiteTalesInput)
            {
                whiteTile.Push(item);
            }

            foreach (var item in greyTalesInput)
            {
                greyTile.Enqueue(item);
            }
        }

        public static Dictionary<string, int> Insert(Dictionary<string, int> hause, int newTile)
        {
            if (newTile == 40)
            {
                if (!hause.ContainsKey("Sink"))
                {
                    hause.Add("Sink", 0);
                }
                hause["Sink"]++;
            }
            else if (newTile == 50)
            {
                if (!hause.ContainsKey("Oven"))
                {
                    hause.Add("Oven", 0);
                }
                hause["Oven"]++;
            }
            else if (newTile == 60)
            {
                if (!hause.ContainsKey("Countertop"))
                {
                    hause.Add("Countertop", 0);
                }
                hause["Countertop"]++;
            }
            else if (newTile == 70)
            {
                if (!hause.ContainsKey("Wall"))
                {
                    hause.Add("Wall", 0);
                }
                hause["Wall"]++;
            }
            else
            {
                if (!hause.ContainsKey("Floor"))
                {
                    hause.Add("Floor", 0);
                }
                hause["Floor"]++;
            }
            return hause;
        }
    }
}
