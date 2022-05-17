using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numOfElements = input[0];
            int numOfElToRemove = input[1];
            int elementToLookFor = input[2];

            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>(elements);

            numbers = Deque(numOfElToRemove, numbers);

            LookForElement(elementToLookFor, numbers);

        }

        static Queue<int> Deque(int numToRem, Queue<int> numbers)
        {
            for (int i = 0; i < numToRem; i++)
            {
                numbers.Dequeue();
            }
            return numbers;
        }

        static void LookForElement(int elementToLookFor, Queue<int> elements)
        {
            if (elements.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
                return;
            } else if (elements.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                int maxValue = int.MaxValue;

                foreach (var el in elements)
                {
                    if (el < maxValue)
                    {
                        maxValue = el;
                    }
                }
                Console.WriteLine(maxValue);
                return;
            }
        }
    }
}
