using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var num in arr)
            {
                stack.Push(num);
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');
                string type = command[0];

                if (type == "add")
                {
                    int num1 = int.Parse(command[1]);
                    int num2 = int.Parse(command[2]);

                    stack.Push(num1);
                    stack.Push(num2);
                } else if (type == "remove")
                {
                    int count = int.Parse(command[1]);

                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            int sum = 0;
            foreach (var num in stack)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
