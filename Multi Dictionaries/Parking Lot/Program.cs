using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carLot = new HashSet<string>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ");

                string commandType = command[0];
                string carCode = command[1];

                if (commandType == "IN")
                {
                    carLot.Add(carCode);
                }
                else
                {
                    carLot.Remove(carCode);
                }
            }

            if (carLot.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in carLot)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
