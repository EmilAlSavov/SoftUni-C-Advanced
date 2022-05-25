using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Dictionary<string, double>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] command = input.Split(", ");

                string shop = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);

                if (!dic.ContainsKey(shop))
                {
                    dic.Add(shop, new Dictionary<string, double>());
                }

                dic[shop].Add(product, price);
            }
            dic = dic.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var shop in dic)
            {
                Console.WriteLine($"{shop.Key} ->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
