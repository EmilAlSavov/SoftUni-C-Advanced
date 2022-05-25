using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            bool partyMode = false;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {

                if (input == "PARTY")
                {
                    partyMode = true;
                    continue;
                }

                string guest = input;

                if (partyMode == false)
                {
                    if (char.IsDigit(guest[0]))
                    {
                        if (vipGuests.Contains(guest))
                        {
                            continue;
                        }
                        vipGuests.Add(guest);
                    }
                    else
                    {
                        if (guests.Contains(guest))
                        {
                            continue;
                        }
                        guests.Add(guest);
                    }
                }
                else
                {
                    if (char.IsDigit(guest[0]))
                    {
                        if (!vipGuests.Contains(guest))
                        {
                            continue;
                        }
                        vipGuests.Remove(guest);
                    }
                    else
                    {
                        if (!guests.Contains(guest))
                        {
                            continue;
                        }
                        guests.Remove(guest);
                    }
                }
            }

            Console.WriteLine(vipGuests.Count + guests.Count);

            foreach (var vipGuest in vipGuests)
            {
                Console.WriteLine(vipGuest);
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
