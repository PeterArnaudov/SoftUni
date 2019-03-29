namespace SoftUniParty
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main()
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    guests.Add(input);
                }

                input = Console.ReadLine();
            }



            input = Console.ReadLine();

            while (input != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Remove(input);
                }
                else
                {
                    guests.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(vipGuests.Count + guests.Count);

            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
