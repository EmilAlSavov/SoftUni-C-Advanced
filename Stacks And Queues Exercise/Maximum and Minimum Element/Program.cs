using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    int element = command[1];
                    numbers.Push(element);
                }
                if (numbers.Count <= 0)
                {
                    continue;
                }
                else if (command[0] == 2)
                {
                    numbers.Pop();
                }
                else if (command[0] == 3)
                {
                    Console.WriteLine(MaxNumInStack(numbers));
                }
                else if (command[0] == 4)
                {
                    Console.WriteLine(MinNumInStack(numbers));
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }

        static  int MaxNumInStack(Stack<int> stack)
        {
            int minValue = int.MinValue;

            foreach (var el in stack)
            {
                if (el > minValue)
                {
                    minValue = el;
                }
            }
            return minValue;
        }

        static int MinNumInStack(Stack<int> stack)
        {
            int maxValue = int.MaxValue;

            foreach (var el in stack)
            {
                if (el < maxValue)
                {
                    maxValue = el;
                }
            }
            return maxValue;
        }
    }
}
