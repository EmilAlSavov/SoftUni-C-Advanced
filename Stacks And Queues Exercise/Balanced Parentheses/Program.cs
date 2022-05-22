using System;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input  = Console.ReadLine();

            Stack<char> openBrackets = AddInputInStack(input);

            Queue<char> closedBrackets = AddInputInQueue(input);

            if (closedBrackets.Count != openBrackets.Count)
            {
                Console.WriteLine("NO");
                return;
            }

            if (closedBrackets.Count == 0)
            {
                Console.WriteLine("NO");
                return;
            }

            while (openBrackets.Count > 0)
            {
                char currOpenBracket = openBrackets.Pop();

                char currClosedBracket = closedBrackets.Dequeue();

                if (currOpenBracket == '(')
                {
                    if (currClosedBracket != ')')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (currOpenBracket == '{')
                {
                    if (currClosedBracket != '}')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                } 
                else if (currOpenBracket == '[')
                {
                    if (currClosedBracket != ']')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return
                }
            }
            Console.WriteLine("YES");
        }

        public static Stack<char> AddInputInStack(string input)
        {
            Stack<char> openBrackets = new Stack<char>();

            for (int i = 0; i < input.Length / 2; i++)
            {
                openBrackets.Push(input[i]);
            }
            return openBrackets;
        }

        public static Queue<char> AddInputInQueue(string input)
        {
            Queue<char> closedBrackets = new Queue<char>();

            for (int i = input.Length / 2; i < input.Length; i++)
            {
                closedBrackets.Enqueue(input[i]);
            }

            return closedBrackets;
        }
    }
}
