using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_a_Class_Person
{
    public class StartUp
    {
        static void Main()
        {
            Family savovi = new Family();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                savovi.AddMember(new Person(name, age));
            }

            Console.WriteLine(savovi.GetOldestMember().Name + " " + savovi.GetOldestMember().Age);

        }
    }
}
