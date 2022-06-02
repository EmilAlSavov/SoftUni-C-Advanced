using System;
using System.Linq;

namespace Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vattedNums = Console.ReadLine().Split(", ").Select(double.Parse).Select( x => x + (x * 0.2)).ToArray();

            foreach (var vattedNum in vattedNums)
            {
                Console.WriteLine($"{vattedNum:f2}");
            }
        }
    }
}
