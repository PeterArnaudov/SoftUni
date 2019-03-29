namespace DungeonsAndCodeWizards.Core.Factories
{
    using DungeonsAndCodeWizards.Models.Characters;
    using DungeonsAndCodeWizards.Models.Enums;
    using System;

    public static class CharacterFactory
    {
        public static Character CreateCharacter(string faction, string characterType, string name)
        {
            if (faction != "CSharp" && faction != "Java")
            {
                throw new ArgumentException($"Invalid faction {(char)34}{faction}{(char)34}!");
            }

            if (characterType == "Warrior")
            {
                return new Warrior(name, Enum.Parse<Faction>(faction));
            }
            else if (characterType == "Cleric")
            {
                return new Cleric(name, Enum.Parse<Faction>(faction));
            }
            else
            {
                throw new ArgumentException($"Invalid character type {(char)34}{characterType}{(char)34}!");
            }
        }
    }
}
