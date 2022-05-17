using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(input);

            Console.WriteLine(BiggestOrder(orders));

            while (orders.Count > 0)
            {
                var currOrder = orders.Peek();

                if (currOrder <= quantityOfFood)
                {
                    orders.Dequeue();
                    quantityOfFood -= currOrder;
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
        static int BiggestOrder(Queue<int> orders)
        {
            int minValue = int.MinValue;
            foreach (var order in orders)
            {
                if (order > minValue)
                {
                    minValue = order;
                }
            }
            return minValue;
        }
    }
}
