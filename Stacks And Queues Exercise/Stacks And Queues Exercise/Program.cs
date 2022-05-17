using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		string[] input = Console.ReadLine().Split();
		int n = int.Parse(input[0]);
		int s = int.Parse(input[1]);
		int x = int.Parse(input[2]);

		string[] numbers = Console.ReadLine().Split();
		Stack<int> stack = new Stack<int>();

		foreach (var num in numbers)
		{
			stack.Push(int.Parse(num));
		}

		for (int i = 0; i < s; i++)
		{
			stack.Pop();
		}

		if (stack.Contains(x))
		{
			Console.WriteLine("true");
        }
        else if (stack.Count == 0)
        {
            Console.WriteLine(0);
        }
		else
		{
			int bigNum = int.MaxValue;

			foreach (var num in stack)
			{
				if (num < bigNum)
				{
					bigNum = num;
				}
			}
			Console.WriteLine(bigNum);
		}
	}
}