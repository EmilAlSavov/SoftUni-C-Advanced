using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '(')
                {
                    stack.Push(i);
                }
                if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;

                    Console.WriteLine(input.Substring(startIndex, endIndex - startIndex + 1));
                }
            }
        }
    }
}
