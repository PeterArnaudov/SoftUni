namespace KingsGambit
{
    using System;
    using System.Collections.Generic;

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
                soldiers.Add(guard);
                king.UnderAttack += guard.KingUnderAttack;
            }

            foreach (var name in footmenNames)
            {
                Footman footman = new Footman(name);
                soldiers.Add(footman);
                king.UnderAttack += footman.KingUnderAttack;
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
                    Soldier soldier = soldiers.Find(s => s.Name == input[1]);
                    soldiers.Remove(soldier);
                    king.UnderAttack -= soldier.KingUnderAttack;
                }
                else if (input[0] == "Attack")
                {
                    king.OnAttack();
                }
            }
        }
    }
}
