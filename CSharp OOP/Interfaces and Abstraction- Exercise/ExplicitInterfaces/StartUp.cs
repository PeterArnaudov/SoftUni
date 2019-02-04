namespace ExplicitInterfaces
{
    using Interfaces;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                string[] information = Console.ReadLine().Split();

                if (information[0] == "End")
                {
                    break;
                }

                Citizen citizen = new Citizen(information[0], information[1], int.Parse(information[2]));
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}
