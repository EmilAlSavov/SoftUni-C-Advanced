using System;
using System.Collections.Generic;
using System.Text;

namespace Define_a_Class_Person
{
    internal class Family
    {
        public Family()
        {
            fam = new List<Person>();
        }
        private List<Person> fam;

        public void AddMember(Person p)
        {
            fam.Add(p);
        }

        public Person GetOldestMember()
        {
            int minVal = int.MinValue;
            Person per = null;

            foreach (var p in fam)
            {
                if (p.Age > minVal)
                {
                    minVal = p.Age;
                    per = p;
                }
            }
            return per;
        }
    }
}
