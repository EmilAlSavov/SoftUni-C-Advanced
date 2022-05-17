using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(input.Reverse());

            int num = 0;
            string lastOp = string.Empty;

            while(stack.Count > 0)
            {
                string currPeak = stack.Pop();
                if (currPeak == "+" || currPeak == "-")
                {
                    if (currPeak.ToString() != string.Empty && currPeak != " ")
                    {
                        lastOp = currPeak;
                    }
                }
                else
                {
                    if (lastOp == String.Empty)
                    {
                        num = int.Parse(currPeak);
                    }
                    else if (lastOp == "+")
                    {
                        num += int.Parse(currPeak);
                    }
                    else if (lastOp == "-")
                    {
                        num -= int.Parse(currPeak);
                    }
                }
            }
            Console.WriteLine(num);
        }
    }
}
