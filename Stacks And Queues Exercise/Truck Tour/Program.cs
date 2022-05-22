using System;
using System.Linq;

namespace Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPumps = int.Parse(Console.ReadLine());

            int result = -1;
            int counter = 0;

            for (int i = 0; i < numOfPumps; i++)
            {
                int[] pumps = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int amauntOfGas = pumps[0];
                int amauntOfDistance = pumps[1];

                if (amauntOfDistance > amauntOfGas)
                {
                    continue;
                }
                else
                {
                    if (counter == 0)
                    {
                        result = i;
                        counter++;
                    }
                    counter++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
