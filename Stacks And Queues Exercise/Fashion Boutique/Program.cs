using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> clothes = new Stack<int>(input);

            int capacity = int.Parse(Console.ReadLine());
            int rackCounter = 1;
            int sum = 0;

            while (clothes.Count > 0)
            {
                int currClothe = clothes.Pop();


                if (sum + currClothe <= capacity)
                {
                    sum += currClothe;
                }
                else
                {
                    sum = 0;
                    rackCounter++;
                    sum += currClothe;
                }
            }
            Console.WriteLine(rackCounter);
        }
    }
}
