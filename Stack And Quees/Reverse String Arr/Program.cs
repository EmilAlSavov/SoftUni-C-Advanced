using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_String_Arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < word.Length; i++)
            {
                stack.Push(word[i]);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
