using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nethen_Realms
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<Monster> monsters = new List<Monster>();

            for (int i = 0; i < input.Length; i++)
            {
                MatchCollection letters = Regex.Matches(input[i], @"[^\d\.\+\-\*\/]");
                MatchCollection numbers = Regex.Matches(input[i], @"-?\+?\d*\.?\d+");

                int health = 0;
                double power = 0.0;

                foreach (Match letter in letters)
                {
                    var currentLetter = letter.Value;
                    health += currentLetter[0];
                }

                foreach (Match number in numbers)
                {
                    power += double.Parse(number.Value);
                }

                foreach (var character in input[i])
                {
                    if (character == '*')
                    {
                        power *= 2;
                    }
                    else if (character == '/')
                    {
                        power /= 2;
                    }
                }

                monsters.Add(new Monster(input[i], health, power));
            }

            foreach (var monster in monsters.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{monster.Name} - {monster.Health} health, {monster.Power:f2} damage");
            }
        }
    }

    public class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Power { get; set; }

        public Monster(string name, int health, double power)
        {
            Name = name;
            Health = health;
            Power = power;
        }
    }
}
