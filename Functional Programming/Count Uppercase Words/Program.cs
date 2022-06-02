using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] UpperCaseWords = Console.ReadLine().Split(' ').Where(x => x.Length > 0).Where(x => char.IsUpper(x[0])).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, UpperCaseWords));
        }
    }
}
