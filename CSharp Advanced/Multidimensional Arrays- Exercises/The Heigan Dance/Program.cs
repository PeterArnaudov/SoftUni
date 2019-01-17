namespace The_Heigan_Dance
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[,] field = new int[15, 15];

            double damagePerTurn = double.Parse(Console.ReadLine());
            double playerHealth = 18500;
            double bossHealth = 3000000;

            int playerRow = 7;
            int playerColumn = 7;
            bool plague = false;
            bool bossDead = false;
            bool playerDead = false;
            string killedBy = string.Empty;

            while (!bossDead && !playerDead)
            {
                bossHealth -= damagePerTurn;

                if (plague)
                {
                    playerHealth -= 3500;
                    plague = false;

                    if (playerHealth <= 0)
                    {
                        playerDead = true;
                        killedBy = "Player: Killed by Plague Cloud";
                    }
                }

                if (bossHealth <= 0)
                {
                    bossDead = true;
                    break;
                }

                string[] attack = Console.ReadLine().Split();

                string attackType = attack[0];
                int attackRow = int.Parse(attack[1]);
                int attackColumn = int.Parse(attack[2]);

                if (IsInDamageArea(attackRow, attackColumn, playerRow, playerColumn)) //if in the damage area- move
                {
                    if (!IsInDamageArea(attackRow, attackColumn, playerRow - 1, playerColumn) && !IsWall(playerRow - 1)) //if when moved the player is not in the damage area- move and continue with the next turn
                    {
                        playerRow--;
                    }
                    else if (!IsInDamageArea(attackRow, attackColumn, playerRow, playerColumn + 1) && !IsWall(playerColumn + 1)) // same
                    {
                        playerColumn++;
                    }
                    else if (!IsInDamageArea(attackRow, attackColumn, playerRow + 1, playerColumn) && !IsWall(playerRow + 1)) // same
                    {
                        playerRow++;
                    }
                    else if (!IsInDamageArea(attackRow, attackColumn, playerRow, playerColumn - 1) && !IsWall(playerColumn - 1)) // same
                    {
                        playerColumn--;
                    }
                    else //if not possible to get away from the damage area- stay and take damage
                    {
                        if (attackType == "Eruption")
                        {
                            playerHealth -= 6000;

                            if (playerHealth <= 0 && !playerDead)
                            {
                                playerDead = true;
                                killedBy = "Player: Killed by Eruption";
                            }
                        }
                        else if (attackType == "Cloud")
                        {
                            playerHealth -= 3500;
                            plague = true;

                            if (playerHealth <= 0 && !playerDead)
                            {
                                playerDead = true;
                                killedBy = "Player: Killed by Plague Cloud";
                            }
                        }
                    }
                }
            }

            if (playerDead && bossDead) //if both dead
            {
                Console.WriteLine($"Heigan: Defeated!");
                Console.WriteLine(killedBy);
                Console.WriteLine($"Final position: {playerRow}, {playerColumn}");
            }
            else if (playerDead)
            {
                Console.WriteLine($"Heigan: {bossHealth:f2}");
                Console.WriteLine(killedBy);
                Console.WriteLine($"Final position: {playerRow}, {playerColumn}");
            }
            else if (bossDead)
            {
                Console.WriteLine($"Heigan: Defeated!");
                Console.WriteLine($"Player: {playerHealth}");
                Console.WriteLine($"Final position: {playerRow}, {playerColumn}");
            }
        }

        //check if the cell the player is about to walk into will be non-existant (wall in this case)
        public static bool IsWall(int move)
        {
            return move < 0 || move >= 15;
        }

        //check if the cell the player currently is or will be is in the area hit by the boss
        public static bool IsInDamageArea(int attackRow, int attackColumn, int moveRow, int moveColumn)
        {
            return ((attackRow - 1 <= moveRow && moveRow <= attackRow + 1) && (attackColumn - 1 <= moveColumn && moveColumn <= attackColumn + 1));
        }
    }
}
