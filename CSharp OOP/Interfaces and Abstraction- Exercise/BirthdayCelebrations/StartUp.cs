namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using BirthdayCelebrations.Interfaces;

    public class StartUp
    {
        public static void Main()
        {
            List<IBirthable> born = new List<IBirthable>();

            while (true)
            {
                string[] information = Console.ReadLine().Split();

                if (information[0] == "End")
                {
                    break;
                }
                else if (information[0] == "Citizen")
                {
                    born.Add(new Citizen(information[1], int.Parse(information[2]), information[3], 
                        DateTime.ParseExact(information[4], "dd/MM/yyyy", CultureInfo.InvariantCulture)));
                }
                else if (information[0] == "Pet")
                {
                    born.Add(new Pet(information[1], DateTime.ParseExact(information[2], "dd/MM/yyyy", CultureInfo.InvariantCulture)));
                }
            }

            int celebratingYear = int.Parse(Console.ReadLine());

            born
                .Where(x => x.Birthdate.Year.Equals(celebratingYear))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Birthdate.Day:d2}/{x.Birthdate.Month:d2}/{x.Birthdate.Year}"));
        }
    }
}
