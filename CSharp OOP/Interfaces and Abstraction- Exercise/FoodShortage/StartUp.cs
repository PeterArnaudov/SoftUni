namespace FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int commands = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < commands; i++)
            {
                string[] information = Console.ReadLine().Split();

                if (information.Length == 3)
                {
                    buyers.Add(new Rebel(information[0], int.Parse(information[1]), information[2]));
                }
                else if (information.Length == 4)
                {
                    buyers.Add(new Citizen(information[0], int.Parse(information[1]), information[2],
                        DateTime.ParseExact(information[3], "dd/MM/yyyy", CultureInfo.InvariantCulture)));
                }
            }

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                if (buyers.Any(b => b.Name == name))
                {
                    buyers.Find(b => b.Name == name).BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
