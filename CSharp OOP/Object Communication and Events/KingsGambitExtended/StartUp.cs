namespace KingsGambitExtended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string kingName = Console.ReadLine();
            string[] guardsNames = Console.ReadLine().Split();
            string[] footmenNames = Console.ReadLine().Split();

            King king = new King(kingName);
            List<Soldier> soldiers = new List<Soldier>();

            foreach (var name in guardsNames)
            {
                RoyalGuard guard = new RoyalGuard(name);
                king.AddSoldier(guard);
            }

            foreach (var name in footmenNames)
            {
                Footman footman = new Footman(name);
                king.AddSoldier(footman);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }
                else if (input[0] == "Kill")
                {
                    Soldier soldier = king.Soldiers.FirstOrDefault(s => s.Name == input[1]);
                    soldier.TakeAttack();
                }
                else if (input[0] == "Attack")
                {
                    king.OnAttack();
                }
            }
        }
    }
}
