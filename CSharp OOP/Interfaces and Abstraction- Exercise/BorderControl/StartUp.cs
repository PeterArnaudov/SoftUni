namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<IIdentificatable> tryingToPass = new List<IIdentificatable>();

            while (true)
            {
                string[] passerInformation = Console.ReadLine().Split();

                if (passerInformation[0] == "End")
                {
                    break;
                }

                if (passerInformation.Length == 2)
                {
                    tryingToPass.Add(new Robot(passerInformation[0], passerInformation[1]));
                }
                else if (passerInformation.Length == 3)
                {
                    tryingToPass.Add(new Citizen(passerInformation[0], int.Parse(passerInformation[1]), passerInformation[2]));
                }
            }

            string forbiddenLastDigits = Console.ReadLine();

            tryingToPass
                .Where(x => x.Id.EndsWith(forbiddenLastDigits))
                .ToList()
                .ForEach(x => Console.WriteLine(x.Id));
        }
    }
}
