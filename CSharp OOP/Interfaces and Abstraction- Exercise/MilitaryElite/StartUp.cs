namespace MilitaryElite
{
    using MilitaryElite.Classes;
    using MilitaryElite.Classes.Soldiers;
    using MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Soldier> soldiers = new List<Soldier>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArray = command.Split();

                if (commandArray[0] == "Private")
                {
                    AddPrivate(soldiers, commandArray);
                }
                else if (commandArray[0] == "Spy")
                {
                    AddSpy(soldiers, commandArray);
                }
                else if (commandArray[0] == "LieutenantGeneral")
                {
                    AddGeneral(soldiers, commandArray);
                }
                else if (commandArray[0] == "Engineer")
                {
                    AddEngineer(soldiers, commandArray);
                }
                else if (commandArray[0] == "Commando")
                {
                    AddCommando(soldiers, commandArray);
                }
            }

            soldiers.ForEach(Console.WriteLine);
        }

        public static void AddPrivate(List<Soldier> soldiers, string[] commandArray)
        {
            soldiers.Add(new Private(commandArray[1], commandArray[2], commandArray[3], decimal.Parse(commandArray[4])));
        }

        public static void AddSpy(List<Soldier> soldiers, string[] commandArray)
        {
            soldiers.Add(new Spy(commandArray[1], commandArray[2], commandArray[3], int.Parse(commandArray[4])));
        }

        public static void AddGeneral(List<Soldier> soldiers, string[] commandArray)
        {
            LieutenantGeneral general = new LieutenantGeneral(commandArray[1], commandArray[2], commandArray[3], decimal.Parse(commandArray[4]));

            for (int i = 5; i < commandArray.Length; i++)
            {

                Private pr = (Private)soldiers.Find(s => s.Id == commandArray[i]);
                general.Privates.Add(pr);
            }

            soldiers.Add(general);
        }

        public static void AddEngineer(List<Soldier> soldiers, string[] commandArray)
        {
            try
            {
                Engineer engineer = new Engineer(commandArray[1], commandArray[2], commandArray[3], decimal.Parse(commandArray[4]), commandArray[5]);

                for (int i = 6; i < commandArray.Length; i += 2)
                {
                    Repair repair = new Repair(commandArray[i], int.Parse(commandArray[i + 1]));
                    engineer.Repairs.Add(repair);
                }

                soldiers.Add(engineer);
            }
            catch (ArgumentException)
            {

            }
        }

        public static void AddCommando(List<Soldier> soldiers, string[] commandArray)
        {
            try
            {
                Commando commando = new Commando(commandArray[1], commandArray[2], commandArray[3], decimal.Parse(commandArray[4]), commandArray[5]);

                for (int i = 6; i < commandArray.Length; i += 2)
                {
                    try
                    {
                        Mission mission = new Mission(commandArray[i], commandArray[i + 1]);
                        commando.Missions.Add(mission);
                    }
                    catch (ArgumentException)
                    {

                    }
                }

                soldiers.Add(commando);
            }
            catch (ArgumentException)
            {

            }
        }
    }
}
